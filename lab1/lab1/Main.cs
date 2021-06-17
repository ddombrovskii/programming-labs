using System;
using System.Windows.Forms;

namespace lab1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void aboutProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вариант 15\n\nЗадание: Задана строка S из N символов.Реализуйте рекурсивный алгоритм проверки, является ли симметричной часть строки, начинающаяся i - м и заканчивающаяся j - м ее элементом.\n\nРазработчик: Домбровский Данила Валерьевич, 6104", "О программе");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void taskText_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задана строка S из N символов.Реализуйте рекурсивный алгоритм проверки, является ли симметричной часть строки, начинающаяся i - м и заканчивающаяся j - м ее элементом.", "Условие");
        }

        private void solution_Click(object sender, EventArgs e)
        {
            Solution sol = new Solution();
            sol.ShowDialog();
        }
    }
}
