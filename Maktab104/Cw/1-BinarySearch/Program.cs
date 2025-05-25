using _1_BinarySearch;



int[] binarySearch = new int[10];
for (int i = 0; i < binarySearch.Length; i++)
{
    Console.Write($"Input in order to many number for binary search that is inside array in index {i}: ");
    int number = Convert.ToInt32(Console.ReadLine());
    binarySearch[i] = number;
}

Console.Write("Enter a target number: ");
int input = Convert.ToInt32(Console.ReadLine());
int result = Binarysearch.GetBinarySearch(binarySearch, input);

if (result == -1)
{
    Console.WriteLine("not find it.");
}
else
{
    Console.Write($"find it. \nIndex targer is {result}:");
}



