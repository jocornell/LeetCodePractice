static int MyAtoi(string s)
{

    int res = 0;
    int sign = 1;

    bool foundSign = false, foundDigit = false;

    foreach (var c in s)
    {
        if (!foundSign && !foundDigit && (c == '+' || c == '-'))
        {
            foundSign = true;
            sign = c == '+' ? 1 : -1;
        }
        else if (c >= '0' && c <= '9')
        {
            foundDigit = true;
            if (res == 0 && c == '0')
                continue;
            else if (res > Int32.MaxValue / 10 || (res == Int32.MaxValue / 10 && c - '0' > Int32.MaxValue % 10))
                return sign == 1 ? Int32.MaxValue : Int32.MinValue;
            else
                res = res * 10 + (c - '0');
        }
        else if (c != ' ' || ((foundDigit || foundSign) && c == ' ') || (foundDigit && c == '.'))
            break;
    }

    return res * sign;
}