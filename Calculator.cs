using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace Calculator
{
	class Calculator
	{
		bool IsFunction(string token) => token.All(c => char.IsLower(c));
		bool IsConst(string token) => token.All(c => char.IsUpper(c));

		byte GetPriority(string op)
		{
			switch (op)
			{
				case "+":
				case "-":
					return 1;
				case "*":
				case "/":
					return 2;
				case "^":
				case "√":
				case "#": // unary sqrt
					return 3;
				case "~": // unary minus
					return 4;
				case ":": // mod
					return 5;
				case "(":
					return 0;
			}
			
			throw new NotImplementedException();
		}

		string[] Parse(string expr)
		{
			List<string> main = new List<string>(expr.Length);
			StringBuilder builder = new StringBuilder(16);
			
			for (int i = 0; i < expr.Length; i++)
			{
				char c = expr[i];
				
				if (char.IsLetterOrDigit(c) || c == '.')
				{
					builder.Append(c);
					continue;
				}
				
				if ("√-+".Contains(c))
				{
					// i = 0
					// [ prev isn't ')' or next is '(' ] and [ prev isn't letter or digit ] and [ prev isn't '(' and next isn't '(' ]
					
					if (
						i == 0 ||
						(expr[i-1] != ')' || expr[i+1] == '(') && !char.IsLetterOrDigit(expr[i-1]) &&
						(expr[i-1] != ')' && expr[i+1] != '(')
					)
					{
						switch (c)
						{
							case '√': c = '#'; break;
							case '+': continue;
							case '-': c = '~'; break;
						}
					}
				}
				
				if (builder.Length != 0)
				{
					main.Add(builder.ToString());
					builder.Clear();
				}
				main.Add(c.ToString());
			}
			if (builder.Length != 0)
				main.Add(builder.ToString());
			return main.ToArray();
		}
		
		string[] Create(string[] parsed)
		{
			List<string> main = new List<string>(parsed.Length);
			Stack<string> opers = new Stack<string>(parsed.Length);
			
			string poped;
			foreach (string token in parsed)
			{
				if (IsConst(token) || double.TryParse(token, NumberStyles.Float, NumberFormatInfo.InvariantInfo, out _))
				{
					main.Add(token);
					continue;
				}
				
				if (token == ",")
				{
					while (opers.Peek() != "(")
						main.Add(opers.Pop());
					continue;
				}
				
				if (IsFunction(token) || token == "(" || opers.Count == 0)
				{
					opers.Push(token);
					continue;
				}
				
				if (token == ")")
				{
					while (true)
					{
						poped = opers.Pop();
						if (poped == "(")
						{
							if (opers.Count != 0 && IsFunction(opers.Peek()))
								main.Add(opers.Pop());
							break;
						}
						main.Add(poped);
					}
					continue;
				}
				
				byte tokenPrty = GetPriority(token);
				byte peekPrty = GetPriority(opers.FirstOrDefault(op => op != "~" && op != "#") ?? "(");
				if (tokenPrty > peekPrty || tokenPrty >= 3 && peekPrty >= 3)
				{
					opers.Push(token);
					continue;
				}
				
				while (opers.Count != 0 && opers.Peek() != "(")
				{
					poped = opers.Pop();
					main.Add(poped);
					if (tokenPrty == GetPriority(poped)) break;
				}
				opers.Push(token);
			}
			while (opers.Count != 0)
				main.Add(opers.Pop());
			return main.ToArray();
		}
		
		public double Evaluate(string expr)
		{
			if (string.IsNullOrWhiteSpace(expr))
				return default;
			
			string[] rpn = Create(Parse(expr));
			
			Stack<double> nums = new Stack<double>(rpn.Length / 2 + 1);
			foreach (string token in rpn)
			{
				if (TryGetConst(token, out double num) ||
					double.TryParse(token, NumberStyles.Float, NumberFormatInfo.InvariantInfo, out num))
				{
					nums.Push(num);
					continue;
				}
				
				double x = nums.Pop();
				if (TryCallUnaryFunc(token, x, out double result))
				{
					nums.Push(result);
					continue;
				}
				
				double y = nums.Pop();
				if (TryCallBinaryFunc(token, y, x, out result))
				{
					nums.Push(result);
					continue;
				}
				throw new NotImplementedException();
			}
			return nums.Count != 1 ? throw new InvalidOperationException() : nums.Peek();
		}

		public double Memory { get; set; }
		
		bool TryGetConst(string name, out double value)
		{
			switch (name)
			{
				case "PI":
					value = Math.PI;
					break;
				case "E":
					value = Math.E;
					break;
				case "M":
					value = Memory;
					break;
				default:
					value = default;
					return false;
			}
			return true;
		}
		
		double Factorial(double x)
		{
			if (double.IsInfinity(x))
				return double.PositiveInfinity;

			int result = 1;
			for (int i = (int)x; i > 1; i--)
			{
				result *= i;
			}
			return result;
		}

		bool TryCallUnaryFunc(string func, double x, out double result)
		{
			switch (func)
			{
				case "sqrt":
					result = Math.Sqrt(x);
					break;
				case "fact":
					result = Factorial(x);
					break;
				case "ln":
					result = Math.Log(x);
					break;
				case "abs":
					result = Math.Abs(x);
					break;
				case "int":
					result = Math.Truncate(x);
					break;
				case "rnd":
					result = Math.Round(x);
					break;
				case "sign":
					result = Math.Sign(x);
					break;
				// operations
				case "~":
					result = -x;
					break;
				case "#":
					result = Math.Sqrt(x);
					break;
				default:
					// trigonometry
					double angle = x * Math.PI / 180;
					bool is90 = x % 180 == 90;
					switch (func)
					{
						case "sin":
							result = Math.Sin(angle);
							break;
						case "cos":
							result = is90 ? 0 : Math.Cos(angle);
							break;
						case "tg":
						case "tan":
							result = is90 ? throw new DivideByZeroException() : Math.Tan(angle);
							break;
						case "cot":
						case "ctg":
							double mod180 = x % 180;
							if (mod180 == 0 || mod180 == 180)
								throw new DivideByZeroException();
							result = 1 / Math.Tan(angle);
							break;
						default:
							result = default;
							return false;
					}
					break;
			}

			return true;
		}
		
		readonly Lazy<Random> random = new Lazy<Random>();
		bool TryCallBinaryFunc(string func, double x, double y, out double result)
		{
			switch (func)
			{
				case "root":
					result = Math.Pow(y, 1 / x);
					break;
				case "min":
					result = Math.Min(x, y);
					break;
				case "max":
					result = Math.Max(x, y);
					break;
				case "log":
					result = y == 10 ? Math.Log10(x) : Math.Log(y, x);
					break;
				case "rand":
					result = random.Value.Next((int) Math.Min(x, y), (int) Math.Max(x, y));
					break;
				// operations
				case "+":
					result = x + y;
					break;
				case "-":
					result = x - y;
					break;
				case "*":
					result = x * y;
					break;
				case "/":
					if (y == 0)
						throw new DivideByZeroException();
					result = x / y;
					break;
				case ":":
					if (y == 0)
						throw new DivideByZeroException();
					result = x % y;
					break;
				case "^":
					result = Math.Pow(x, y);
					break;
				case "√":
					result = Math.Pow(y, 1 / x);
					break;
				default:
					result = default;
					return false;
			}
			return true;
		}
	}
}