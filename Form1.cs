using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		void Form1_Load(object sender, EventArgs e)
		{

		}

		void Form1_KeyPress(object sender, KeyPressEventArgs e)
		{
		//	input.Text += e.KeyChar;
		}

		void DefaultBtnClick(object sender, EventArgs e)
		{
			int selectStart = input.SelectionStart;
			input.Focus();
			string text = ((Button)sender).Text;
			input.Text = input.Text.Insert(selectStart, text);
			input.SelectionStart = selectStart + text.Length;
			input.SelectionLength = 0;
		}

		void FunctionBtnClick(object sender, EventArgs e)
		{
			DefaultBtnClick(sender, null);
			int selectStart = input.SelectionStart;
			input.Focus();
			input.Text = input.Text.Insert(selectStart, "(");
			input.SelectionStart = selectStart + 1;
			input.SelectionLength = 0;
		}

		Calculator calc = new Calculator();
		void Input_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool IsMathSym(char c)
			{
				const string MATH_SYMS = ".,+-*/^√%()";
				return char.IsLetterOrDigit(c) || MATH_SYMS.Contains(c);
			}

			if (e.KeyChar == (char)Keys.Enter)
			{
				Input_TextChanged(null, null);
				e.Handled = true;
				return;
			}

			if (IsMathSym(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
				return;

			e.Handled = true;
		}

		void Input_TextChanged(object sender, EventArgs e)
		{
			double result;
			try
			{
				result = calc.Evaluate(input.Text);
			}
			catch (Exception ex) when (ex is IndexOutOfRangeException || ex is InvalidOperationException || ex is NotImplementedException)
			{
				output.Text = "";
				return;
			}
			catch (DivideByZeroException)
			{
				output.Text = "Деление на 0";
				return;
			}
			output.Text = result.ToString();
		}
	}
}
