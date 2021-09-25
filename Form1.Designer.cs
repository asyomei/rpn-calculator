
namespace Calculator
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.Button btn1;
			System.Windows.Forms.Button btn2;
			System.Windows.Forms.Button btn3;
			System.Windows.Forms.Button btn4;
			System.Windows.Forms.Button btn5;
			System.Windows.Forms.Button btn6;
			System.Windows.Forms.Button btn7;
			System.Windows.Forms.Button btn8;
			System.Windows.Forms.Button btn9;
			System.Windows.Forms.Button btn0;
			System.Windows.Forms.Button btnDot;
			System.Windows.Forms.Button btnMod;
			System.Windows.Forms.Button btnLParen;
			System.Windows.Forms.Button btnRParen;
			System.Windows.Forms.Button btnDiv;
			System.Windows.Forms.Button btnMul;
			System.Windows.Forms.Button btnMinus;
			System.Windows.Forms.Button btnPlus;
			System.Windows.Forms.Button btnSqrt;
			System.Windows.Forms.Button btnPow;
			System.Windows.Forms.Button btnSin;
			System.Windows.Forms.Button btnCos;
			System.Windows.Forms.Button btnTan;
			System.Windows.Forms.Button btnCotan;
			System.Windows.Forms.Button btnAbs;
			System.Windows.Forms.Button btnFact;
			System.Windows.Forms.Button btnInt;
			System.Windows.Forms.Button btnRound;
			System.Windows.Forms.Button btnLog;
			System.Windows.Forms.Button btnLn;
			System.Windows.Forms.Button btnClear;
			System.Windows.Forms.Button btnSign;
			System.Windows.Forms.Button btnMin;
			System.Windows.Forms.Button btnMax;
			System.Windows.Forms.Button btnRandom;
			System.Windows.Forms.Button btnDelim;
			System.Windows.Forms.Button btnBack;
			System.Windows.Forms.Button btnSetM;
			System.Windows.Forms.Label memLbl;
			System.Windows.Forms.Button btnMem;
			System.Windows.Forms.Button btnEval;
			this.input = new System.Windows.Forms.TextBox();
			this.output = new System.Windows.Forms.TextBox();
			this.functionPanel = new System.Windows.Forms.Panel();
			this.closeFunctionPanelHelper = new System.Windows.Forms.Label();
			this.memValueLbl = new System.Windows.Forms.Label();
			btn1 = new System.Windows.Forms.Button();
			btn2 = new System.Windows.Forms.Button();
			btn3 = new System.Windows.Forms.Button();
			btn4 = new System.Windows.Forms.Button();
			btn5 = new System.Windows.Forms.Button();
			btn6 = new System.Windows.Forms.Button();
			btn7 = new System.Windows.Forms.Button();
			btn8 = new System.Windows.Forms.Button();
			btn9 = new System.Windows.Forms.Button();
			btn0 = new System.Windows.Forms.Button();
			btnDot = new System.Windows.Forms.Button();
			btnMod = new System.Windows.Forms.Button();
			btnLParen = new System.Windows.Forms.Button();
			btnRParen = new System.Windows.Forms.Button();
			btnDiv = new System.Windows.Forms.Button();
			btnMul = new System.Windows.Forms.Button();
			btnMinus = new System.Windows.Forms.Button();
			btnPlus = new System.Windows.Forms.Button();
			btnSqrt = new System.Windows.Forms.Button();
			btnPow = new System.Windows.Forms.Button();
			btnSin = new System.Windows.Forms.Button();
			btnCos = new System.Windows.Forms.Button();
			btnTan = new System.Windows.Forms.Button();
			btnCotan = new System.Windows.Forms.Button();
			btnAbs = new System.Windows.Forms.Button();
			btnFact = new System.Windows.Forms.Button();
			btnInt = new System.Windows.Forms.Button();
			btnRound = new System.Windows.Forms.Button();
			btnLog = new System.Windows.Forms.Button();
			btnLn = new System.Windows.Forms.Button();
			btnClear = new System.Windows.Forms.Button();
			btnSign = new System.Windows.Forms.Button();
			btnMin = new System.Windows.Forms.Button();
			btnMax = new System.Windows.Forms.Button();
			btnRandom = new System.Windows.Forms.Button();
			btnDelim = new System.Windows.Forms.Button();
			btnBack = new System.Windows.Forms.Button();
			btnSetM = new System.Windows.Forms.Button();
			memLbl = new System.Windows.Forms.Label();
			btnMem = new System.Windows.Forms.Button();
			btnEval = new System.Windows.Forms.Button();
			this.functionPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn1
			// 
			btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btn1.Location = new System.Drawing.Point(12, 234);
			btn1.Name = "btn1";
			btn1.Size = new System.Drawing.Size(35, 35);
			btn1.TabIndex = 2;
			btn1.Text = "1";
			btn1.UseVisualStyleBackColor = true;
			btn1.Click += new System.EventHandler(this.DefaultBtnClick);
			btn1.MouseEnter += new System.EventHandler(this.FunctionPanel_MouseLeave);
			// 
			// btn2
			// 
			btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btn2.Location = new System.Drawing.Point(53, 234);
			btn2.Name = "btn2";
			btn2.Size = new System.Drawing.Size(35, 35);
			btn2.TabIndex = 3;
			btn2.Text = "2";
			btn2.UseVisualStyleBackColor = true;
			btn2.Click += new System.EventHandler(this.DefaultBtnClick);
			// 
			// btn3
			// 
			btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btn3.Location = new System.Drawing.Point(94, 234);
			btn3.Name = "btn3";
			btn3.Size = new System.Drawing.Size(35, 35);
			btn3.TabIndex = 4;
			btn3.Text = "3";
			btn3.UseVisualStyleBackColor = true;
			btn3.Click += new System.EventHandler(this.DefaultBtnClick);
			// 
			// btn4
			// 
			btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btn4.Location = new System.Drawing.Point(12, 275);
			btn4.Name = "btn4";
			btn4.Size = new System.Drawing.Size(35, 35);
			btn4.TabIndex = 5;
			btn4.Text = "4";
			btn4.UseVisualStyleBackColor = true;
			btn4.Click += new System.EventHandler(this.DefaultBtnClick);
			btn4.MouseEnter += new System.EventHandler(this.FunctionPanel_MouseLeave);
			// 
			// btn5
			// 
			btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btn5.Location = new System.Drawing.Point(53, 275);
			btn5.Name = "btn5";
			btn5.Size = new System.Drawing.Size(35, 35);
			btn5.TabIndex = 6;
			btn5.Text = "5";
			btn5.UseVisualStyleBackColor = true;
			btn5.Click += new System.EventHandler(this.DefaultBtnClick);
			// 
			// btn6
			// 
			btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btn6.Location = new System.Drawing.Point(94, 275);
			btn6.Name = "btn6";
			btn6.Size = new System.Drawing.Size(35, 35);
			btn6.TabIndex = 7;
			btn6.Text = "6";
			btn6.UseVisualStyleBackColor = true;
			btn6.Click += new System.EventHandler(this.DefaultBtnClick);
			// 
			// btn7
			// 
			btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btn7.Location = new System.Drawing.Point(12, 316);
			btn7.Name = "btn7";
			btn7.Size = new System.Drawing.Size(35, 35);
			btn7.TabIndex = 8;
			btn7.Text = "7";
			btn7.UseVisualStyleBackColor = true;
			btn7.Click += new System.EventHandler(this.DefaultBtnClick);
			btn7.MouseEnter += new System.EventHandler(this.FunctionPanel_MouseLeave);
			// 
			// btn8
			// 
			btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btn8.Location = new System.Drawing.Point(53, 316);
			btn8.Name = "btn8";
			btn8.Size = new System.Drawing.Size(35, 35);
			btn8.TabIndex = 9;
			btn8.Text = "8";
			btn8.UseVisualStyleBackColor = true;
			btn8.Click += new System.EventHandler(this.DefaultBtnClick);
			// 
			// btn9
			// 
			btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btn9.Location = new System.Drawing.Point(94, 316);
			btn9.Name = "btn9";
			btn9.Size = new System.Drawing.Size(35, 35);
			btn9.TabIndex = 10;
			btn9.Text = "9";
			btn9.UseVisualStyleBackColor = true;
			btn9.Click += new System.EventHandler(this.DefaultBtnClick);
			// 
			// btn0
			// 
			btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btn0.Location = new System.Drawing.Point(12, 357);
			btn0.Name = "btn0";
			btn0.Size = new System.Drawing.Size(35, 35);
			btn0.TabIndex = 11;
			btn0.Text = "0";
			btn0.UseVisualStyleBackColor = true;
			btn0.Click += new System.EventHandler(this.DefaultBtnClick);
			btn0.MouseEnter += new System.EventHandler(this.FunctionPanel_MouseLeave);
			// 
			// btnDot
			// 
			btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnDot.Location = new System.Drawing.Point(53, 357);
			btnDot.Name = "btnDot";
			btnDot.Size = new System.Drawing.Size(35, 35);
			btnDot.TabIndex = 12;
			btnDot.Text = ".";
			btnDot.UseVisualStyleBackColor = true;
			btnDot.Click += new System.EventHandler(this.DefaultBtnClick);
			// 
			// btnMod
			// 
			btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnMod.Location = new System.Drawing.Point(176, 275);
			btnMod.Name = "btnMod";
			btnMod.Size = new System.Drawing.Size(35, 35);
			btnMod.TabIndex = 13;
			btnMod.Tag = "";
			btnMod.Text = ":";
			btnMod.UseVisualStyleBackColor = true;
			btnMod.Click += new System.EventHandler(this.DefaultBtnClick);
			// 
			// btnLParen
			// 
			btnLParen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnLParen.Location = new System.Drawing.Point(12, 193);
			btnLParen.Name = "btnLParen";
			btnLParen.Size = new System.Drawing.Size(35, 35);
			btnLParen.TabIndex = 15;
			btnLParen.Text = "(";
			btnLParen.UseVisualStyleBackColor = true;
			btnLParen.Click += new System.EventHandler(this.DefaultBtnClick);
			btnLParen.MouseEnter += new System.EventHandler(this.FunctionPanel_MouseLeave);
			// 
			// btnRParen
			// 
			btnRParen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnRParen.Location = new System.Drawing.Point(53, 193);
			btnRParen.Name = "btnRParen";
			btnRParen.Size = new System.Drawing.Size(35, 35);
			btnRParen.TabIndex = 16;
			btnRParen.Text = ")";
			btnRParen.UseVisualStyleBackColor = true;
			btnRParen.Click += new System.EventHandler(this.DefaultBtnClick);
			// 
			// btnDiv
			// 
			btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnDiv.Location = new System.Drawing.Point(135, 234);
			btnDiv.Name = "btnDiv";
			btnDiv.Size = new System.Drawing.Size(35, 35);
			btnDiv.TabIndex = 18;
			btnDiv.Text = "/";
			btnDiv.UseVisualStyleBackColor = true;
			btnDiv.Click += new System.EventHandler(this.DefaultBtnClick);
			// 
			// btnMul
			// 
			btnMul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnMul.Location = new System.Drawing.Point(135, 275);
			btnMul.Name = "btnMul";
			btnMul.Size = new System.Drawing.Size(35, 35);
			btnMul.TabIndex = 19;
			btnMul.Text = "*";
			btnMul.UseVisualStyleBackColor = true;
			btnMul.Click += new System.EventHandler(this.DefaultBtnClick);
			// 
			// btnMinus
			// 
			btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnMinus.Location = new System.Drawing.Point(135, 316);
			btnMinus.Name = "btnMinus";
			btnMinus.Size = new System.Drawing.Size(35, 35);
			btnMinus.TabIndex = 20;
			btnMinus.Text = "-";
			btnMinus.UseVisualStyleBackColor = true;
			btnMinus.Click += new System.EventHandler(this.DefaultBtnClick);
			// 
			// btnPlus
			// 
			btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnPlus.Location = new System.Drawing.Point(135, 357);
			btnPlus.Name = "btnPlus";
			btnPlus.Size = new System.Drawing.Size(35, 35);
			btnPlus.TabIndex = 21;
			btnPlus.Text = "+";
			btnPlus.UseVisualStyleBackColor = true;
			btnPlus.Click += new System.EventHandler(this.DefaultBtnClick);
			// 
			// btnSqrt
			// 
			btnSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnSqrt.Location = new System.Drawing.Point(94, 193);
			btnSqrt.Name = "btnSqrt";
			btnSqrt.Size = new System.Drawing.Size(35, 35);
			btnSqrt.TabIndex = 22;
			btnSqrt.Tag = "";
			btnSqrt.Text = "√";
			btnSqrt.UseVisualStyleBackColor = true;
			btnSqrt.Click += new System.EventHandler(this.DefaultBtnClick);
			// 
			// btnPow
			// 
			btnPow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnPow.Location = new System.Drawing.Point(135, 193);
			btnPow.Name = "btnPow";
			btnPow.Size = new System.Drawing.Size(35, 35);
			btnPow.TabIndex = 23;
			btnPow.Text = "^";
			btnPow.UseVisualStyleBackColor = true;
			btnPow.Click += new System.EventHandler(this.DefaultBtnClick);
			// 
			// btnSin
			// 
			btnSin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnSin.Location = new System.Drawing.Point(16, 15);
			btnSin.Name = "btnSin";
			btnSin.Size = new System.Drawing.Size(45, 35);
			btnSin.TabIndex = 25;
			btnSin.Text = "sin";
			btnSin.UseVisualStyleBackColor = true;
			btnSin.Click += new System.EventHandler(this.FunctionBtnClick);
			// 
			// btnCos
			// 
			btnCos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnCos.Location = new System.Drawing.Point(67, 15);
			btnCos.Name = "btnCos";
			btnCos.Size = new System.Drawing.Size(45, 35);
			btnCos.TabIndex = 26;
			btnCos.Text = "cos";
			btnCos.UseVisualStyleBackColor = true;
			btnCos.Click += new System.EventHandler(this.FunctionBtnClick);
			// 
			// btnTan
			// 
			btnTan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnTan.Location = new System.Drawing.Point(16, 56);
			btnTan.Name = "btnTan";
			btnTan.Size = new System.Drawing.Size(45, 35);
			btnTan.TabIndex = 27;
			btnTan.Text = "tg";
			btnTan.UseVisualStyleBackColor = true;
			btnTan.Click += new System.EventHandler(this.FunctionBtnClick);
			// 
			// btnCotan
			// 
			btnCotan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnCotan.Location = new System.Drawing.Point(67, 56);
			btnCotan.Name = "btnCotan";
			btnCotan.Size = new System.Drawing.Size(45, 35);
			btnCotan.TabIndex = 28;
			btnCotan.Text = "ctg";
			btnCotan.UseVisualStyleBackColor = true;
			btnCotan.Click += new System.EventHandler(this.FunctionBtnClick);
			// 
			// btnAbs
			// 
			btnAbs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnAbs.Location = new System.Drawing.Point(16, 138);
			btnAbs.Name = "btnAbs";
			btnAbs.Size = new System.Drawing.Size(45, 35);
			btnAbs.TabIndex = 29;
			btnAbs.Text = "abs";
			btnAbs.UseVisualStyleBackColor = true;
			btnAbs.Click += new System.EventHandler(this.FunctionBtnClick);
			// 
			// btnFact
			// 
			btnFact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnFact.Location = new System.Drawing.Point(67, 138);
			btnFact.Name = "btnFact";
			btnFact.Size = new System.Drawing.Size(45, 35);
			btnFact.TabIndex = 30;
			btnFact.Text = "fact";
			btnFact.UseVisualStyleBackColor = true;
			btnFact.Click += new System.EventHandler(this.FunctionBtnClick);
			// 
			// btnInt
			// 
			btnInt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnInt.Location = new System.Drawing.Point(16, 179);
			btnInt.Name = "btnInt";
			btnInt.Size = new System.Drawing.Size(45, 35);
			btnInt.TabIndex = 31;
			btnInt.Text = "int";
			btnInt.UseVisualStyleBackColor = true;
			btnInt.Click += new System.EventHandler(this.FunctionBtnClick);
			// 
			// btnRound
			// 
			btnRound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnRound.Location = new System.Drawing.Point(67, 179);
			btnRound.Name = "btnRound";
			btnRound.Size = new System.Drawing.Size(45, 35);
			btnRound.TabIndex = 32;
			btnRound.Text = "rnd";
			btnRound.UseVisualStyleBackColor = true;
			btnRound.Click += new System.EventHandler(this.FunctionBtnClick);
			// 
			// btnLog
			// 
			btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnLog.Location = new System.Drawing.Point(16, 97);
			btnLog.Name = "btnLog";
			btnLog.Size = new System.Drawing.Size(45, 35);
			btnLog.TabIndex = 33;
			btnLog.Text = "log";
			btnLog.UseVisualStyleBackColor = true;
			btnLog.Click += new System.EventHandler(this.FunctionBtnClick);
			// 
			// btnLn
			// 
			btnLn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnLn.Location = new System.Drawing.Point(67, 97);
			btnLn.Name = "btnLn";
			btnLn.Size = new System.Drawing.Size(45, 35);
			btnLn.TabIndex = 34;
			btnLn.Text = "ln";
			btnLn.UseVisualStyleBackColor = true;
			btnLn.Click += new System.EventHandler(this.FunctionBtnClick);
			// 
			// btnClear
			// 
			btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnClear.Location = new System.Drawing.Point(176, 193);
			btnClear.Name = "btnClear";
			btnClear.Size = new System.Drawing.Size(35, 35);
			btnClear.TabIndex = 35;
			btnClear.Text = "C";
			btnClear.UseVisualStyleBackColor = true;
			btnClear.Click += new System.EventHandler(this.ClearBtnClick);
			// 
			// btnSign
			// 
			btnSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnSign.Location = new System.Drawing.Point(118, 15);
			btnSign.Name = "btnSign";
			btnSign.Size = new System.Drawing.Size(50, 35);
			btnSign.TabIndex = 36;
			btnSign.Text = "sign";
			btnSign.UseVisualStyleBackColor = true;
			btnSign.Click += new System.EventHandler(this.FunctionBtnClick);
			// 
			// btnMin
			// 
			btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnMin.Location = new System.Drawing.Point(118, 56);
			btnMin.Name = "btnMin";
			btnMin.Size = new System.Drawing.Size(50, 35);
			btnMin.TabIndex = 37;
			btnMin.Text = "min";
			btnMin.UseVisualStyleBackColor = true;
			btnMin.Click += new System.EventHandler(this.FunctionBtnClick);
			// 
			// btnMax
			// 
			btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnMax.Location = new System.Drawing.Point(118, 97);
			btnMax.Name = "btnMax";
			btnMax.Size = new System.Drawing.Size(50, 35);
			btnMax.TabIndex = 38;
			btnMax.Text = "max";
			btnMax.UseVisualStyleBackColor = true;
			btnMax.Click += new System.EventHandler(this.FunctionBtnClick);
			// 
			// btnRandom
			// 
			btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnRandom.Location = new System.Drawing.Point(118, 138);
			btnRandom.Name = "btnRandom";
			btnRandom.Size = new System.Drawing.Size(50, 35);
			btnRandom.TabIndex = 39;
			btnRandom.Text = "rand";
			btnRandom.UseVisualStyleBackColor = true;
			btnRandom.Click += new System.EventHandler(this.FunctionBtnClick);
			// 
			// btnDelim
			// 
			btnDelim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnDelim.Location = new System.Drawing.Point(94, 357);
			btnDelim.Name = "btnDelim";
			btnDelim.Size = new System.Drawing.Size(35, 35);
			btnDelim.TabIndex = 40;
			btnDelim.Text = ",";
			btnDelim.UseVisualStyleBackColor = true;
			btnDelim.Click += new System.EventHandler(this.DefaultBtnClick);
			// 
			// btnBack
			// 
			btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnBack.Location = new System.Drawing.Point(176, 234);
			btnBack.Name = "btnBack";
			btnBack.Size = new System.Drawing.Size(35, 35);
			btnBack.TabIndex = 41;
			btnBack.Text = "<";
			btnBack.UseVisualStyleBackColor = true;
			btnBack.Click += new System.EventHandler(this.BackBtnClick);
			// 
			// btnSetM
			// 
			btnSetM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnSetM.Location = new System.Drawing.Point(118, 179);
			btnSetM.Name = "btnSetM";
			btnSetM.Size = new System.Drawing.Size(50, 35);
			btnSetM.TabIndex = 40;
			btnSetM.Text = "M=";
			btnSetM.UseVisualStyleBackColor = true;
			btnSetM.Click += new System.EventHandler(this.MemoryBtnClicked);
			// 
			// memLbl
			// 
			memLbl.AutoSize = true;
			memLbl.Location = new System.Drawing.Point(12, 22);
			memLbl.Name = "memLbl";
			memLbl.Size = new System.Drawing.Size(34, 18);
			memLbl.TabIndex = 44;
			memLbl.Text = "M =";
			// 
			// input
			// 
			this.input.BackColor = System.Drawing.Color.White;
			this.input.Location = new System.Drawing.Point(12, 43);
			this.input.Multiline = true;
			this.input.Name = "input";
			this.input.Size = new System.Drawing.Size(206, 95);
			this.input.TabIndex = 0;
			this.input.TextChanged += new System.EventHandler(this.Input_TextChanged);
			this.input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress);
			// 
			// output
			// 
			this.output.Location = new System.Drawing.Point(12, 144);
			this.output.Name = "output";
			this.output.ReadOnly = true;
			this.output.Size = new System.Drawing.Size(206, 26);
			this.output.TabIndex = 1;
			this.output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// functionPanel
			// 
			this.functionPanel.BackColor = System.Drawing.SystemColors.Control;
			this.functionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.functionPanel.Controls.Add(btnSetM);
			this.functionPanel.Controls.Add(btnSin);
			this.functionPanel.Controls.Add(btnCos);
			this.functionPanel.Controls.Add(btnSign);
			this.functionPanel.Controls.Add(btnRandom);
			this.functionPanel.Controls.Add(btnTan);
			this.functionPanel.Controls.Add(btnMax);
			this.functionPanel.Controls.Add(btnLog);
			this.functionPanel.Controls.Add(btnMin);
			this.functionPanel.Controls.Add(btnCotan);
			this.functionPanel.Controls.Add(btnAbs);
			this.functionPanel.Controls.Add(btnLn);
			this.functionPanel.Controls.Add(btnFact);
			this.functionPanel.Controls.Add(btnInt);
			this.functionPanel.Controls.Add(btnRound);
			this.functionPanel.Location = new System.Drawing.Point(217, 176);
			this.functionPanel.Name = "functionPanel";
			this.functionPanel.Size = new System.Drawing.Size(189, 235);
			this.functionPanel.TabIndex = 42;
			this.functionPanel.MouseEnter += new System.EventHandler(this.FunctionPanel_MouseEnter);
			// 
			// closeFunctionPanelHelper
			// 
			this.closeFunctionPanelHelper.Location = new System.Drawing.Point(-2, 173);
			this.closeFunctionPanelHelper.Name = "closeFunctionPanelHelper";
			this.closeFunctionPanelHelper.Size = new System.Drawing.Size(49, 238);
			this.closeFunctionPanelHelper.TabIndex = 43;
			this.closeFunctionPanelHelper.MouseEnter += new System.EventHandler(this.FunctionPanel_MouseLeave);
			// 
			// memValueLbl
			// 
			this.memValueLbl.AutoSize = true;
			this.memValueLbl.Location = new System.Drawing.Point(45, 22);
			this.memValueLbl.Name = "memValueLbl";
			this.memValueLbl.Size = new System.Drawing.Size(17, 18);
			this.memValueLbl.TabIndex = 45;
			this.memValueLbl.Text = "0";
			// 
			// btnMem
			// 
			btnMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnMem.Location = new System.Drawing.Point(176, 316);
			btnMem.Name = "btnMem";
			btnMem.Size = new System.Drawing.Size(35, 35);
			btnMem.TabIndex = 46;
			btnMem.Tag = "";
			btnMem.Text = "M";
			btnMem.UseVisualStyleBackColor = true;
			btnMem.Click += new System.EventHandler(this.DefaultBtnClick);
			// 
			// btnEval
			// 
			btnEval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnEval.Location = new System.Drawing.Point(176, 357);
			btnEval.Name = "btnEval";
			btnEval.Size = new System.Drawing.Size(35, 35);
			btnEval.TabIndex = 47;
			btnEval.Tag = "";
			btnEval.Text = "=";
			btnEval.UseVisualStyleBackColor = true;
			btnEval.Click += new System.EventHandler(this.Input_TextChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(232, 404);
			this.Controls.Add(this.memValueLbl);
			this.Controls.Add(memLbl);
			this.Controls.Add(this.functionPanel);
			this.Controls.Add(btnBack);
			this.Controls.Add(btnMem);
			this.Controls.Add(btnEval);
			this.Controls.Add(btnDelim);
			this.Controls.Add(btnClear);
			this.Controls.Add(btnPow);
			this.Controls.Add(btnSqrt);
			this.Controls.Add(btnPlus);
			this.Controls.Add(btnMinus);
			this.Controls.Add(btnMul);
			this.Controls.Add(btnDiv);
			this.Controls.Add(btnRParen);
			this.Controls.Add(btnLParen);
			this.Controls.Add(btnMod);
			this.Controls.Add(btnDot);
			this.Controls.Add(btn0);
			this.Controls.Add(btn9);
			this.Controls.Add(btn8);
			this.Controls.Add(btn7);
			this.Controls.Add(btn6);
			this.Controls.Add(btn5);
			this.Controls.Add(btn4);
			this.Controls.Add(btn3);
			this.Controls.Add(btn2);
			this.Controls.Add(btn1);
			this.Controls.Add(this.output);
			this.Controls.Add(this.input);
			this.Controls.Add(this.closeFunctionPanelHelper);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Калькулятор";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.functionPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox input;
		private System.Windows.Forms.TextBox output;
		private System.Windows.Forms.Panel functionPanel;
		private System.Windows.Forms.Label closeFunctionPanelHelper;
		private System.Windows.Forms.Label memValueLbl;
	}
}

