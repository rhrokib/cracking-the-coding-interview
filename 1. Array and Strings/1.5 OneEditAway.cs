string str = "pale";

string[] options = ["ale", "paled", "pal", "ple", "bae", "plea"];

foreach (var word in options)
{
    Console.WriteLine($"{word}: {IsOneEditAway(str, word)}");
}

bool IsOneEditAway(string source, string target)
{
    if (source.Length == target.Length)
    {
        return IsOneEditReplace(source, target);
    }
    if (source.Length - 1 == target.Length)
    {
        return IsOneEditInsert(target, source);
    }
    if (source.Length == target.Length - 1)
    {
        return IsOneEditInsert(source, target);
    }

    return false;
}

bool IsOneEditReplace(string str1, string str2)
{
    bool flag = false;

    for (int i = 0; i < str1.Length; i++)
    {
        if (str1[i] != str2[i])
        {
            if (flag) return false;
            flag = true;
        }
    }
    return true;
}

bool IsOneEditInsert(string str1, string str2)
{
    int index1 = 0, index2 = 0;

    while (index1 < str1.Length && index2 < str2.Length)
    {
        if (str1[index1] != str2[index2])
        {
            if (index1 != index2) return false;
            index2++;
        }
        else
        {
            index1++;
            index2++;
        }
    }
    return true;
}

