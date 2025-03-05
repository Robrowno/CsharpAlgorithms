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

    public static void InsertionSortInt(int[] array)
    {
        int length =  array.Length;
        // [10, 8, 7, 6, 17, 3, 14, 11, 22, 1, 2][10, 8, 7, 6, 17, 3, 14, 11, 22, 1, 2]
        for (int i = 1; i < length; i++)
        {
            int current = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > current)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = current;
        }

    }

    public static void InsertionSort<T>(T[] array) where T : IComparable<T>
    {
        int length = array.Length;

        for (int i = 1; i < length; i++)
        {
            var  current = array[i];
            int j = i - 1;

            while (j >= 0 && array[j].CompareTo(current) > 0)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = current;
        }
    }

    public static void ShellSort(int[] array)
    {

    }

    public static void QuickSortInt(int[] array, int left, int right) // O(n log n) - average, O(n^2) - worst case
    {
        if (left < right)
        {
            int pivot = Utils.PartitionInt(array, left, right);
            QuickSortInt(array, left, pivot - 1);
            QuickSortInt(array, pivot + 1, right);
        }

    }

    public static void QuickSort<T>(T[] array, int left, int right) where T: IComparable<T>
    {
        if (left < right)
        {
            int pivot = Utils.Partition(array, left, right);
            QuickSort(array, left, pivot - 1);
            QuickSort(array, pivot + 1, right);
        }
    }

    public static void MergeSort(int[] array)
    {
        
    }
}