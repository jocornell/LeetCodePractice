class solution
{
    public static int FirstUniqChar(string s)
    {
        Dictionary<char, int> charFrequencies = new Dictionary<char, int>();
        var chars = s.ToCharArray();

        int i = 0;
        for (int j = 0; j < chars.Length; j++)
        {
            if (!charFrequencies.ContainsKey(chars[j]))
            {
                charFrequencies.Add(chars[j], 1);
            }
            else
            {
                charFrequencies[chars[j]]++;
            }
        }

        for (int j = 0; j < chars.Length; j++)
        {
            if (charFrequencies[chars[j]] == 1)
                return j;
        }

        return -1;
    }
}
