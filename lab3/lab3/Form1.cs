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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вариант 9\n\nСоздать сбалансированное дерево. Найти максимальное значение среди всех информационных полей узлов дерева.\n\nРазработчик: студент 6104 группы Домбровский Данила.", "О программе");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                this.Close();
        }

        private void createTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Database.tree == null || Database.tree.Root == null)
            {
                InputN input = new InputN();
                input.ShowDialog();
            }
            else
                MessageBox.Show("Дерево уже создано!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void DrawTree(TreeNode root, int x, int y, int dx, double max)
        {
            if (root != null)
            {
                Graphics g = pictureBox1.CreateGraphics();

                if(root.Info == max)
                    g.DrawString(root.Info.ToString(), new Font("Tahoma", 10), Brushes.Red, new PointF(x, y));
                else
                    g.DrawString(root.Info.ToString(), new Font("Tahoma", 10), Brushes.Black, new PointF(x, y));

                DrawTree(root.Left, x - dx / 2, y + 20, dx / 2, max);
                DrawTree(root.Right, x + dx / 2, y + 20, dx / 2, max);
            }
        }

        private void processTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Database.tree == null || Database.tree.Root == null)
                MessageBox.Show("Дерево не создано!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                label1.Text = "Максимальный элемент выделен красным.";
                DrawTree(Database.tree.Root, pictureBox1.Width / 2, 5, pictureBox1.Width / 2, Database.tree.FindMax(Database.tree.Root));
            }    
        }

        private void destroyTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Database.tree == null || Database.tree.Root == null)
                MessageBox.Show("Дерево не создано!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Database.tree.Clear();
                pictureBox1.Image = null;
                label1.Text = "Создайте дерево.";
            }
        }
    }
}
