namespace GrokkingAlgorithms.BinarySearch.Tests;

public class BinarySearchTests
{
    private readonly static int[] _array = [12, 22, 35, 41, 57, 62, 77, 87, 91, 99];

    [Fact]
    public void Search_ReturnsMinusOne_WhenArrayIsNull()
    {
        //Arrange 
        int[]? array = null;

        // Act
        var result = BinarySearch.Search(array, default);

        // Assert
        Assert.Equal(-1, result);
    }

    [Fact]
    public void Search_ReturnsMinusOne_WhenArrayIsEmpty()
    {
        //Arrange 
        int[]? array = [];

        // Act
        var result = BinarySearch.Search(array, default);

        // Assert
        Assert.Equal(-1, result);
    }

    [Theory]
    [InlineData(10)]
    [InlineData(100)]
    public void Search_ReturnsMinusOne_WhenItemNotExists(int item)
    {
        // Act
        var result = BinarySearch.Search(_array, item);

        // Assert
        Assert.Equal(-1, result);
    }

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
    public void Search_ReturnsItemIndex(int item, int index)
    {
        // Act
        var result = BinarySearch.Search(_array, item);

        // Assert
        Assert.Equal(index, result);
    }

    [Theory]
    [InlineData("Alice Johnson", 0)]
    [InlineData("Bob Smith", 1)]
    [InlineData("Charlie Brown", 2)]
    [InlineData("Chris Brown", 3)]
    [InlineData("Chris Johnson", 4)]
    public void Search_ReturnsItemIndex_WhenItemIsString(string item, int index)
    {
        // Arrange
        var array = new[] {
            "Alice Johnson",
            "Bob Smith",
            "Charlie Brown",
            "Chris Brown",
            "Chris Johnson" };

        // Act
        var result = BinarySearch.Search(array, item);

        // Assert
        Assert.Equal(index, result);
    }
}
