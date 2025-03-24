namespace GrokkingAlgorithms.BinarySearch;

public static class BinarySearch
{
    public static int Search<T>(T[] array, T item) where T : IComparable<T>
    {
        // validate array size
        if (array is null || array.Length == 0)
            return -1;

        // low and high track the part of the list you are looking for.
        var low = 0;
        var high = array.Length - 1;

        // while still unable to arrive at a single element
        while (low <= high)
        {
            // find the middle element
            var mid = low + (high - low) / 2; //Prevents overflow
            var guess = array[mid];
            
            var comparison = guess.CompareTo(item);
            // checks if the central element is the searched element
            if (comparison == 0)
            {
                return mid;
            }

            // guess was high
            if (comparison > 0)
            {
                // update high to before mid
                high = mid - 1;
            }
            // guess was low
            else
            {
                // update low to after mid
                low = mid + 1;
            }
        }

        return -1;
    }
}
