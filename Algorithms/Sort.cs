namespace Algorithms;

public class Sort
{
    public static void BubbleSortInt(int[] array) // O(n^2)
    {
        bool swapped;
        int length = array.Length - 1; // 0-indexing

        for (int i = 0; i < length; i++) // count for the number of passes
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
            
            if (!swapped) // break out of outer for-loop if no swaps made in a passage 
            {
                break;
            }
        }
    }

    public static void BubbleSortStr(string[] array)
    {
        bool swapped;
        int length = array.Length - 1;

        for (int i = 0; i < length; i++)
        {
            swapped = false;

            for (int j = 0; j < length - i; j++)
            {
                if (String.CompareOrdinal(array[j], array[j + 1]) > 0)
                {
                    string temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    swapped = true;
                }
            }

            if (!swapped)
            {
                break;
            }
        }
    }

    public static void BubbleSort<T>(T[] array) where T : IComparable<T> // versatile Bubblesort algorithm
    {
        bool swapped;
        int length = array.Length - 1;

        for (int i = 0; i < length; i++)
        {
            swapped = false;

            for (int j = 0; j < length - i; j++)
            {
                if (array[j].CompareTo(array[j + 1]) > 0)
                {
                    T temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    swapped = true;
                }
            }

            if (!swapped)
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