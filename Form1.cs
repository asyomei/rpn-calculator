using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

		StringBuilder exprBuilder = new StringBuilder();
		Calculator calc = new Calculator();
		void Form1_Load(object sender, EventArgs e)
		{
			foreach (var btn in Controls.OfType<Button>())
			{
				switch (btn.Text)
				{
					case "=":
						btn.Click += (s, a) => resTextBox.Text = calc.Evaluate(exprTextBox.Text).ToString();
						continue;
					case "B":
						btn.Click += (s, a) => { if (exprBuilder.Length != 0) exprBuilder.Length--; };
						break;
					case "C":
						btn.Click += (s, a) => exprBuilder.Clear();
						break;
					default:
						btn.Click += (s, a) => exprBuilder.Append(btn.Text);
						break;
				}
				btn.Click += (s, a) => exprTextBox.Text = exprBuilder.ToString();
			}
		}

		string delims = "+-*/^().,";
		void exprTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (int) Keys.Enter)
			{
				resTextBox.Text = calc.Evaluate(exprTextBox.Text).ToString();
				e.KeyChar = '\0';
				e.Handled = true;
				return;
			}

			if (e.KeyChar == (int) Keys.Back)
			{
				if (exprBuilder.Length != 0)
					exprBuilder.Length--;
				return;
			}

			if (char.IsLetterOrDigit(e.KeyChar) || delims.Contains(e.KeyChar))
			{
				exprBuilder.Append(e.KeyChar);
				return;
			}

			e.KeyChar = '\0';
			e.Handled = true;
		}
	}
}
