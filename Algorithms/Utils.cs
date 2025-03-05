namespace Algorithms;

public class Utils
{

    public static int PartitionInt(int[] array, int low, int high)
    {
        int pivot = array[high]; // select last element as the pivot
        int i = low - 1; //pointer for smaller elements

        for (int j = low; j < high; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
        // move the pivot to i + 1 (i is the position of the last element smaller thant he pivot)
        int temp2 = array[i + 1];
        array[i + 1] = array[high];
        array[high] = temp2;
        // 
        return i + 1;
    }

    public static int Partition<T>(T[] array, int low, int high) where  T : IComparable<T>
    {
        T pivot = array[high]; // element at the end of the array (the pivot)
        int i = low - 1; // (init to low - 1 before lowest element is found)
        
        for (int j = low; j < high; j++)
        {
            if (array[j].CompareTo(pivot) < 0) // if array[j] > than the pivot
            {
                i++; // increment i and swap the curr element with the smallest
                T temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
        // place the pivot at i + 1 so it is sandwiched between elements smaller than the pivot on the left
        // and elements larger than the pivot on the right
        T temp2 = array[i+1];
        array[i+1] = array[high];
        array[high] = temp2;
        
        return i + 1; // return the index of pivot
    }

    public static void QuickSortHelperInt(int[] array)
    {
        Sort.QuickSortInt(array, 0, array.Length - 1);
    }

    public static void QuickSortHelper<T>(T[] array) where T : IComparable<T>
    {
        Sort.QuickSort(array, 0, array.Length - 1);
    }
}