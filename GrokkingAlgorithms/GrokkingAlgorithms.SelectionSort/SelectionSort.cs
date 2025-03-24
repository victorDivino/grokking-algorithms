namespace GrokkingAlgorithms.SelectionSort;

public static class SelectionSort
{
    /// <summary>
    /// Sorts an array using the Selection Sort algorithm.
    /// This method works with any type that implements IComparable<T>.
    /// </summary>
    /// <typeparam name="T">The type of elements in the array.</typeparam>
    /// <param name="array">The array to be sorted.</param>
    public static void Sort<T>(T[] array) where T : IComparable<T>
    {
        var n = array.Length;

        // Iterate through the array
        for (var current = 0; current < n - 1; current++)
        {
            var min = current;

            // Find the index of the smallest element in the remaining unsorted portion
            for (var next = current + 1; next < n; next++)
            {
                if (array[next].CompareTo(array[min]) < 0)
                {
                    min = next;
                }
            }

            // Swap the found minimum element with the first element of the unsorted portion
            if (min != current)
            {
                (array[current], array[min]) = (array[min], array[current]);
            }

        }
    }
}
