namespace LeetCodeSolutions
{
    public class _014LongestCommonPrefix
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            string returnString = string.Empty;
            int shortestStringLength = strs[0].Length;
            foreach(var str in strs)
            {
                if(str.Length == 0) return returnString;
                if (str.Length < shortestStringLength)
                {
                    shortestStringLength = str.Length;
                }
            }  
            
            if(strs.Length == 1)
            {
                return strs[0];
            }

            string currentChar = strs[0].Substring(0, 1); 
            bool samePrefix = true;

            for (int i = 0; i <= shortestStringLength - 1; i ++)
            {
                for(int j = 0; j <= strs.Length - 2; j++)
                {
                    currentChar = strs[j].Substring(i, 1);
                    if (strs[j].Substring(i, 1) != strs[j + 1].Substring(i, 1))
                        samePrefix = false;
                }
                if (samePrefix)
                    returnString += currentChar;
                else return returnString;
            }

            return returnString;
        }

    }
}
