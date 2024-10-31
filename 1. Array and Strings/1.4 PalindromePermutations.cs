string str = "madam";

// Console.WriteLine(IsPermutationOfPalindrome(str));
Console.WriteLine(MyAtoi("   -42"));



bool IsPermutationOfPalindrome(string str)
{
    Dictionary<char, int> charMap = new();

    foreach (var s in str)
    {
        if (s == ' ') continue;

        if (charMap.ContainsKey(s))
        {
            charMap[s]++;
        }
        else
        {
            charMap[s] = 1;
        }
    }

    int oddCount = 0;
    foreach (var count in charMap.Values)
    {
        if (count % 2 != 0) oddCount++;
        if (oddCount > 1) return false;
    }

    return true;
}

int MyAtoi(string s)
{
    int num = 0;
    int sign = 1;
    s = s.Trim();
    if (s.Length == 0) return 0;

    if (s[0] == '-') sign = -1;

    foreach (var ch in s)
    {
        if (num == 0 && ch == '-')
        {
            continue;
        }
        else break;


        if (ch >= '0' && ch <= '9')
        {
            num = num * 10 + (ch - '0');
        }
        else break;

    }


    return num * sign;
}
