using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2._1
{
    public partial class AddElementForm : Form
    {
        private string addMode;

        public string AddMode
        {
            get { return addMode; }
            set { addMode = value; }
        }

        public AddElementForm(string mode)
        {
            InitializeComponent();
            addMode = mode;
            if (AddMode == "toTop" | AddMode == "toEnd")
                indexGroupBox.Visible = false;
            else
            {
                indexGroupBox.Visible = true;
                for (int i = 0; i < Database.initialList.Count; i++)
                    comboBox1.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                if (AddMode == "toTop")
                {
                    Database.initialList.AddFirst(textBox1.Text);
                    textBox1.Text = null;
                }
                else if (AddMode == "toEnd")
                {
                    Database.initialList.AddLast(textBox1.Text);
                    textBox1.Text = null;
                }
                else
                {
                    try
                    {
                        Database.initialList.AddValue(textBox1.Text, Convert.ToInt32(comboBox1.Text));
                        comboBox1.Items.Add(Database.initialList.Count - 1);
                        textBox1.Text = null;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("В текущем списке нет такой точки. Проверьте индекс.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Индекс задаётся целым положительным числом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("Слово не введено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
