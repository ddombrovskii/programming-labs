using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class InputN : Form
    {
        public InputN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
                MessageBox.Show("Число не введено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (int.Parse(textBox1.Text) < 0)
                MessageBox.Show("Число должно быть положительным", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Database.tree = new BinaryTree();
                Database.tree.Root = Database.tree.CreateTree(int.Parse(textBox1.Text));
                this.Close();
            }
        }
    }
}
