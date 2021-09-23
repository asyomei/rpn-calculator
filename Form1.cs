using System;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
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
			input.Text = input.Text.Insert(selectStart, text + (text == "(" ? ")" : ""));
			input.SelectionStart = selectStart + text.Length;
			input.SelectionLength = 0;
		}

		void FunctionBtnClick(object sender, EventArgs e)
		{
			int selectStart = input.SelectionStart;
			input.Focus();
			string text = ((Button)sender).Text + "()";
			input.Text = input.Text.Insert(selectStart, text);
			input.SelectionStart = selectStart + text.Length - 1;
			input.SelectionLength = 0;
			FunctionPanel_MouseLeave(null, null);
		}

		void ClearBtnClick(object sender, EventArgs e)
		{
			input.Text = "";
			input.Focus();
		}

		void BackBtnClick(object sender, EventArgs e)
		{
			int selectStart = input.SelectionStart;
			input.Focus();
			if (selectStart == 0)
				return;

			selectStart--;
			input.Text = input.Text.Remove(selectStart, 1);
			input.SelectionStart = selectStart;
			input.SelectionLength = 0;
		}

		Calculator calc = new Calculator();
		void Input_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool IsMathSym(char c)
			{
				const string MATH_SYMS = ".,+-*/^√!%()";
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

		bool panelIsMoving;
		async void FunctionPanel_MouseEnter(object sender, EventArgs e)
		{
			if (panelIsMoving)
				return;

			Point location;
			panelIsMoving = true;
			while (functionPanel.Location.X > 53)
			{
				location = functionPanel.Location;
				location.Offset(functionPanel.Location.X / -20, 0);
				functionPanel.Location = location;
				await Task.Delay(10);
			}
			panelIsMoving = false;
		}
		async void FunctionPanel_MouseLeave(object sender, EventArgs e)
		{
			if (panelIsMoving)
				return;

			Point location;
			panelIsMoving = true;
			while (functionPanel.Location.X < 217)
			{
				location = functionPanel.Location;
				location.Offset(functionPanel.Location.X / 20, 0);
				functionPanel.Location = location;
				await Task.Delay(10);
			}
			functionPanel.Location = new Point(217, functionPanel.Location.Y);
			panelIsMoving = false;
		}
	}
}
