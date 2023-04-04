using System;

static void Main(string[] args)
{
    int[] arr = { 100, 80, 15, 25, 10 };

    Console.WriteLine("Original array:");
    PrintArray(arr);

    // Call the appropriate method from each sorting class
    MergeSort.Sort(arr, 0, arr.Length - 1);
    SelectionSort.Sort(arr, 0, arr.Length - 1);
    BubbleSort.Sort(arr);

    Console.WriteLine("Sorted array:");
    PrintArray(arr);
}
