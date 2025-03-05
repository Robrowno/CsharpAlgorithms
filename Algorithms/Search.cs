namespace Algorithms;

public class Search
{
    public static void LinearSearch(int[] array, int target) // O(n)
    {
        int length = array.Length;

        for (int i = 0; i < length; i++)
        {
            if (array[i] == target)
            {
                Console.WriteLine($"Target {target} found at index {i}");
                return;
            }
        }

        Console.WriteLine($"Target {target} NOT found at in the array");
        
    }

    public static void SortedLinearSearch(int[] array, int target) // 0(n)
    {
        int length = array.Length;

        for (int i = 0; i < length; i++)
        {
            if (array[i] == target)
            {
                Console.WriteLine($"Target {target} found at index {i}");
                return;
            }

            if (array[i] > target)
            {
                Console.WriteLine($"Exited loop at index {i}.");
                Console.WriteLine($"Target {target} not in the array");
                return;
            }
        }
    }

    public static void BinarySearch(int[] array, int target) // O(log n)
    {

    }

    public static void InterpolationSearch(int[] array, int target)
    {
        
    }

    public static void JumpSearch(int[] array, int target)
    {
        
    }
}