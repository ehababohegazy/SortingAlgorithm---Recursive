using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Diagnostics;

public static class MergeSort
{
    public static void Sort(int[] arr, int l, int r)
    {
        if (l < r)
        {
            int m = (l + r) / 2;

            Sort(arr, l, m);
            Sort(arr, m + 1, r);

            Merge(arr, l, m, r);
        }
    }

    private static void Merge(int[] arr, int l, int m, int r)
    {
        int n1 = m - l + 1;
        int n2 = r - m;

        int[] leftArr = new int[n1];
        int[] rightArr = new int[n2];

        for (int i = 0; i < n1; ++i)
            leftArr[i] = arr[l + i];
        for (int j = 0; j < n2; ++j)
            rightArr[j] = arr[m + 1 + j];

        int k = l;
        int i1 = 0, i2 = 0;

        while (i1 < n1 && i2 < n2)
        {
            if (leftArr[i1] <= rightArr[i2])
            {
                arr[k] = leftArr[i1];
                i1++;
            }
            else
            {
                arr[k] = rightArr[i2];
                i2++;
            }
            k++;
        }

        while (i1 < n1)
        {
            arr[k] = leftArr[i1];
            i1++;
            k++;
        }

        while (i2 < n2)
        {
            arr[k] = rightArr[i2];
            i2++;
            k++;
        }
    }

    private static void PrintArray(int[] arr)
    {
        foreach (int i in arr)
            Debug.Write("{0} ", i);
        Debug.WriteLine("");
    }
}
