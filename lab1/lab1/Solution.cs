using System;
using System.Windows.Forms;

namespace lab1
{
    public partial class Solution : Form
    {
        public Solution()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Palindrome check = new Palindrome();

            try
            {
                int i = Convert.ToInt32(input_i.Text);
                int j = Convert.ToInt32(input_j.Text);

                if (i <= j)
                {
                    outputTextBox.Text = check.IsPalindrome(input_s.Text, i - 1, j - 1).ToString();
                    errLabel.Text = null;
                }
                else
                {
                    outputTextBox.Text = null;
                    errLabel.Text = "i должно быть меньше или равно j";
                }
            }
            catch (FormatException)
            {
                outputTextBox.Text = null;
                errLabel.Text = "i и j должны быть положительными целыми числами";
            }
            catch (IndexOutOfRangeException)
            {
                outputTextBox.Text = null;
                errLabel.Text = "i и j должны быть не больше длины строки";
            }
        }
    }
}
