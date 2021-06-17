namespace lab1
{
    class Palindrome
    { 
        public bool IsPalindrome(string s, int i, int j)
        {
            bool result;

            if (i < j)
            {
                if (s[i] != s[j])
                    result = false;
                else
                    result = IsPalindrome(s, i + 1, j - 1);
            }
            else
                result = true;

            return result;
        }
    }
}
