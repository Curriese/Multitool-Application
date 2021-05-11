namespace WindowsFormsApp1
{
    partial class CalculatorForm
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
            this.calcTextBox = new System.Windows.Forms.RichTextBox();
            this.ButtonZero = new System.Windows.Forms.Button();
            this.ButtonDot = new System.Windows.Forms.Button();
            this.ButtonEquals = new System.Windows.Forms.Button();
            this.ButtonOne = new System.Windows.Forms.Button();
            this.ButtonTwo = new System.Windows.Forms.Button();
            this.ButtonThree = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.ButtonFour = new System.Windows.Forms.Button();
            this.ButtonFive = new System.Windows.Forms.Button();
            this.ButtonSix = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.ButtonSeven = new System.Windows.Forms.Button();
            this.ButtonEight = new System.Windows.Forms.Button();
            this.ButtonNine = new System.Windows.Forms.Button();
            this.ButtonMultiply = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonNegate = new System.Windows.Forms.Button();
            this.ButtonPercent = new System.Windows.Forms.Button();
            this.ButtonDivide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calcTextBox
            // 
            this.calcTextBox.Enabled = false;
            this.calcTextBox.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calcTextBox.Location = new System.Drawing.Point(12, 12);
            this.calcTextBox.Multiline = false;
            this.calcTextBox.Name = "calcTextBox";
            this.calcTextBox.ReadOnly = true;
            this.calcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.calcTextBox.Size = new System.Drawing.Size(418, 82);
            this.calcTextBox.TabIndex = 0;
            this.calcTextBox.Text = "0";
            // 
            // ButtonZero
            // 
            this.ButtonZero.Font = new System.Drawing.Font("Segoe UI", 43F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonZero.Location = new System.Drawing.Point(12, 524);
            this.ButtonZero.Name = "ButtonZero";
            this.ButtonZero.Size = new System.Drawing.Size(206, 100);
            this.ButtonZero.TabIndex = 1;
            this.ButtonZero.Text = "0";
            this.ButtonZero.UseVisualStyleBackColor = true;
            this.ButtonZero.Click += new System.EventHandler(this.ButtonZero_Click);
            // 
            // ButtonDot
            // 
            this.ButtonDot.Font = new System.Drawing.Font("Segoe UI", 43F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonDot.Location = new System.Drawing.Point(224, 524);
            this.ButtonDot.Name = "ButtonDot";
            this.ButtonDot.Size = new System.Drawing.Size(100, 100);
            this.ButtonDot.TabIndex = 2;
            this.ButtonDot.Text = ".";
            this.ButtonDot.UseVisualStyleBackColor = true;
            this.ButtonDot.Click += new System.EventHandler(this.ButtonDot_Click);
            // 
            // ButtonEquals
            // 
            this.ButtonEquals.Font = new System.Drawing.Font("Segoe UI", 43F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonEquals.Location = new System.Drawing.Point(330, 524);
            this.ButtonEquals.Name = "ButtonEquals";
            this.ButtonEquals.Size = new System.Drawing.Size(100, 100);
            this.ButtonEquals.TabIndex = 3;
            this.ButtonEquals.Text = "=";
            this.ButtonEquals.UseVisualStyleBackColor = true;
            this.ButtonEquals.Click += new System.EventHandler(this.ButtonEquals_Click);
            // 
            // ButtonOne
            // 
            this.ButtonOne.Font = new System.Drawing.Font("Segoe UI", 43F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonOne.Location = new System.Drawing.Point(12, 418);
            this.ButtonOne.Name = "ButtonOne";
            this.ButtonOne.Size = new System.Drawing.Size(100, 100);
            this.ButtonOne.TabIndex = 2;
            this.ButtonOne.Text = "1";
            this.ButtonOne.UseVisualStyleBackColor = true;
            this.ButtonOne.Click += new System.EventHandler(this.ButtonOne_Click);
            // 
            // ButtonTwo
            // 
            this.ButtonTwo.Font = new System.Drawing.Font("Segoe UI", 43F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonTwo.Location = new System.Drawing.Point(118, 418);
            this.ButtonTwo.Name = "ButtonTwo";
            this.ButtonTwo.Size = new System.Drawing.Size(100, 100);
            this.ButtonTwo.TabIndex = 2;
            this.ButtonTwo.Text = "2";
            this.ButtonTwo.UseVisualStyleBackColor = true;
            this.ButtonTwo.Click += new System.EventHandler(this.ButtonTwo_Click);
            // 
            // ButtonThree
            // 
            this.ButtonThree.Font = new System.Drawing.Font("Segoe UI", 43F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonThree.Location = new System.Drawing.Point(224, 418);
            this.ButtonThree.Name = "ButtonThree";
            this.ButtonThree.Size = new System.Drawing.Size(100, 100);
            this.ButtonThree.TabIndex = 2;
            this.ButtonThree.Text = "3";
            this.ButtonThree.UseVisualStyleBackColor = true;
            this.ButtonThree.Click += new System.EventHandler(this.ButtonThree_Click);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.Font = new System.Drawing.Font("Segoe UI", 43F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonPlus.Location = new System.Drawing.Point(330, 418);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(100, 100);
            this.ButtonPlus.TabIndex = 2;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = true;
            this.ButtonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // ButtonFour
            // 
            this.ButtonFour.Font = new System.Drawing.Font("Segoe UI", 43F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonFour.Location = new System.Drawing.Point(12, 312);
            this.ButtonFour.Name = "ButtonFour";
            this.ButtonFour.Size = new System.Drawing.Size(100, 100);
            this.ButtonFour.TabIndex = 2;
            this.ButtonFour.Text = "4";
            this.ButtonFour.UseVisualStyleBackColor = true;
            this.ButtonFour.Click += new System.EventHandler(this.ButtonFour_Click);
            // 
            // ButtonFive
            // 
            this.ButtonFive.Font = new System.Drawing.Font("Segoe UI", 43F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonFive.Location = new System.Drawing.Point(118, 312);
            this.ButtonFive.Name = "ButtonFive";
            this.ButtonFive.Size = new System.Drawing.Size(100, 100);
            this.ButtonFive.TabIndex = 2;
            this.ButtonFive.Text = "5";
            this.ButtonFive.UseVisualStyleBackColor = true;
            this.ButtonFive.Click += new System.EventHandler(this.ButtonFive_Click);
            // 
            // ButtonSix
            // 
            this.ButtonSix.Font = new System.Drawing.Font("Segoe UI", 43F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSix.Location = new System.Drawing.Point(224, 312);
            this.ButtonSix.Name = "ButtonSix";
            this.ButtonSix.Size = new System.Drawing.Size(100, 100);
            this.ButtonSix.TabIndex = 2;
            this.ButtonSix.Text = "6";
            this.ButtonSix.UseVisualStyleBackColor = true;
            this.ButtonSix.Click += new System.EventHandler(this.ButtonSix_Click);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.Font = new System.Drawing.Font("Segoe UI", 43F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonMinus.Location = new System.Drawing.Point(330, 312);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(100, 100);
            this.ButtonMinus.TabIndex = 2;
            this.ButtonMinus.Text = "-";
            this.ButtonMinus.UseVisualStyleBackColor = true;
            this.ButtonMinus.Click += new System.EventHandler(this.ButtonMinus_Click);
            // 
            // ButtonSeven
            // 
            this.ButtonSeven.Font = new System.Drawing.Font("Segoe UI", 43F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSeven.Location = new System.Drawing.Point(12, 206);
            this.ButtonSeven.Name = "ButtonSeven";
            this.ButtonSeven.Size = new System.Drawing.Size(100, 100);
            this.ButtonSeven.TabIndex = 2;
            this.ButtonSeven.Text = "7";
            this.ButtonSeven.UseVisualStyleBackColor = true;
            this.ButtonSeven.Click += new System.EventHandler(this.ButtonSeven_Click);
            // 
            // ButtonEight
            // 
            this.ButtonEight.Font = new System.Drawing.Font("Segoe UI", 43F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonEight.Location = new System.Drawing.Point(118, 206);
            this.ButtonEight.Name = "ButtonEight";
            this.ButtonEight.Size = new System.Drawing.Size(100, 100);
            this.ButtonEight.TabIndex = 2;
            this.ButtonEight.Text = "8";
            this.ButtonEight.UseVisualStyleBackColor = true;
            this.ButtonEight.Click += new System.EventHandler(this.ButtonEight_Click);
            // 
            // ButtonNine
            // 
            this.ButtonNine.Font = new System.Drawing.Font("Segoe UI", 43F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonNine.Location = new System.Drawing.Point(224, 206);
            this.ButtonNine.Name = "ButtonNine";
            this.ButtonNine.Size = new System.Drawing.Size(100, 100);
            this.ButtonNine.TabIndex = 2;
            this.ButtonNine.Text = "9";
            this.ButtonNine.UseVisualStyleBackColor = true;
            this.ButtonNine.Click += new System.EventHandler(this.ButtonNine_Click);
            // 
            // ButtonMultiply
            // 
            this.ButtonMultiply.Font = new System.Drawing.Font("Segoe UI", 43F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonMultiply.Location = new System.Drawing.Point(330, 206);
            this.ButtonMultiply.Name = "ButtonMultiply";
            this.ButtonMultiply.Size = new System.Drawing.Size(100, 100);
            this.ButtonMultiply.TabIndex = 2;
            this.ButtonMultiply.Text = "x";
            this.ButtonMultiply.UseVisualStyleBackColor = true;
            this.ButtonMultiply.Click += new System.EventHandler(this.ButtonMultiply_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonClear.Location = new System.Drawing.Point(12, 100);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(100, 100);
            this.ButtonClear.TabIndex = 2;
            this.ButtonClear.Text = "AC";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonNegate
            // 
            this.ButtonNegate.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonNegate.Location = new System.Drawing.Point(118, 100);
            this.ButtonNegate.Name = "ButtonNegate";
            this.ButtonNegate.Size = new System.Drawing.Size(100, 100);
            this.ButtonNegate.TabIndex = 2;
            this.ButtonNegate.Text = "+/-";
            this.ButtonNegate.UseVisualStyleBackColor = true;
            this.ButtonNegate.Click += new System.EventHandler(this.ButtonNegate_Click);
            // 
            // ButtonPercent
            // 
            this.ButtonPercent.Font = new System.Drawing.Font("Segoe UI", 43F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonPercent.Location = new System.Drawing.Point(224, 100);
            this.ButtonPercent.Name = "ButtonPercent";
            this.ButtonPercent.Size = new System.Drawing.Size(100, 100);
            this.ButtonPercent.TabIndex = 2;
            this.ButtonPercent.Text = "%";
            this.ButtonPercent.UseVisualStyleBackColor = true;
            this.ButtonPercent.Click += new System.EventHandler(this.ButtonPercent_Click);
            // 
            // ButtonDivide
            // 
            this.ButtonDivide.Font = new System.Drawing.Font("Segoe UI", 43F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonDivide.Location = new System.Drawing.Point(330, 100);
            this.ButtonDivide.Name = "ButtonDivide";
            this.ButtonDivide.Size = new System.Drawing.Size(100, 100);
            this.ButtonDivide.TabIndex = 2;
            this.ButtonDivide.Text = "÷";
            this.ButtonDivide.UseVisualStyleBackColor = true;
            this.ButtonDivide.Click += new System.EventHandler(this.ButtonDivide_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 636);
            this.Controls.Add(this.ButtonDivide);
            this.Controls.Add(this.ButtonPercent);
            this.Controls.Add(this.ButtonNegate);
            this.Controls.Add(this.ButtonClear);
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
            this.Controls.Add(this.ButtonEquals);
            this.Controls.Add(this.ButtonDot);
            this.Controls.Add(this.ButtonZero);
            this.Controls.Add(this.calcTextBox);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox calcTextBox;
        private System.Windows.Forms.Button ButtonZero;
        private System.Windows.Forms.Button ButtonDot;
        private System.Windows.Forms.Button ButtonEquals;
        private System.Windows.Forms.Button ButtonOne;
        private System.Windows.Forms.Button ButtonTwo;
        private System.Windows.Forms.Button ButtonThree;
        private System.Windows.Forms.Button ButtonPlus;
        private System.Windows.Forms.Button ButtonFour;
        private System.Windows.Forms.Button ButtonFive;
        private System.Windows.Forms.Button ButtonSix;
        private System.Windows.Forms.Button ButtonMinus;
        private System.Windows.Forms.Button ButtonSeven;
        private System.Windows.Forms.Button ButtonEight;
        private System.Windows.Forms.Button ButtonNine;
        private System.Windows.Forms.Button ButtonMultiply;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonNegate;
        private System.Windows.Forms.Button ButtonPercent;
        private System.Windows.Forms.Button ButtonDivide;
    }
}