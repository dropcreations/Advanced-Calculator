namespace Calculator
{
    partial class CalculatorUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorUI));
            this.MainDisplay = new System.Windows.Forms.TextBox();
            this.ButtonDivide = new System.Windows.Forms.Button();
            this.ButtonSquareRoot = new System.Windows.Forms.Button();
            this.ButtonSquare = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonMultiply = new System.Windows.Forms.Button();
            this.ButtonNine = new System.Windows.Forms.Button();
            this.ButtonEight = new System.Windows.Forms.Button();
            this.ButtonSeven = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.ButtonSix = new System.Windows.Forms.Button();
            this.ButtonFive = new System.Windows.Forms.Button();
            this.ButtonFour = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.ButtonThree = new System.Windows.Forms.Button();
            this.ButtonTwo = new System.Windows.Forms.Button();
            this.ButtonOne = new System.Windows.Forms.Button();
            this.ButtonEqual = new System.Windows.Forms.Button();
            this.ButtonDot = new System.Windows.Forms.Button();
            this.ButtonZero = new System.Windows.Forms.Button();
            this.FormulaDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MainDisplay
            // 
            this.MainDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.MainDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainDisplay.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MainDisplay.Font = new System.Drawing.Font("SF Pro Display", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainDisplay.Location = new System.Drawing.Point(7, 57);
            this.MainDisplay.Name = "MainDisplay";
            this.MainDisplay.ReadOnly = true;
            this.MainDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MainDisplay.Size = new System.Drawing.Size(291, 58);
            this.MainDisplay.TabIndex = 19;
            this.MainDisplay.TabStop = false;
            this.MainDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MainDisplay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainDisplay_MouseDown);
            // 
            // ButtonDivide
            // 
            this.ButtonDivide.BackColor = System.Drawing.Color.Lavender;
            this.ButtonDivide.BackgroundImage = global::Calculator.Properties.Resources.divide;
            this.ButtonDivide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonDivide.FlatAppearance.BorderSize = 0;
            this.ButtonDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDivide.Location = new System.Drawing.Point(229, 134);
            this.ButtonDivide.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonDivide.Name = "ButtonDivide";
            this.ButtonDivide.Size = new System.Drawing.Size(74, 61);
            this.ButtonDivide.TabIndex = 18;
            this.ButtonDivide.TabStop = false;
            this.ButtonDivide.UseVisualStyleBackColor = false;
            this.ButtonDivide.Click += new System.EventHandler(this.ButtonDivide_Click);
            // 
            // ButtonSquareRoot
            // 
            this.ButtonSquareRoot.BackColor = System.Drawing.Color.Lavender;
            this.ButtonSquareRoot.BackgroundImage = global::Calculator.Properties.Resources.square_root;
            this.ButtonSquareRoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonSquareRoot.FlatAppearance.BorderSize = 0;
            this.ButtonSquareRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSquareRoot.Location = new System.Drawing.Point(153, 134);
            this.ButtonSquareRoot.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonSquareRoot.Name = "ButtonSquareRoot";
            this.ButtonSquareRoot.Size = new System.Drawing.Size(74, 61);
            this.ButtonSquareRoot.TabIndex = 17;
            this.ButtonSquareRoot.TabStop = false;
            this.ButtonSquareRoot.UseVisualStyleBackColor = false;
            this.ButtonSquareRoot.Click += new System.EventHandler(this.ButtonSquareRoot_Click);
            // 
            // ButtonSquare
            // 
            this.ButtonSquare.BackColor = System.Drawing.Color.Lavender;
            this.ButtonSquare.BackgroundImage = global::Calculator.Properties.Resources.square;
            this.ButtonSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonSquare.FlatAppearance.BorderSize = 0;
            this.ButtonSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSquare.Location = new System.Drawing.Point(77, 134);
            this.ButtonSquare.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonSquare.Name = "ButtonSquare";
            this.ButtonSquare.Size = new System.Drawing.Size(74, 61);
            this.ButtonSquare.TabIndex = 16;
            this.ButtonSquare.TabStop = false;
            this.ButtonSquare.UseVisualStyleBackColor = false;
            this.ButtonSquare.Click += new System.EventHandler(this.ButtonSquare_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.Color.Lavender;
            this.ButtonCancel.BackgroundImage = global::Calculator.Properties.Resources.cancel;
            this.ButtonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonCancel.FlatAppearance.BorderSize = 0;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Location = new System.Drawing.Point(1, 134);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(74, 61);
            this.ButtonCancel.TabIndex = 15;
            this.ButtonCancel.TabStop = false;
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonMultiply
            // 
            this.ButtonMultiply.BackColor = System.Drawing.Color.Lavender;
            this.ButtonMultiply.BackgroundImage = global::Calculator.Properties.Resources.multiply;
            this.ButtonMultiply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonMultiply.FlatAppearance.BorderSize = 0;
            this.ButtonMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMultiply.Location = new System.Drawing.Point(229, 197);
            this.ButtonMultiply.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonMultiply.Name = "ButtonMultiply";
            this.ButtonMultiply.Size = new System.Drawing.Size(74, 61);
            this.ButtonMultiply.TabIndex = 14;
            this.ButtonMultiply.TabStop = false;
            this.ButtonMultiply.UseVisualStyleBackColor = false;
            this.ButtonMultiply.Click += new System.EventHandler(this.ButtonMultiply_Click);
            // 
            // ButtonNine
            // 
            this.ButtonNine.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonNine.BackgroundImage = global::Calculator.Properties.Resources._9;
            this.ButtonNine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonNine.FlatAppearance.BorderSize = 0;
            this.ButtonNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNine.Location = new System.Drawing.Point(153, 197);
            this.ButtonNine.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonNine.Name = "ButtonNine";
            this.ButtonNine.Size = new System.Drawing.Size(74, 61);
            this.ButtonNine.TabIndex = 13;
            this.ButtonNine.TabStop = false;
            this.ButtonNine.UseVisualStyleBackColor = false;
            this.ButtonNine.Click += new System.EventHandler(this.ButtonNine_Click);
            // 
            // ButtonEight
            // 
            this.ButtonEight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonEight.BackgroundImage = global::Calculator.Properties.Resources._8;
            this.ButtonEight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonEight.FlatAppearance.BorderSize = 0;
            this.ButtonEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEight.Location = new System.Drawing.Point(77, 197);
            this.ButtonEight.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonEight.Name = "ButtonEight";
            this.ButtonEight.Size = new System.Drawing.Size(74, 61);
            this.ButtonEight.TabIndex = 12;
            this.ButtonEight.TabStop = false;
            this.ButtonEight.UseVisualStyleBackColor = false;
            this.ButtonEight.Click += new System.EventHandler(this.ButtonEight_Click);
            // 
            // ButtonSeven
            // 
            this.ButtonSeven.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonSeven.BackgroundImage = global::Calculator.Properties.Resources._7;
            this.ButtonSeven.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonSeven.FlatAppearance.BorderSize = 0;
            this.ButtonSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSeven.Location = new System.Drawing.Point(1, 197);
            this.ButtonSeven.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonSeven.Name = "ButtonSeven";
            this.ButtonSeven.Size = new System.Drawing.Size(74, 61);
            this.ButtonSeven.TabIndex = 11;
            this.ButtonSeven.TabStop = false;
            this.ButtonSeven.UseVisualStyleBackColor = false;
            this.ButtonSeven.Click += new System.EventHandler(this.ButtonSeven_Click);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.BackColor = System.Drawing.Color.Lavender;
            this.ButtonMinus.BackgroundImage = global::Calculator.Properties.Resources.minus;
            this.ButtonMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonMinus.FlatAppearance.BorderSize = 0;
            this.ButtonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMinus.Location = new System.Drawing.Point(229, 260);
            this.ButtonMinus.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(74, 61);
            this.ButtonMinus.TabIndex = 10;
            this.ButtonMinus.TabStop = false;
            this.ButtonMinus.UseVisualStyleBackColor = false;
            this.ButtonMinus.Click += new System.EventHandler(this.ButtonMinus_Click);
            // 
            // ButtonSix
            // 
            this.ButtonSix.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonSix.BackgroundImage = global::Calculator.Properties.Resources._6;
            this.ButtonSix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonSix.FlatAppearance.BorderSize = 0;
            this.ButtonSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSix.Location = new System.Drawing.Point(153, 260);
            this.ButtonSix.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonSix.Name = "ButtonSix";
            this.ButtonSix.Size = new System.Drawing.Size(74, 61);
            this.ButtonSix.TabIndex = 9;
            this.ButtonSix.TabStop = false;
            this.ButtonSix.UseVisualStyleBackColor = false;
            this.ButtonSix.Click += new System.EventHandler(this.ButtonSix_Click);
            // 
            // ButtonFive
            // 
            this.ButtonFive.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonFive.BackgroundImage = global::Calculator.Properties.Resources._5;
            this.ButtonFive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonFive.FlatAppearance.BorderSize = 0;
            this.ButtonFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFive.Location = new System.Drawing.Point(77, 260);
            this.ButtonFive.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonFive.Name = "ButtonFive";
            this.ButtonFive.Size = new System.Drawing.Size(74, 61);
            this.ButtonFive.TabIndex = 8;
            this.ButtonFive.TabStop = false;
            this.ButtonFive.UseVisualStyleBackColor = false;
            this.ButtonFive.Click += new System.EventHandler(this.ButtonFive_Click);
            // 
            // ButtonFour
            // 
            this.ButtonFour.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonFour.BackgroundImage = global::Calculator.Properties.Resources._4;
            this.ButtonFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonFour.FlatAppearance.BorderSize = 0;
            this.ButtonFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFour.Location = new System.Drawing.Point(1, 260);
            this.ButtonFour.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonFour.Name = "ButtonFour";
            this.ButtonFour.Size = new System.Drawing.Size(74, 61);
            this.ButtonFour.TabIndex = 7;
            this.ButtonFour.TabStop = false;
            this.ButtonFour.UseVisualStyleBackColor = false;
            this.ButtonFour.Click += new System.EventHandler(this.ButtonFour_Click);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.BackColor = System.Drawing.Color.Lavender;
            this.ButtonPlus.BackgroundImage = global::Calculator.Properties.Resources.plus;
            this.ButtonPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonPlus.FlatAppearance.BorderSize = 0;
            this.ButtonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPlus.Location = new System.Drawing.Point(229, 323);
            this.ButtonPlus.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(74, 61);
            this.ButtonPlus.TabIndex = 6;
            this.ButtonPlus.TabStop = false;
            this.ButtonPlus.UseVisualStyleBackColor = false;
            this.ButtonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // ButtonThree
            // 
            this.ButtonThree.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonThree.BackgroundImage = global::Calculator.Properties.Resources._3;
            this.ButtonThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonThree.FlatAppearance.BorderSize = 0;
            this.ButtonThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonThree.Location = new System.Drawing.Point(153, 323);
            this.ButtonThree.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonThree.Name = "ButtonThree";
            this.ButtonThree.Size = new System.Drawing.Size(74, 61);
            this.ButtonThree.TabIndex = 5;
            this.ButtonThree.TabStop = false;
            this.ButtonThree.UseVisualStyleBackColor = false;
            this.ButtonThree.Click += new System.EventHandler(this.ButtonThree_Click);
            // 
            // ButtonTwo
            // 
            this.ButtonTwo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonTwo.BackgroundImage = global::Calculator.Properties.Resources._2;
            this.ButtonTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonTwo.FlatAppearance.BorderSize = 0;
            this.ButtonTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTwo.Location = new System.Drawing.Point(77, 323);
            this.ButtonTwo.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonTwo.Name = "ButtonTwo";
            this.ButtonTwo.Size = new System.Drawing.Size(74, 61);
            this.ButtonTwo.TabIndex = 4;
            this.ButtonTwo.TabStop = false;
            this.ButtonTwo.UseVisualStyleBackColor = false;
            this.ButtonTwo.Click += new System.EventHandler(this.ButtonTwo_Click);
            // 
            // ButtonOne
            // 
            this.ButtonOne.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonOne.BackgroundImage = global::Calculator.Properties.Resources._1;
            this.ButtonOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonOne.FlatAppearance.BorderSize = 0;
            this.ButtonOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOne.Location = new System.Drawing.Point(1, 323);
            this.ButtonOne.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonOne.Name = "ButtonOne";
            this.ButtonOne.Size = new System.Drawing.Size(74, 61);
            this.ButtonOne.TabIndex = 3;
            this.ButtonOne.TabStop = false;
            this.ButtonOne.UseVisualStyleBackColor = false;
            this.ButtonOne.Click += new System.EventHandler(this.ButtonOne_Click);
            // 
            // ButtonEqual
            // 
            this.ButtonEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ButtonEqual.BackgroundImage = global::Calculator.Properties.Resources.equal;
            this.ButtonEqual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonEqual.FlatAppearance.BorderSize = 0;
            this.ButtonEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEqual.Location = new System.Drawing.Point(229, 386);
            this.ButtonEqual.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonEqual.Name = "ButtonEqual";
            this.ButtonEqual.Size = new System.Drawing.Size(74, 61);
            this.ButtonEqual.TabIndex = 2;
            this.ButtonEqual.UseVisualStyleBackColor = false;
            this.ButtonEqual.Click += new System.EventHandler(this.ButtonEqual_Click);
            // 
            // ButtonDot
            // 
            this.ButtonDot.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonDot.BackgroundImage = global::Calculator.Properties.Resources.dot;
            this.ButtonDot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonDot.FlatAppearance.BorderSize = 0;
            this.ButtonDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDot.Font = new System.Drawing.Font("SF Pro Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDot.Location = new System.Drawing.Point(153, 386);
            this.ButtonDot.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonDot.Name = "ButtonDot";
            this.ButtonDot.Size = new System.Drawing.Size(74, 61);
            this.ButtonDot.TabIndex = 1;
            this.ButtonDot.TabStop = false;
            this.ButtonDot.UseVisualStyleBackColor = false;
            this.ButtonDot.Click += new System.EventHandler(this.ButtonDot_Click);
            // 
            // ButtonZero
            // 
            this.ButtonZero.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonZero.BackgroundImage = global::Calculator.Properties.Resources._0;
            this.ButtonZero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonZero.FlatAppearance.BorderSize = 0;
            this.ButtonZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonZero.Location = new System.Drawing.Point(1, 386);
            this.ButtonZero.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonZero.Name = "ButtonZero";
            this.ButtonZero.Size = new System.Drawing.Size(150, 61);
            this.ButtonZero.TabIndex = 0;
            this.ButtonZero.TabStop = false;
            this.ButtonZero.UseVisualStyleBackColor = false;
            this.ButtonZero.Click += new System.EventHandler(this.ButtonZero_Click);
            // 
            // FormulaDisplay
            // 
            this.FormulaDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.FormulaDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FormulaDisplay.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormulaDisplay.Enabled = false;
            this.FormulaDisplay.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormulaDisplay.Location = new System.Drawing.Point(7, 19);
            this.FormulaDisplay.Name = "FormulaDisplay";
            this.FormulaDisplay.ReadOnly = true;
            this.FormulaDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FormulaDisplay.Size = new System.Drawing.Size(291, 20);
            this.FormulaDisplay.TabIndex = 20;
            this.FormulaDisplay.TabStop = false;
            this.FormulaDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FormulaDisplay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormulaDisplay_MouseDown);
            // 
            // CalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 448);
            this.Controls.Add(this.FormulaDisplay);
            this.Controls.Add(this.MainDisplay);
            this.Controls.Add(this.ButtonDivide);
            this.Controls.Add(this.ButtonSquareRoot);
            this.Controls.Add(this.ButtonSquare);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonMultiply);
            this.Controls.Add(this.ButtonNine);
            this.Controls.Add(this.ButtonEight);
            this.Controls.Add(this.ButtonSeven);
            this.Controls.Add(this.ButtonMinus);
            this.Controls.Add(this.ButtonSix);
            this.Controls.Add(this.ButtonFive);
            this.Controls.Add(this.ButtonFour);
            this.Controls.Add(this.ButtonPlus);
            this.Controls.Add(this.ButtonThree);
            this.Controls.Add(this.ButtonTwo);
            this.Controls.Add(this.ButtonOne);
            this.Controls.Add(this.ButtonEqual);
            this.Controls.Add(this.ButtonDot);
            this.Controls.Add(this.ButtonZero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "CalculatorUI";
            this.Opacity = 0.96D;
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CalculatorUI_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalculatorUI_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonZero;
        private System.Windows.Forms.Button ButtonDot;
        private System.Windows.Forms.Button ButtonEqual;
        private System.Windows.Forms.Button ButtonOne;
        private System.Windows.Forms.Button ButtonTwo;
        private System.Windows.Forms.Button ButtonThree;
        private System.Windows.Forms.Button ButtonPlus;
        private System.Windows.Forms.Button ButtonMinus;
        private System.Windows.Forms.Button ButtonSix;
        private System.Windows.Forms.Button ButtonFive;
        private System.Windows.Forms.Button ButtonFour;
        private System.Windows.Forms.Button ButtonMultiply;
        private System.Windows.Forms.Button ButtonNine;
        private System.Windows.Forms.Button ButtonEight;
        private System.Windows.Forms.Button ButtonSeven;
        private System.Windows.Forms.Button ButtonDivide;
        private System.Windows.Forms.Button ButtonSquareRoot;
        private System.Windows.Forms.Button ButtonSquare;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.TextBox MainDisplay;
        private System.Windows.Forms.TextBox FormulaDisplay;
    }
}

