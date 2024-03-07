namespace LeetCodeSolutions
{
    public class RansomNotes
    {
        public Dictionary<char, int> LettersInNote = new Dictionary<char, int>();
        public Dictionary<char, int> LettersInMagazine = new Dictionary<char, int>();


        public bool RansomNote(string ransomNote, string magazine)
        {
            foreach (char c in magazine)
            {
                if (char.IsLetter(c))
                {
                    if (LettersInMagazine.ContainsKey(c))
                    {
                        LettersInMagazine[c]++;
                    }
                    else
                    {
                        LettersInMagazine[c] = 1;
                    }
                }
            }

            foreach(char c in ransomNote)
            {
                if(!LettersInMagazine.ContainsKey(c) || LettersInMagazine[c] == 0)
                {
                    return false;
                }
                LettersInMagazine[c]--;
            }

            return true;
        }
    }
}
