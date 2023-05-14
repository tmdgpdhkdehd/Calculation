namespace Calculation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            display = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            ButtonAdd = new Button();
            ButtonDot = new Button();
            ButtonZero = new Button();
            ButtonAC = new Button();
            ButtonSub = new Button();
            ButtonThree = new Button();
            ButtonTwo = new Button();
            ButtonOne = new Button();
            ButtonMultiply = new Button();
            ButtonSix = new Button();
            ButtonFive = new Button();
            ButtonFour = new Button();
            ButtonDivide = new Button();
            ButtonNine = new Button();
            ButtonEight = new Button();
            ButtonSeven = new Button();
            ButtonResult = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // display
            // 
            display.Dock = DockStyle.Top;
            display.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            display.Location = new Point(0, 0);
            display.Name = "display";
            display.Size = new Size(323, 42);
            display.TabIndex = 0;
            display.Text = "0";
            display.TextAlign = ContentAlignment.TopRight;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(ButtonAdd, 3, 3);
            tableLayoutPanel1.Controls.Add(ButtonDot, 2, 3);
            tableLayoutPanel1.Controls.Add(ButtonZero, 1, 3);
            tableLayoutPanel1.Controls.Add(ButtonAC, 0, 3);
            tableLayoutPanel1.Controls.Add(ButtonSub, 3, 2);
            tableLayoutPanel1.Controls.Add(ButtonThree, 2, 2);
            tableLayoutPanel1.Controls.Add(ButtonTwo, 1, 2);
            tableLayoutPanel1.Controls.Add(ButtonOne, 0, 2);
            tableLayoutPanel1.Controls.Add(ButtonMultiply, 3, 1);
            tableLayoutPanel1.Controls.Add(ButtonSix, 2, 1);
            tableLayoutPanel1.Controls.Add(ButtonFive, 1, 1);
            tableLayoutPanel1.Controls.Add(ButtonFour, 0, 1);
            tableLayoutPanel1.Controls.Add(ButtonDivide, 3, 0);
            tableLayoutPanel1.Controls.Add(ButtonNine, 2, 0);
            tableLayoutPanel1.Controls.Add(ButtonEight, 1, 0);
            tableLayoutPanel1.Controls.Add(ButtonSeven, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 45);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(323, 332);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonAdd.Location = new Point(243, 252);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(74, 77);
            ButtonAdd.TabIndex = 15;
            ButtonAdd.Text = "＋";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // ButtonDot
            // 
            ButtonDot.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonDot.Location = new Point(163, 252);
            ButtonDot.Name = "ButtonDot";
            ButtonDot.Size = new Size(74, 77);
            ButtonDot.TabIndex = 14;
            ButtonDot.Text = ".";
            ButtonDot.UseVisualStyleBackColor = true;
            ButtonDot.Click += ButtonDot_Click;
            // 
            // ButtonZero
            // 
            ButtonZero.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonZero.Location = new Point(83, 252);
            ButtonZero.Name = "ButtonZero";
            ButtonZero.Size = new Size(74, 77);
            ButtonZero.TabIndex = 13;
            ButtonZero.Text = "0";
            ButtonZero.UseVisualStyleBackColor = true;
            ButtonZero.Click += ButtonZero_Click;
            // 
            // ButtonAC
            // 
            ButtonAC.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonAC.Location = new Point(3, 252);
            ButtonAC.Name = "ButtonAC";
            ButtonAC.Size = new Size(74, 77);
            ButtonAC.TabIndex = 12;
            ButtonAC.Text = "AC";
            ButtonAC.UseVisualStyleBackColor = true;
            ButtonAC.Click += ButtonAC_Click;
            // 
            // ButtonSub
            // 
            ButtonSub.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSub.Location = new Point(243, 169);
            ButtonSub.Name = "ButtonSub";
            ButtonSub.Size = new Size(74, 77);
            ButtonSub.TabIndex = 11;
            ButtonSub.Text = "－";
            ButtonSub.UseVisualStyleBackColor = true;
            ButtonSub.Click += ButtonSub_Click;
            // 
            // ButtonThree
            // 
            ButtonThree.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonThree.Location = new Point(163, 169);
            ButtonThree.Name = "ButtonThree";
            ButtonThree.Size = new Size(74, 77);
            ButtonThree.TabIndex = 10;
            ButtonThree.Text = "3";
            ButtonThree.UseVisualStyleBackColor = true;
            ButtonThree.Click += ButtonThree_Click;
            // 
            // ButtonTwo
            // 
            ButtonTwo.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonTwo.Location = new Point(83, 169);
            ButtonTwo.Name = "ButtonTwo";
            ButtonTwo.Size = new Size(74, 77);
            ButtonTwo.TabIndex = 9;
            ButtonTwo.Text = "2";
            ButtonTwo.UseVisualStyleBackColor = true;
            ButtonTwo.Click += ButtonTwo_Click;
            // 
            // ButtonOne
            // 
            ButtonOne.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonOne.Location = new Point(3, 169);
            ButtonOne.Name = "ButtonOne";
            ButtonOne.Size = new Size(74, 77);
            ButtonOne.TabIndex = 8;
            ButtonOne.Text = "1";
            ButtonOne.UseVisualStyleBackColor = true;
            ButtonOne.Click += ButtonOne_Click;
            // 
            // ButtonMultiply
            // 
            ButtonMultiply.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonMultiply.Location = new Point(243, 86);
            ButtonMultiply.Name = "ButtonMultiply";
            ButtonMultiply.Size = new Size(74, 77);
            ButtonMultiply.TabIndex = 7;
            ButtonMultiply.Text = "×";
            ButtonMultiply.UseVisualStyleBackColor = true;
            ButtonMultiply.Click += ButtonMultiply_Click;
            // 
            // ButtonSix
            // 
            ButtonSix.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSix.Location = new Point(163, 86);
            ButtonSix.Name = "ButtonSix";
            ButtonSix.Size = new Size(74, 77);
            ButtonSix.TabIndex = 6;
            ButtonSix.Text = "6";
            ButtonSix.UseVisualStyleBackColor = true;
            ButtonSix.Click += ButtonSix_Click;
            // 
            // ButtonFive
            // 
            ButtonFive.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonFive.Location = new Point(83, 86);
            ButtonFive.Name = "ButtonFive";
            ButtonFive.Size = new Size(74, 77);
            ButtonFive.TabIndex = 5;
            ButtonFive.Text = "5";
            ButtonFive.UseVisualStyleBackColor = true;
            ButtonFive.Click += ButtonFive_Click;
            // 
            // ButtonFour
            // 
            ButtonFour.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonFour.Location = new Point(3, 86);
            ButtonFour.Name = "ButtonFour";
            ButtonFour.Size = new Size(74, 77);
            ButtonFour.TabIndex = 4;
            ButtonFour.Text = "4";
            ButtonFour.UseVisualStyleBackColor = true;
            ButtonFour.Click += ButtonFour_Click;
            // 
            // ButtonDivide
            // 
            ButtonDivide.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonDivide.Location = new Point(243, 3);
            ButtonDivide.Name = "ButtonDivide";
            ButtonDivide.Size = new Size(74, 77);
            ButtonDivide.TabIndex = 3;
            ButtonDivide.Text = "÷";
            ButtonDivide.UseVisualStyleBackColor = true;
            ButtonDivide.Click += ButtonDivide_Click;
            // 
            // ButtonNine
            // 
            ButtonNine.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonNine.Location = new Point(163, 3);
            ButtonNine.Name = "ButtonNine";
            ButtonNine.Size = new Size(74, 77);
            ButtonNine.TabIndex = 2;
            ButtonNine.Text = "9";
            ButtonNine.UseVisualStyleBackColor = true;
            ButtonNine.Click += ButtonNine_Click;
            // 
            // ButtonEight
            // 
            ButtonEight.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonEight.Location = new Point(83, 3);
            ButtonEight.Name = "ButtonEight";
            ButtonEight.Size = new Size(74, 77);
            ButtonEight.TabIndex = 1;
            ButtonEight.Text = "8";
            ButtonEight.UseVisualStyleBackColor = true;
            ButtonEight.Click += ButtonEight_Click;
            // 
            // ButtonSeven
            // 
            ButtonSeven.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSeven.Location = new Point(3, 3);
            ButtonSeven.Name = "ButtonSeven";
            ButtonSeven.Size = new Size(74, 77);
            ButtonSeven.TabIndex = 0;
            ButtonSeven.Text = "7";
            ButtonSeven.UseVisualStyleBackColor = true;
            ButtonSeven.Click += ButtonSeven_Click;
            // 
            // ButtonResult
            // 
            ButtonResult.AutoSize = true;
            ButtonResult.Dock = DockStyle.Bottom;
            ButtonResult.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonResult.Location = new Point(0, 383);
            ButtonResult.Name = "ButtonResult";
            ButtonResult.Size = new Size(323, 61);
            ButtonResult.TabIndex = 2;
            ButtonResult.Text = "=";
            ButtonResult.UseVisualStyleBackColor = true;
            ButtonResult.Click += ButtonResult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 444);
            Controls.Add(ButtonResult);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(display);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label display;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button15;
        private Button ButtonDot;
        private Button ButtonZero;
        private Button ButtonAC;
        private Button ButtonSub;
        private Button ButtonThree;
        private Button ButtonTwo;
        private Button ButtonOne;
        private Button ButtonMultiply;
        private Button ButtonSix;
        private Button ButtonFive;
        private Button ButtonFour;
        private Button ButtonDivide;
        private Button ButtonNine;
        private Button ButtonEight;
        private Button ButtonSeven;
        private Button ButtonResult;
        private Button ButtonAdd;
    }
}