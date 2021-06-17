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
    public partial class AddElementForm : Form
    {
        public AddElementForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(numberTextBox.Text) || string.IsNullOrWhiteSpace(numberTextBox.Text))
                MessageBox.Show("Число не введено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                this.Close();
        }

        public double GetNumber()
        {
            return double.Parse(numberTextBox.Text);
        }
    }
}
