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
    public partial class RemoveElementForm : Form
    {
        public RemoveElementForm()
        {
            InitializeComponent();
            if (Database.initialList.First != null)
                foreach(string word in Database.initialList)
                    listBox1.Items.Add(word);
            else
            {
                MessageBox.Show("Список пуст!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }         
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(listBox1.Text))
            {
                Database.initialList.Remove(Database.initialList.Find(listBox1.Text));
                listBox1.Items.Clear();
                foreach(string word in Database.initialList)
                    listBox1.Items.Add(word);
            }
            else if (Database.initialList.Count == 0)
                MessageBox.Show("Список пуст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Элемент для удаления не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
