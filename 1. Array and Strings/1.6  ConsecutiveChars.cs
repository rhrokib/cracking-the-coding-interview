/*
----------------------------------------------------------------------------------------------------------
String Compression:
Implement a method to perform basic string compression using the counts of repeated characters.
For example, the string aabcccccaaa would become a2blc5a3.
If the "compressed" string would not become smaller than the original string, your method should return 
the original string. You can assume the string has only uppercase and lowercase letters (a - z). 
----------------------------------------------------------------------------------------------------------

*/



string str = "xx0qx1";

Console.WriteLine(LongestPalindrome(str));


string CompressedString(string str)
{
    var compressedLength = CountCompressedLength(str);
    if (compressedLength > str.Length) return str;


    StringBuilder compStr = new StringBuilder(compressedLength);
    int count = 1;

    for (int i = 0; i < str.Length; i++)
    {
        if (i < str.Length - 1 && str[i + 1] == str[i])
        {
            count++;
        }
        else
        {
            compStr.Append(str[i]);
            compStr.Append(count.ToString());

            count = 1;
        }
    }

    return compStr.ToString();
}

int CountCompressedLength(string str)
{
    int length = 0;
    int count = 0;

    for (int i = 0; i < str.Length; i++)
    {
        if (i < str.Length - 1 && str[i + 1] == str[i])
        {
            count++;
        }
        else
        {
            length += 1 + count.ToString().Length;
            count = 0;
        }
    }
    return length;
}

string LongestPalindrome(string s)
{
    string res = "";
    int len = 0;

    for (int i = 0; i < s.Length; i++)
    {
        // odd length
        int l = i, r = i;

        while (l >= 0 && r < s.Length && s[l] == s[r])
        {
            if (r - l + 1 > len)
            {
                res = s.Substring(l, r - l + 1);
                len = r - l + 1;
            }
            l--;
            r++;
        }

        // even length
        l = i;
        r = i + 1;

        while (l >= 0 && r < s.Length && s[l] == s[r])
        {
            if (r - l + 1 > len)
            {
                res = s.Substring(l, r - l + 1);
                len = r - l + 1;
            }
            l--;
            r++;
        }


    }

    return res;
}