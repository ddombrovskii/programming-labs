
namespace lab2_2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToEndToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeEndToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeIndexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destroyListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProgramToolStripMenuItem,
            this.taskToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(697, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.aboutProgramToolStripMenuItem.Text = "О программе";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // taskToolStripMenuItem
            // 
            this.taskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createListToolStripMenuItem,
            this.editListToolStripMenuItem,
            this.processListToolStripMenuItem,
            this.destroyListToolStripMenuItem});
            this.taskToolStripMenuItem.Name = "taskToolStripMenuItem";
            this.taskToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.taskToolStripMenuItem.Text = "Задание";
            // 
            // createListToolStripMenuItem
            // 
            this.createListToolStripMenuItem.Name = "createListToolStripMenuItem";
            this.createListToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.createListToolStripMenuItem.Text = "Создание списка";
            this.createListToolStripMenuItem.Click += new System.EventHandler(this.createListToolStripMenuItem_Click);
            // 
            // editListToolStripMenuItem
            // 
            this.editListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addElementToolStripMenuItem,
            this.deleteElementToolStripMenuItem});
            this.editListToolStripMenuItem.Name = "editListToolStripMenuItem";
            this.editListToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.editListToolStripMenuItem.Text = "Редактирование списка";
            // 
            // addElementToolStripMenuItem
            // 
            this.addElementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToTopToolStripMenuItem,
            this.AddToEndToolStripMenuItem,
            this.addValueToolStripMenuItem});
            this.addElementToolStripMenuItem.Name = "addElementToolStripMenuItem";
            this.addElementToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.addElementToolStripMenuItem.Text = "Добавление элемента";
            // 
            // addToTopToolStripMenuItem
            // 
            this.addToTopToolStripMenuItem.Name = "addToTopToolStripMenuItem";
            this.addToTopToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.addToTopToolStripMenuItem.Text = "В начало";
            this.addToTopToolStripMenuItem.Click += new System.EventHandler(this.addToTopToolStripMenuItem_Click);
            // 
            // AddToEndToolStripMenuItem
            // 
            this.AddToEndToolStripMenuItem.Name = "AddToEndToolStripMenuItem";
            this.AddToEndToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.AddToEndToolStripMenuItem.Text = "В конец";
            this.AddToEndToolStripMenuItem.Click += new System.EventHandler(this.AddToEndToolStripMenuItem_Click);
            // 
            // addValueToolStripMenuItem
            // 
            this.addValueToolStripMenuItem.Name = "addValueToolStripMenuItem";
            this.addValueToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.addValueToolStripMenuItem.Text = "В произвольную точку";
            this.addValueToolStripMenuItem.Click += new System.EventHandler(this.addValueToolStripMenuItem_Click);
            // 
            // deleteElementToolStripMenuItem
            // 
            this.deleteElementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeTopToolStripMenuItem,
            this.removeEndToolStripMenuItem,
            this.removeIndexToolStripMenuItem});
            this.deleteElementToolStripMenuItem.Name = "deleteElementToolStripMenuItem";
            this.deleteElementToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.deleteElementToolStripMenuItem.Text = "Удаление элемента";
            // 
            // removeTopToolStripMenuItem
            // 
            this.removeTopToolStripMenuItem.Name = "removeTopToolStripMenuItem";
            this.removeTopToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.removeTopToolStripMenuItem.Text = "В начале";
            this.removeTopToolStripMenuItem.Click += new System.EventHandler(this.removeTopToolStripMenuItem_Click);
            // 
            // removeEndToolStripMenuItem
            // 
            this.removeEndToolStripMenuItem.Name = "removeEndToolStripMenuItem";
            this.removeEndToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.removeEndToolStripMenuItem.Text = "В конце";
            this.removeEndToolStripMenuItem.Click += new System.EventHandler(this.removeEndToolStripMenuItem_Click);
            // 
            // removeIndexToolStripMenuItem
            // 
            this.removeIndexToolStripMenuItem.Name = "removeIndexToolStripMenuItem";
            this.removeIndexToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.removeIndexToolStripMenuItem.Text = "В произвольной точке";
            this.removeIndexToolStripMenuItem.Click += new System.EventHandler(this.removeIndexToolStripMenuItem_Click);
            // 
            // processListToolStripMenuItem
            // 
            this.processListToolStripMenuItem.Name = "processListToolStripMenuItem";
            this.processListToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.processListToolStripMenuItem.Text = "Обработка списка";
            this.processListToolStripMenuItem.Click += new System.EventHandler(this.processListToolStripMenuItem_Click);
            // 
            // destroyListToolStripMenuItem
            // 
            this.destroyListToolStripMenuItem.Name = "destroyListToolStripMenuItem";
            this.destroyListToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.destroyListToolStripMenuItem.Text = "Разрушение списка";
            this.destroyListToolStripMenuItem.Click += new System.EventHandler(this.destroyListToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 359);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Лабораторная работа №2 Часть 1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addElementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteElementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem destroyListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeEndToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeIndexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToEndToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addValueToolStripMenuItem;
    }
}

