namespace GrokkingAlgorithms.BinarySearch;

public static class BinarySearch
{
    public static int Search(int[] array, int item)
    {
        // low and high track the part of the list you are looking for.
        var low = 0;
        var high = array.Length - 1;

        // while still unable to arrive at a single element
        while (low <= high)
        {
            // find the middle element
            var mid = (low + high) / 2;
            var guess = array[mid];

            // checks if the central element is the searched element
            if (guess == item)
            {
                return mid;
            }

            // guess was high
            if (guess > item)
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

        return default;
    }
}
