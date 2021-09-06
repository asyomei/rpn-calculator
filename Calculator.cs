using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * math_opers = ['+', '-', '*', '/', '^', '(', ')']

def rpn(expr):
  expr = parse(expr)
  main = []
  opers = []
  for token in expr:
	if token not in math_opers:
	  main += [token]
	  continue
	if len(opers) == 0 or token == '(':
	  opers = [token] + opers
	  continue
	if token == ')':
	  while True:
		poped = opers[0]
		opers = opers[1:]
		if poped == '(':
		  break
		main += [poped]
	  continue
	if prty(opers[0]) < prty(token) or \
	 token == '^' and opers[0] == '^':
	  opers = [token] + opers
	  continue
	while True:
	  if len(opers) == 0: break
	  poped = opers[0]
	  opers = opers[1:]
	  main += [poped]
	  if prty(poped) == prty(token):
		break
	opers = [token] + opers
  while len(opers) != 0:
	poped = opers[0]
	opers = opers[1:]
	main += [poped]
  return main

def prty(c):
  if c in '+-': return 1
  if c in '* /': return 2
  if c in '^': return 3
  return 0

def parse(expr):
  main = []
  num = ""
  for c in expr:
	if c == ' ':
	  continue
	if c not in math_opers or \
	 c == '-' and len(num) == 0:
	  num += c
	  continue
	if len(num) != 0:
	  main += [num]
	  num = ""
	main += [c]
  if len(num) != 0:
	main += [num]
  return main

s = "(99 + 23) - (123 + 69) - (12 + 55)"
print '|'.join(parse(s))
print
print '|'.join(rpn(s))

 */

namespace Calculator
{
	class Calculator
	{
		string[] unary_funcs = { "sin", "cos", "tg", "ctg", "abs" };
		string[] binary_funcs = { "min", "max" };
		string[] ternary_funcs = { };

		int GetFuncArgsLength(string funcName)
		{
			if (unary_funcs.Contains(funcName))
				return 1;
			if (binary_funcs.Contains(funcName))
				return 2;
			if (ternary_funcs.Contains(funcName))
				return 3;

			throw new NotImplementedException();
		}

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
				default:
					return 0;
			}
		}

		string[] Parse(string expr)
		{
			List<string> mainList = new List<string>(expr.Length);
			StringBuilder numBuilder = new StringBuilder();
			StringBuilder funcBuilder = new StringBuilder();

			foreach (char c in expr)
			{
				if (c == ' ') continue;
				if (char.IsDigit(c) || c == '.' || (c == '-' || c == '+') && numBuilder.Length == 0)
				{
					numBuilder.Append(c);
					continue;
				}
				if (char.IsLetter(c))
				{
					funcBuilder.Append(c);
					continue;
				}

				if (funcBuilder.Length != 0)
				{
					mainList.Add(funcBuilder.ToString());
					funcBuilder.Clear();
				}
				if (numBuilder.Length != 0)
				{
					mainList.Add(numBuilder.ToString());
					numBuilder.Clear();
				}
				if (c == ',') continue;
				mainList.Add(c.ToString());
			}
			if (numBuilder.Length != 0)
				mainList.Add(numBuilder.ToString());
			return mainList.ToArray();
		}

		bool IsFunction(string token) => token.All(c => char.IsLetter(c));

		string[] Create(string[] parsed)
		{
			List<string> mainList = new List<string>(parsed.Length);
			Stack<string> opers = new Stack<string>(parsed.Length);

			string poped;
			foreach (string token in parsed)
			{
				if (double.TryParse(token, out _))
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
					if (opers.Count == 0) break;
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
				if (double.TryParse(token, out double num))
				{
					nums.Push(num);
					continue;
				}

				if (IsFunction(token))
				{
					int argsLen = GetFuncArgsLength(token);
					double[] args = new double[argsLen];
					for (int i = argsLen - 1; i >= 0; i--)
						args[i] = nums.Pop();

					nums.Push(CallFunc(token, args));
					continue;
				}

				double y = nums.Pop(), x = nums.Pop();
				nums.Push(DoOperation(x, y, token));
			}
			return nums.Pop();
		}

		double CallFunc(string funcName, double[] args)
		{
			switch (funcName)
			{
				case "sin":
					return Math.Sin(args[0]);
				case "cos":
					return Math.Cos(args[0]);
				case "tg":
					return Math.Tan(args[0]);
				case "ctg":
					return 1 / Math.Tan(args[0]);
				case "abs":
					return Math.Abs(args[0]);
				case "min":
					return Math.Min(args[0], args[1]);
				case "max":
					return Math.Max(args[0], args[1]);
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
