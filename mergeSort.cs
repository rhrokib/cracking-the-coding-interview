//  merge sort algorithm both iterative and recursive

int[] arr = { 12, 11, 13, 5, 6, 7 };

MergeSortRecursive(arr, 0, arr.Length - 1);

Console.ReadLine();

foreach (var i in arr)
{
    Console.WriteLine(i);
}



void MergeSortRecursive(int[] arr, int left, int right)
{
    if (left >= right) return;

    int mid = left + (right - left) / 2;

    MergeSortRecursive(arr, left, mid);
    MergeSortRecursive(arr, mid + 1, right);

    Merge(arr, left, right, mid);

}

void Merge(int[] arr, int left, int right, int mid)
{
    int n1 = mid - left + 1;
    int n2 = right - mid;

    int[] leftArray = new int[n1];
    int[] rightArray = new int[n2];

    for (int i = 0; i < n1; i++)
    {
        leftArray[i] = arr[left + i];
    }
    for (int i = 0; i < n2; i++)
    {
        rightArray[i] = arr[mid + 1 + i];
    }

    int lIndex = 0, rIndex = 0;
    int k = left;

    while (lIndex < n1 && rIndex < n2)
    {
        if (leftArray[lIndex] > rightArray[rIndex])
        {
            arr[k] = rightArray[rIndex];
            rIndex++;
        }
        else
        {
            arr[k] = leftArray[lIndex];
            lIndex++;
        }
        k++;
    }

    while (lIndex < n1)
    {
        arr[k] = leftArray[lIndex];
        lIndex++;
        k++;
    }
    while (rIndex < n2)
    {
        arr[k] = rightArray[rIndex];
        rIndex++;
        k++;
    }
}