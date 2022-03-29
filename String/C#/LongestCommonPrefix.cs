/*
 * ["flower","flow","flight"]
 * create prefix string (char []) to hold the prefix
 * loop thru strs
 * compare prefix shorten as necessary
 * if prefix is ever empty or has zero els, return empty string.
 * 
 * Time O(n), Space O(1).
 */
static string LongestCommonPrefix(string[] strs)
{
    string prefix = strs[0];
    char[] str;

    for (int j = 1; j < strs.Length; j++)
    {
        str = strs[j].ToCharArray();

        if (str.Length == 0)
            return "";

        for (int i = 0; i < str.Length; i++)
        {

            if (prefix.Length > str.Length)
            {
                prefix = prefix.Remove(str.Length);
            }

            if (i < prefix.Length && prefix[i] != str[i])
            {
                prefix = prefix.Remove(i);

                if (prefix.Length == 0)
                {
                    return "";
                }

                break;
            }
        }
    }

    return prefix;
}