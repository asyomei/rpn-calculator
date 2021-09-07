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
					return 3;
				case "#":
					return 4;
				default:
					return 0;
			}
		}

		string[] Parse(string expr)
		{
			List<string> mainList = new List<string>(expr.Length);
			StringBuilder builder = new StringBuilder(expr.Length / 2);

			bool isFuncName = false;
			for (int i = 0; i < expr.Length; i++)
			{
				char c = expr[i];
				if (c == ' ') continue;

				if (isFuncName || (isFuncName = char.IsLetter(c)))
				{
					if (c == '(')
					{
						isFuncName = false;
						mainList.Add(builder.ToString());
						mainList.Add("(");
						builder.Clear();
						continue;
					}
					if (!char.IsLetterOrDigit(c))
					{
						isFuncName = false;
						mainList.Add(builder.ToString());
						builder.Clear();
						i--;
						continue;
					}
					builder.Append(c);
					continue;
				}


				if (char.IsDigit(c) || c == '.')
				{
					builder.Append(c);
					continue;
				}

				if (c == '-' && (i == 0 || expr[i - 1] != ')' && (builder.Length == 0 || !char.IsDigit(expr[i-1]) && expr[i+1] == '(')))
				{
					c = '#';
				}

				if (builder.Length != 0)
				{
					mainList.Add(builder.ToString());
					builder.Clear();
				}
				mainList.Add(c.ToString());
			}
			if (builder.Length != 0)
				mainList.Add(builder.ToString());
			return mainList.ToArray();
		}

		bool IsFunction(string token) => token.Contains("log") || token.All(c => char.IsLetter(c));

		string[] Create(string[] parsed)
		{
			List<string> mainList = new List<string>(parsed.Length);
			Stack<string> opers = new Stack<string>(parsed.Length);

			string poped;
			foreach (string token in parsed)
			{
				if (IsMathConst(token, out _) || double.TryParse(token, NumberStyles.Float, CultureInfo.InvariantCulture, out _))
				{
					mainList.Add(token);
					continue;
				}
				if (opers.Count == 0 || token == "(" || IsFunction(token))
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
								mainList.Add(opers.Pop());
							break;
						}
						mainList.Add(poped);
					}
					continue;
				}
				if (GetPriority(opers.Peek()) < GetPriority(token) || opers.Peek() == "^" && token == "^")
				{
					opers.Push(token);
					continue;
				}
				byte token_prty = GetPriority(token);
				while (true)
				{
					if (opers.Count == 0 || opers.Peek() == "(") break;
					poped = opers.Pop();
					mainList.Add(poped);
					if (GetPriority(poped) == token_prty) break;
				}
				opers.Push(token);
			}
			while (opers.Count != 0)
				mainList.Add(opers.Pop());
			return mainList.ToArray();
		}

		public double Evaluate(string expr)
		{
			string[] rpn = Create(Parse(expr));
			Stack<double> nums = new Stack<double>(rpn.Length / 2);

			foreach (string token in rpn)
			{
				if (IsMathConst(token, out double num) || double.TryParse(token, NumberStyles.Float, CultureInfo.InvariantCulture, out num))
				{
					nums.Push(num);
					continue;
				}

				if (token == "#")
				{
					nums.Push(-nums.Pop());
					continue;
				}

				if (IsFunction(token))
				{
					nums.Push(CallFunc(token, nums.Pop()));
					continue;
				}

				double y = nums.Pop(), x = nums.Pop();
				nums.Push(DoOperation(x, y, token));
			}
			return nums.Pop();
		}

		bool IsMathConst(string token, out double value)
		{
			switch (token)
			{
				case "pi":
					value = Math.PI;
					return true;
				case "e":
					value = Math.E;
					return true;
			}
			value = 0;
			return false;
		}

		double CallFunc(string funcName, double arg)
		{
			const double
				NUM_TO_DEG = 57.295779513082,
				NUM_TO_RAD = 0.017453292519943;

			switch (funcName)
			{
				case "sin":
					return Math.Sin(arg);
				case "cos":
					return Math.Cos(arg);
				case "tg":
				case "tan":
					return Math.Tan(arg);
				case "ctg":
				case "cot":
					return 1 / Math.Tan(arg);
				case "deg":
					return arg * NUM_TO_DEG;
				case "rad":
					return arg * NUM_TO_RAD;
				case "abs":
					return Math.Abs(arg);
				case "sqrt":
					return Math.Sqrt(arg);
				case "exp":
					return Math.Exp(arg);
				case "log":
				case "ln":
					return Math.Log(arg);
				case var _ when funcName.StartsWith("log"):
					int logBase = int.Parse(funcName.Replace("log", ""));
					return Math.Log(arg, logBase);
				case "int":
					return Math.Truncate(arg);
				case "round":
					return Math.Round(arg);
			}

			throw new NotImplementedException();
		}

		double DoOperation(double x, double y, string op)
		{
			switch (op)
			{
				case "+": return x + y;
				case "-": return x - y;
				case "*": return x * y;
				case "/": return x / y;
				case "^": return Math.Pow(x, y);
			}

			throw new NotImplementedException();
		}
	}
}
