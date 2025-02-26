namespace GrokkingAlgorithms.BinarySearch.Tests;

public class BinarySearchTests
{
    private static int[] _array = new[] { 12, 22, 35, 41, 57, 62, 77, 87, 91, 99 };

    [Theory]
    [InlineData(12, 0)]
    [InlineData(22, 1)]
    [InlineData(35, 2)]
    [InlineData(41, 3)]
    [InlineData(57, 4)]
    [InlineData(62, 5)]
    [InlineData(77, 6)]
    [InlineData(87, 7)]
    [InlineData(91, 8)]
    [InlineData(99, 9)]
    [InlineData(100, 0)]
    public void Search_ShouldFindItemIndex(int item, int index)
    {
        // Act
        var result = BinarySearch.Search(_array, item);

        // Assert
        Assert.Equal(result, index);
    }
}
