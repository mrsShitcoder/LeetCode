namespace LeetCode;

//https://leetcode.com/problems/sort-an-array/description/
//Given an array of integers nums, sort the array in ascending order and return it.
//You must solve the problem without using any built-in functions in O(nlog(n)) time complexity
//and with the smallest space complexity possible.

public class MergeSort
{ 
    private static void SortParts(int[] array, int[] tempBuffer, int left, int right)
    {
        if (left >= right)
        {
            return;
        }

        int mid = (left + right) / 2;
        SortParts(array, tempBuffer, left, mid);
        SortParts(array, tempBuffer, mid + 1, right);
        
        int i = left, j = mid + 1, k = left;
        
        while (i <= mid && j <= right)
        {
            if (array[i] < array[j])
            {
                tempBuffer[k] = array[i];
                i++;
            }
            else
            {
                tempBuffer[k] = array[j];
                j++;
            }

            k++;
        }

        while (i <= mid)
        {
            tempBuffer[k] = array[i];
            i++;
            k++;
        }

        while (j <= right)
        {
            tempBuffer[k] = array[j];
            j++;
            k++;
        }

        for (int l = left; l <= right; l++)
        {
            array[l] = tempBuffer[l];
        }
    }

    public static int[] SortArray(int[] array)
    {
        if (array.Length <= 0)
        {
            return array;
        }
        var tempBuffer = new int[array.Length];
        SortParts(array, tempBuffer, 0, array.Length - 1);
        return array;
    }
    
}