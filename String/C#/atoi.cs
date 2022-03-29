// LeetCode: String to Integer (atoi)
// Convert string to 32-bit signed integer.

// Time: O(n), Space O(1)
static int MyAtoi(string s)
{
    int result = 0;
    int sign = 1;

    bool foundSign = false, foundDigit = false;

    foreach (var c in s)
    {
        if (!foundSign && !foundDigit &&(c == '+' || c == '-'))
        {
            foundSign = true;
            sign = c == '+' ? 1 : -1;
        }
        else if (c >= '0' && c <= '9')
        {
            foundDigit = true;            
            if (result == 0 && c == '0')
                continue;
            else if (result > Int32.MaxValue / 10 || (result == Int32.MaxValue / 10 && c - '0' > Int32.MaxValue % 10))
                return sign == 1 ? Int32.MaxValue : Int32.MinValue;
            else
                result = result * 10 + (c - '0');
        }
        else if (c != ' ' || ((foundDigit || foundSign) && c == ' ') || (foundDigit && c == '.'))
            break;
    }

    return result * sign;
}