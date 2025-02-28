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

    public static void SelectionSortInt(int[] array) // O(n^2)
    {
        
        int length = array.Length;

        for (int i = 0; i < length - 1; i++)
        {
            int smallestIndex = i;
            
            for (int j = i+1; j < length; j++)
            {
                if (array[smallestIndex] > array[j])
                {
                    smallestIndex =  j;
                }
            }

            if (smallestIndex != i)
            {
                int temp = array[i];
                array[i] = array[smallestIndex];
                array[smallestIndex] = temp;
            }
        }
    }

    public static void SelectionSort<T>(T[] array) where T : IComparable<T> // O(n^2)
    {
        int length = array.Length;

        for (int i = 0; i < length - 1; i++)
        {
            int smallestIndex = i;

            for (int j = i+1; j < length; j++)
            {
                if (array[j].CompareTo(array[smallestIndex]) < 0)
                {
                    smallestIndex = j;
                }
            }

            if (smallestIndex != i)
            {
                var temp = array[i];
                array[i] = array[smallestIndex];
                array[smallestIndex] = temp;
            }
        }
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