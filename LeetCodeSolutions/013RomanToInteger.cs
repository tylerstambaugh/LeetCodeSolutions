namespace LeetCodeSolutions
{
    public class _013RomanToInteger
    {
        public int RomanToInt(string s)
        {
            int returnVal = 0;

            Dictionary<char, int> map = new Dictionary<char, int> {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10},
                { 'L', 50},
                { 'C', 100},
                { 'D', 500},
                { 'M', 1000}
            };
            

            if(s.Length == 0)
                return returnVal;

            for(int i = s.Length - 1; i >= 0; i--)
            {
                char currentChar = s[i];
                char nextChar = '\0';

                if(i > 0)
                {
                    nextChar = s[i - 1];
                }

                //need to check if next letter is lower in value to current set of consecutive letters and subtract before moving index -2
                if (nextChar != '\0' && map.ContainsKey(nextChar) && map[nextChar] < map[currentChar])
                {
                    returnVal += map[currentChar] - map[nextChar];
                    i--;
                }
                else
                {
                    returnVal += map[currentChar];
                }
            }

            return returnVal;
        }
    }
}

//Symbol Value
//I             1
//V             5
//X             10
//L             50
//C             100
//D             500
//M             1000