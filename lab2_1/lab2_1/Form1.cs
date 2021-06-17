using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вариант 11\n\nИз исходного списка получите два новых списка путем копиpования: 1-й список должен содеpжать слова, начинающиеся с заданной комбинации символов; 2 - й список - слова, заканчивающиеся заданной комбинацией символов.\n\nРазработчик: студент 6104 группы Домбровский Данила.", "О программе");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                this.Close();
        }

        private void createListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Database.initialList == null)
            {
                Database.initialList = new SingleLinkedList();
                MessageBox.Show("Список создан! Добавьте в него элементы.\nЗадание->Редактирование списка->Добавление элемента", "Создание списка", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Список уже создан.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void removeTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Database.initialList != null)
            {
                try
                {
                    Database.initialList.RemoveFirst();
                    MessageBox.Show("Первый элемент успешно удалён.", "Удаление элемента в начале", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("Список пуст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Список не создан!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void removeEndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Database.initialList != null)
            {
                try
                {
                    Database.initialList.RemoveLast();
                    MessageBox.Show("Последний элемент успешно удалён.", "Удаление элемента в начале", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("Список пуст!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Список не создан!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void removeIndexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Database.initialList == null)
                MessageBox.Show("Список не создан!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (Database.initialList.First == null)
                MessageBox.Show("Список пуст!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                RemoveElementForm removeElement = new RemoveElementForm();
                removeElement.ShowDialog();
            }
        }

        private void destroyListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Database.initialList != null)
            {
                Database.initialList.Clear();
                MessageBox.Show("Список разрушен.", "Разрушение списка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Список не создан!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void processListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Database.initialList == null)
                MessageBox.Show("Список не создан!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (Database.initialList.First == null)
                MessageBox.Show("Список пуст!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                TaskForm task = new TaskForm();
                task.ShowDialog();
            }
        }

        private void addToTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Database.initialList != null)
            {
                AddElementForm addToTop = new AddElementForm("toTop");
                addToTop.ShowDialog();
            }
            else
                MessageBox.Show("Список не создан!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AddToEndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Database.initialList != null)
            {
                AddElementForm addToTop = new AddElementForm("toEnd");
                addToTop.ShowDialog();
            }
            else
                MessageBox.Show("Список не создан!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void addValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Database.initialList != null)
            {
                if (Database.initialList.First != null)
                {
                    AddElementForm addToTop = new AddElementForm("toValue");
                    addToTop.ShowDialog();
                }
                else
                    MessageBox.Show("Нельзя добавить элемент в произвольную точку в пустом списке.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Список не создан!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
