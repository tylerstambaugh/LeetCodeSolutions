namespace LeetCodeSolutions
{
    public class _009PalindromeNumber
    {
        public static bool IsPalindrome( int x)
        {
            bool isPalindrome = true;
            for (int i = 0; i < x.ToString().Length / 2; i++)
            {
                if(x.ToString().Substring(i, 1) != x.ToString().Substring(x.ToString().Length - 1 - i, 1))
                {
                    isPalindrome = false;
                }
            }
            return isPalindrome;
        }

    }
}
