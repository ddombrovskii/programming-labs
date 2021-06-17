using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_2
{
    public partial class TaskForm : Form
    {
        public TaskForm()
        {
            InitializeComponent();

            if (!Database.initialList.isEmpty())
                foreach (string word in Database.initialList)
                    initialListBox.Items.Add(word);
            else
            {
                MessageBox.Show("Список пуст!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            firstListBox.Items.Clear();
            secondListBox.Items.Clear();

            if (string.IsNullOrWhiteSpace(textBox1.Text))
                MessageBox.Show("Проверьте правильность ввода комбинации символов!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrEmpty(textBox1.Text))
                MessageBox.Show("Строка не может быть пустой!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Database.firstList = Database.initialList.GetStartsWithList(textBox1.Text);
                Database.secondList = Database.initialList.GetEndsWithList(textBox1.Text);

                foreach (string word in Database.firstList)
                    firstListBox.Items.Add(word);
                foreach (string word in Database.secondList)
                    secondListBox.Items.Add(word);
            }
        }
    }
}
