// See https://aka.ms/new-console-template for more information

using LeetCode;

class Program
{
    public static void PrintArray(int[] array)
    {
        foreach(var element in array)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine();
    }

    public static void Main()
    {
        Console.Write("Original: ");
        int[] array = new int[]{5,2,3,1};
        PrintArray(array);

        var sorted = MergeSort.SortArray(array);
        Console.Write("Sorted: ");
        PrintArray(sorted);
    }
}


