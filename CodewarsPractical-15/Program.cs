static int FindEvenIndex(int[] arr)
{
    int totalSum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        totalSum += arr[i];
    }

    int leftSum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        int rightSum = totalSum - leftSum - arr[i];

        if (leftSum == rightSum)
        {
            return i;
        }

        leftSum += arr[i];
    }

    return -1;
}