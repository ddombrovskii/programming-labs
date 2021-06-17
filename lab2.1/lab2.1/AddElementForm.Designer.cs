
namespace lab2._1
{
    partial class AddElementForm
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
            this.inputWordGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.indexGroupBox = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.inputWordGroupBox.SuspendLayout();
            this.indexGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputWordGroupBox
            // 
            this.inputWordGroupBox.Controls.Add(this.textBox1);
            this.inputWordGroupBox.Location = new System.Drawing.Point(12, 21);
            this.inputWordGroupBox.Name = "inputWordGroupBox";
            this.inputWordGroupBox.Size = new System.Drawing.Size(393, 60);
            this.inputWordGroupBox.TabIndex = 3;
            this.inputWordGroupBox.TabStop = false;
            this.inputWordGroupBox.Text = "Введите слово:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 22);
            this.textBox1.TabIndex = 0;
            // 
            // indexGroupBox
            // 
            this.indexGroupBox.Controls.Add(this.comboBox1);
            this.indexGroupBox.Controls.Add(this.label1);
            this.indexGroupBox.Location = new System.Drawing.Point(12, 87);
            this.indexGroupBox.Name = "indexGroupBox";
            this.indexGroupBox.Size = new System.Drawing.Size(393, 93);
            this.indexGroupBox.TabIndex = 4;
            this.indexGroupBox.TabStop = false;
            this.indexGroupBox.Text = "Индекс";
            this.indexGroupBox.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.Location = new System.Drawing.Point(130, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите индекс будущего элемента списка.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddElementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 228);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.indexGroupBox);
            this.Controls.Add(this.inputWordGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddElementForm";
            this.Text = "Добавление элемента";
            this.inputWordGroupBox.ResumeLayout(false);
            this.inputWordGroupBox.PerformLayout();
            this.indexGroupBox.ResumeLayout(false);
            this.indexGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox inputWordGroupBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox indexGroupBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}