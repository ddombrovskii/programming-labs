
namespace lab2._1
{
    partial class TaskForm
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
            this.initialListBox = new System.Windows.Forms.ListBox();
            this.firstListBox = new System.Windows.Forms.ListBox();
            this.secondListBox = new System.Windows.Forms.ListBox();
            this.initialListLabel = new System.Windows.Forms.Label();
            this.firstListLabel = new System.Windows.Forms.Label();
            this.secondListLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.charsLabel = new System.Windows.Forms.Label();
            this.processButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // initialListBox
            // 
            this.initialListBox.FormattingEnabled = true;
            this.initialListBox.ItemHeight = 16;
            this.initialListBox.Location = new System.Drawing.Point(12, 124);
            this.initialListBox.Name = "initialListBox";
            this.initialListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.initialListBox.Size = new System.Drawing.Size(258, 340);
            this.initialListBox.TabIndex = 0;
            // 
            // firstListBox
            // 
            this.firstListBox.FormattingEnabled = true;
            this.firstListBox.ItemHeight = 16;
            this.firstListBox.Location = new System.Drawing.Point(285, 124);
            this.firstListBox.Name = "firstListBox";
            this.firstListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.firstListBox.Size = new System.Drawing.Size(249, 340);
            this.firstListBox.TabIndex = 1;
            // 
            // secondListBox
            // 
            this.secondListBox.FormattingEnabled = true;
            this.secondListBox.ItemHeight = 16;
            this.secondListBox.Location = new System.Drawing.Point(549, 124);
            this.secondListBox.Name = "secondListBox";
            this.secondListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.secondListBox.Size = new System.Drawing.Size(241, 340);
            this.secondListBox.TabIndex = 2;
            // 
            // initialListLabel
            // 
            this.initialListLabel.AutoSize = true;
            this.initialListLabel.Location = new System.Drawing.Point(69, 87);
            this.initialListLabel.Name = "initialListLabel";
            this.initialListLabel.Size = new System.Drawing.Size(147, 17);
            this.initialListLabel.TabIndex = 3;
            this.initialListLabel.Text = "Изначальный список";
            // 
            // firstListLabel
            // 
            this.firstListLabel.AutoSize = true;
            this.firstListLabel.Location = new System.Drawing.Point(293, 87);
            this.firstListLabel.Name = "firstListLabel";
            this.firstListLabel.Size = new System.Drawing.Size(234, 34);
            this.firstListLabel.TabIndex = 4;
            this.firstListLabel.Text = "Слова, начинающиеся с заданной\r\nкомбинации символов";
            this.firstListLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // secondListLabel
            // 
            this.secondListLabel.AutoSize = true;
            this.secondListLabel.Location = new System.Drawing.Point(546, 87);
            this.secondListLabel.Name = "secondListLabel";
            this.secondListLabel.Size = new System.Drawing.Size(244, 34);
            this.secondListLabel.TabIndex = 5;
            this.secondListLabel.Text = "Слова, заканчивающиеся заданной\r\nкомбинацией символов.";
            this.secondListLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(261, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 22);
            this.textBox1.TabIndex = 6;
            // 
            // charsLabel
            // 
            this.charsLabel.AutoSize = true;
            this.charsLabel.Location = new System.Drawing.Point(86, 35);
            this.charsLabel.Name = "charsLabel";
            this.charsLabel.Size = new System.Drawing.Size(160, 17);
            this.charsLabel.TabIndex = 7;
            this.charsLabel.Text = "Комбинация символов:";
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(555, 26);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(114, 35);
            this.processButton.TabIndex = 8;
            this.processButton.Text = "Обработать";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(802, 476);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.charsLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.secondListLabel);
            this.Controls.Add(this.firstListLabel);
            this.Controls.Add(this.initialListLabel);
            this.Controls.Add(this.secondListBox);
            this.Controls.Add(this.firstListBox);
            this.Controls.Add(this.initialListBox);
            this.Name = "TaskForm";
            this.Text = "Обработка списка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox initialListBox;
        private System.Windows.Forms.ListBox firstListBox;
        private System.Windows.Forms.ListBox secondListBox;
        private System.Windows.Forms.Label initialListLabel;
        private System.Windows.Forms.Label firstListLabel;
        private System.Windows.Forms.Label secondListLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label charsLabel;
        private System.Windows.Forms.Button processButton;
    }
}