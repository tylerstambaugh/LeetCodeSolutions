namespace LeetCodeSolutions
{
    public class _020ValidParentheses
    {
        public static bool IsValid(string s)
        {            
            int openParens = -1;
            int lastOpenParenIndex = -1;
            int closedParens = -1;
            int lastClosedParenIndex = -1;
            int openBrackets = -1;
            int lastOpenBracketIndex = -1;
            int closeBrackets = -1;
            int lastClosedBracketIndex = -1;
            int openCurlys = -1;
            int lastOpenCurlyIndex = -1;
            int closeCurlys = -1;
            int lastClosedCurlyIndex = -1;

            for (int i = 0; i < s.Length; i++)
            {

                if (s[i] == '(')
                {
                    openParens++;
                    lastOpenParenIndex = i;
                }

                if (s[i] == ')')
                {
                    closedParens++;
                    lastClosedParenIndex = i;
                }

                if (s[i] == '[')
                {
                    openBrackets++;
                    lastOpenBracketIndex = i;
                }

                if (s[i] == ']')
                {
                    closeBrackets++;
                    lastClosedBracketIndex = i;
                }

                if (s[i] == '{')
                {
                    openCurlys++;
                    lastOpenCurlyIndex = i;
                }

                if (s[i] == '}')
                {
                    closeCurlys++;
                    lastClosedCurlyIndex = i;

                }
            }

            


            if(         
               ((openParens == -1 && closedParens == -1) || (openParens == closedParens)) &&
                ((openBrackets == -1 && closeBrackets == -1) || (openBrackets == closeBrackets)) &&
                ((openCurlys == -1 && closeCurlys == -1) || (openCurlys == closeCurlys)) &&
                ((lastOpenParenIndex == -1 && lastClosedParenIndex == -1) || (lastOpenParenIndex < lastClosedParenIndex)) &&
                ((lastOpenBracketIndex == -1 && lastClosedBracketIndex == -1) || (lastOpenBracketIndex < lastClosedBracketIndex)) &&
                ((lastOpenCurlyIndex == -1 && lastClosedCurlyIndex == -1) || (lastOpenCurlyIndex < lastClosedCurlyIndex)))
            {
                return true;
            }

            else
            {
            return false;
            }            
        }
    }
}
