namespace Algorithms;

public class Sort
{
    public static void BubbleSort(int[] array)
    {
        bool swapped;
        int length = array.Length - 1; // 0-indexing

        for (int i = 0; i < length; i++)
        {
            swapped = false;
            
            for (int j = 0; j < length - i; j++) // compare adjacent elements
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    swapped = true;
                }
            }
            
            if (!swapped) // stop if no swaps made in a passage 
            {
                break;
            }
        }
    
    }

    public static void SelectionSort(int[] array)
    {

    }

    public static void InsertionSort(int[] array)
    {

    }

    public static void ShellSort(int[] array)
    {

    }

    public static void QuickSort(int[] array)
    {

    }
}