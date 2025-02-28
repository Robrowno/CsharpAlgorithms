namespace Algorithms;


class Program
{
    static void Main(string[] args)
    {
        int[] nums = [10, 8, 7, 6, 17, 3, 14, 11, 22, 1, 2];
        
        // Sort.BubbleSortInt(nums);
        // Sort.SelectionSort(nums);
        Sort.InsertionSort(nums);
        PrintArray(nums);
        Search.SortedLinearSearch(nums, 12);
        
    }

    
    // Console methods
    private static void PrintArray(int[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }
    
}