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
            int lastCloseCurlyIndex = -1;

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
                    lastOpenCurlyIndex = i;

                }
            }

            if(               
                openParens == closedParens && 
                openBrackets == closeBrackets &&
                openParens == closedParens &&
                lastOpenParenIndex < lastClosedParenIndex &&
                lastOpenBracketIndex < lastClosedBracketIndex &&
                lastOpenCurlyIndex < lastCloseCurlyIndex)
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
