string str1 = "rokib";
string str2 = "rokib";


// Console.WriteLine(IsPermutation(str1, str2));
Console.WriteLine(IsPermutationEfficient(str1, str2));



bool IsPermutation(string str3, string str4)
{
    if (str3.Length != str4.Length) return false;
    // Convert strings to character arrays
    char[] charArray1 = str3.ToCharArray();
    char[] charArray2 = str4.ToCharArray();

    // Sort the character arrays
    Array.Sort(charArray1);
    Array.Sort(charArray2);

    // Convert sorted character arrays back to strings
    string sortedStr3 = new string(charArray1);
    string sortedStr4 = new string(charArray2);

    // Compare the sorted strings
    return sortedStr3.Equals(sortedStr4);

}


bool IsPermutationEfficient(string str1, string str2)
{
    if (str1.Length != str2.Length) return false;

    int[] char_count = new int[128];

    foreach (var s in str1)
    {
        char_count[(int)s]++;
    }

    foreach (var s in str2)
    {
        char_count[(int)s]--;

        if (char_count[(int)s] < 0) return false;
    }

    return true;


}