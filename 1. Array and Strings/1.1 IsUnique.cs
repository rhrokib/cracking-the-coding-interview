


string str = "abcdefga";
Console.WriteLine(IsUnique(str));
Console.ReadLine();




bool IsUnique(string str)
{
    if (str.Length > 128)
    {
        return false;
    }

    bool[] char_set = new bool[128];
    for (int i = 0; i < str.Length; i++)
    {
        int val = str[i];
        if (char_set[val])
        {
            return false;
        }
        char_set[val] = true;
    }
    return true;
}
