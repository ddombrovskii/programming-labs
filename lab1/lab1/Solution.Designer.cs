
namespace lab1
{
    partial class Solution
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
            this.input_s = new System.Windows.Forms.TextBox();
            this.input_i = new System.Windows.Forms.TextBox();
            this.input_j = new System.Windows.Forms.TextBox();
            this.label_s = new System.Windows.Forms.Label();
            this.label_i = new System.Windows.Forms.Label();
            this.label_j = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.Label();
            this.errLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input_s
            // 
            this.input_s.Location = new System.Drawing.Point(250, 70);
            this.input_s.Name = "input_s";
            this.input_s.Size = new System.Drawing.Size(350, 22);
            this.input_s.TabIndex = 1;
            // 
            // input_i
            // 
            this.input_i.Location = new System.Drawing.Point(250, 118);
            this.input_i.Name = "input_i";
            this.input_i.Size = new System.Drawing.Size(350, 22);
            this.input_i.TabIndex = 2;
            // 
            // input_j
            // 
            this.input_j.Location = new System.Drawing.Point(250, 166);
            this.input_j.Name = "input_j";
            this.input_j.Size = new System.Drawing.Size(350, 22);
            this.input_j.TabIndex = 3;
            // 
            // label_s
            // 
            this.label_s.AutoSize = true;
            this.label_s.Location = new System.Drawing.Point(101, 73);
            this.label_s.Name = "label_s";
            this.label_s.Size = new System.Drawing.Size(115, 17);
            this.label_s.TabIndex = 4;
            this.label_s.Text = "Введите строку:";
            // 
            // label_i
            // 
            this.label_i.AutoSize = true;
            this.label_i.Location = new System.Drawing.Point(142, 121);
            this.label_i.Name = "label_i";
            this.label_i.Size = new System.Drawing.Size(74, 17);
            this.label_i.TabIndex = 5;
            this.label_i.Text = "Введите i:";
            // 
            // label_j
            // 
            this.label_j.AutoSize = true;
            this.label_j.Location = new System.Drawing.Point(142, 169);
            this.label_j.Name = "label_j";
            this.label_j.Size = new System.Drawing.Size(74, 17);
            this.label_j.TabIndex = 6;
            this.label_j.Text = "Введите j:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.AcceptsReturn = true;
            this.outputTextBox.Location = new System.Drawing.Point(250, 217);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(350, 22);
            this.outputTextBox.TabIndex = 8;
            this.outputTextBox.WordWrap = false;
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(161, 220);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(55, 17);
            this.output.TabIndex = 9;
            this.output.Text = "Output:";
            // 
            // errLabel
            // 
            this.errLabel.AutoSize = true;
            this.errLabel.ForeColor = System.Drawing.Color.Red;
            this.errLabel.Location = new System.Drawing.Point(256, 242);
            this.errLabel.Name = "errLabel";
            this.errLabel.Size = new System.Drawing.Size(0, 17);
            this.errLabel.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "индекс в строке начинается с 1";
            // 
            // Solution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 334);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errLabel);
            this.Controls.Add(this.output);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_j);
            this.Controls.Add(this.label_i);
            this.Controls.Add(this.label_s);
            this.Controls.Add(this.input_j);
            this.Controls.Add(this.input_i);
            this.Controls.Add(this.input_s);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Solution";
            this.Text = "Решение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox input_s;
        private System.Windows.Forms.TextBox input_i;
        private System.Windows.Forms.TextBox input_j;
        private System.Windows.Forms.Label label_s;
        private System.Windows.Forms.Label label_i;
        private System.Windows.Forms.Label label_j;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Label errLabel;
        private System.Windows.Forms.Label label1;
    }
}