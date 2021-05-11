namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CalculatorButton = new System.Windows.Forms.Button();
            this.MainTextBox = new System.Windows.Forms.TextBox();
            this.hangManButton = new System.Windows.Forms.Button();
            this.SortingButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.PacManButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // CalculatorButton
            // 
            this.CalculatorButton.Image = global::MultiToolApplication.Properties.Resources.Calculator;
            this.CalculatorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CalculatorButton.Location = new System.Drawing.Point(68, 137);
            this.CalculatorButton.Name = "CalculatorButton";
            this.CalculatorButton.Size = new System.Drawing.Size(93, 30);
            this.CalculatorButton.TabIndex = 0;
            this.CalculatorButton.Text = "Calculator";
            this.CalculatorButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CalculatorButton.UseVisualStyleBackColor = true;
            this.CalculatorButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // MainTextBox
            // 
            this.MainTextBox.Location = new System.Drawing.Point(244, 57);
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.Size = new System.Drawing.Size(251, 23);
            this.MainTextBox.TabIndex = 1;
            this.MainTextBox.Text = "Not Connected";
            // 
            // hangManButton
            // 
            this.hangManButton.Image = ((System.Drawing.Image)(resources.GetObject("hangManButton.Image")));
            this.hangManButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hangManButton.Location = new System.Drawing.Point(167, 137);
            this.hangManButton.Name = "hangManButton";
            this.hangManButton.Size = new System.Drawing.Size(93, 30);
            this.hangManButton.TabIndex = 2;
            this.hangManButton.Text = "HangMan";
            this.hangManButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hangManButton.UseVisualStyleBackColor = true;
            this.hangManButton.Click += new System.EventHandler(this.hangManButton_Click);
            // 
            // SortingButton
            // 
            this.SortingButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SortingButton.Location = new System.Drawing.Point(266, 137);
            this.SortingButton.Name = "SortingButton";
            this.SortingButton.Size = new System.Drawing.Size(127, 30);
            this.SortingButton.TabIndex = 3;
            this.SortingButton.Text = "Sorting Algorithms";
            this.SortingButton.UseVisualStyleBackColor = true;
            this.SortingButton.Click += new System.EventHandler(this.SortingButton_Click);
            // 
            // PacManButton
            // 
            this.PacManButton.Image = global::MultiToolApplication.Properties.Resources.PacManSmall;
            this.PacManButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PacManButton.Location = new System.Drawing.Point(167, 173);
            this.PacManButton.Name = "PacManButton";
            this.PacManButton.Size = new System.Drawing.Size(93, 30);
            this.PacManButton.TabIndex = 4;
            this.PacManButton.Text = "Pac Man";
            this.PacManButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PacManButton.UseVisualStyleBackColor = true;
            this.PacManButton.Click += new System.EventHandler(this.PacManButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PacManButton);
            this.Controls.Add(this.SortingButton);
            this.Controls.Add(this.hangManButton);
            this.Controls.Add(this.MainTextBox);
            this.Controls.Add(this.CalculatorButton);
            this.Name = "MainForm";
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculatorButton;
        private System.Windows.Forms.TextBox MainTextBox;
        private System.Windows.Forms.Button hangManButton;
        private System.Windows.Forms.Button SortingButton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PacManButton;
    }
}

