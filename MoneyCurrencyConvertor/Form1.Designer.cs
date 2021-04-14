
namespace MoneyCurrencyConvertor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SwitchButton = new System.Windows.Forms.Button();
            this.CurrencyTypeInBox = new System.Windows.Forms.ComboBox();
            this.CurrencyTypeOutBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.OutAmountTextBox = new System.Windows.Forms.TextBox();
            this.NumericAmountIn = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericAmountIn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.SwitchButton);
            this.panel1.Controls.Add(this.CurrencyTypeInBox);
            this.panel1.Controls.Add(this.CurrencyTypeOutBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 125);
            this.panel1.TabIndex = 0;
            // 
            // SwitchButton
            // 
            this.SwitchButton.Location = new System.Drawing.Point(325, 42);
            this.SwitchButton.Name = "SwitchButton";
            this.SwitchButton.Size = new System.Drawing.Size(138, 29);
            this.SwitchButton.TabIndex = 2;
            this.SwitchButton.Text = "<=>";
            this.SwitchButton.UseVisualStyleBackColor = true;
            this.SwitchButton.Click += new System.EventHandler(this.SwitchButton_Click);
            // 
            // CurrencyTypeInBox
            // 
            this.CurrencyTypeInBox.FormattingEnabled = true;
            this.CurrencyTypeInBox.Location = new System.Drawing.Point(501, 44);
            this.CurrencyTypeInBox.Name = "CurrencyTypeInBox";
            this.CurrencyTypeInBox.Size = new System.Drawing.Size(226, 28);
            this.CurrencyTypeInBox.TabIndex = 1;
            // 
            // CurrencyTypeOutBox
            // 
            this.CurrencyTypeOutBox.FormattingEnabled = true;
            this.CurrencyTypeOutBox.Location = new System.Drawing.Point(61, 44);
            this.CurrencyTypeOutBox.Name = "CurrencyTypeOutBox";
            this.CurrencyTypeOutBox.Size = new System.Drawing.Size(226, 28);
            this.CurrencyTypeOutBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.ConvertButton);
            this.panel2.Controls.Add(this.OutAmountTextBox);
            this.panel2.Controls.Add(this.NumericAmountIn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 325);
            this.panel2.TabIndex = 1;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(350, 67);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(102, 29);
            this.ConvertButton.TabIndex = 2;
            this.ConvertButton.Text = "=>";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // OutAmountTextBox
            // 
            this.OutAmountTextBox.Location = new System.Drawing.Point(458, 67);
            this.OutAmountTextBox.Name = "OutAmountTextBox";
            this.OutAmountTextBox.Size = new System.Drawing.Size(230, 27);
            this.OutAmountTextBox.TabIndex = 1;
            // 
            // NumericAmountOut
            // 
            this.NumericAmountIn.Location = new System.Drawing.Point(114, 68);
            this.NumericAmountIn.Name = "NumericAmountOut";
            this.NumericAmountIn.Size = new System.Drawing.Size(230, 27);
            this.NumericAmountIn.TabIndex = 0;
            this.NumericAmountIn.ValueChanged += new System.EventHandler(this.NumericAmountIn_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "Form1";
            this.Text = "Convertor";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericAmountIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CurrencyTypeInBox;
        private System.Windows.Forms.ComboBox CurrencyTypeOutBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SwitchButton;
        private System.Windows.Forms.TextBox OutAmountTextBox;
        private System.Windows.Forms.NumericUpDown NumericAmountIn;
        private System.Windows.Forms.Button ConvertButton;
    }
}

