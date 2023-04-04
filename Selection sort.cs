using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Diagnostics;

public static class SelectionSort
{
    public static void Sort(int[] arr, int l, int r)
    {
        if (l < r)
        {
            int minIndex = l;

            for (int j = l + 1; j <= r; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            Swap(arr, l, minIndex);
            Sort(arr, l + 1, r);
        }
    }

    private static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    private static void PrintArray(int[] arr)
    {
        foreach (int i in arr)
            Debug.Write("{0} ", i);
        Debug.WriteLine("");
    }
}
