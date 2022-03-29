/// <summary>
/// Loop through the haystack checking for first char in needle.
/// If you find the char, then use two pointers and try to match needle.
/// If there are no valid matches or you never find any chars return -1
/// </summary>
static int StrStr(string haystack, string needle)
{
    if (haystack == string.Empty && needle == string.Empty)
    {
        return 0;
    }
    else if (needle == string.Empty)
        return 0;
    else if (needle.Length > haystack.Length)
        return -1;

    bool isNeedleInHaystack = false;
    int index = 0;

    for (int i = 0; i < haystack.Length; i++)
    {
        if (haystack[i] == needle[0])
        {
            isNeedleInHaystack = true;
            index = i;

            int l = 0;
            int m = needle.Length - 1;

            for (int j = i, k = i + needle.Length - 1; j <= k; j++, k--)
            {
                if (k > haystack.Length - 1)
                {
                    isNeedleInHaystack = false;
                    break;
                }

                if (!(haystack[j] == needle[l]) || !(haystack[k] == needle[m]))
                {
                    isNeedleInHaystack = false;
                    break;
                }
                l++;
                m--;
            }

            if (isNeedleInHaystack == true)
                return index;
        }
    }

    return -1;
}


        //public statinc int StrStr(string haystack, string needle)
        //{
        //    for (var i = 0; i <= haystack.Length - needle.Length; i++)
        //    {
        //        int j = 0;
        //        for (j = 0; j < needle.Length; j++)
        //        {
        //            if (haystack[i + j] == needle[j]) continue;
        //            break;
        //        }
        //        if (j == needle.Length) return i;
        //    }

        //    return -1;
        //}