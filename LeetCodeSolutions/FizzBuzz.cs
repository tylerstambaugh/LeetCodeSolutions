namespace LeetCodeSolutions
{
    public static class FizzBuzz
    {
        public static IList<string> FizzBuzzer(int n)
        {
            List<string> returnList = new List<string>();
            string returnString = "";
            for (int i = 1; i <= n; i++)
            {
                returnString = 
                    (i % 3 == 0 && i % 5 == 0) ? "FizzBuzz" :
                    i % 3 == 0 ? "Fizz" :
                    i % 5 == 0 ? "Buzz" :
                    i.ToString();

                returnList.Add(returnString);
            }

            return returnList;
        }
    }
}
