namespace Algorithms;


class Program
{
    static void Main(string[] args)
    {
        int[] nums = [10, 8, 7, 6, 17, 3, 14, 11, 22, 1, 2];
        
        Sort.BubbleSort(nums);
        
        PrintArray(nums);
        
    }

    private static void PrintArray(int[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }
    
}