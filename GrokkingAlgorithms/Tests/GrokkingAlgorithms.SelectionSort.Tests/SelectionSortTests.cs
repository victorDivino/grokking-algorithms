namespace GrokkingAlgorithms.SelectionSort.Tests;

public class SelectionSortTests
{
    [Fact]
    public void Sort_ShouldReturnsExpected()
    {
        //Arrange
        var array = new[] { 2, 3, 1 };
        var excpectedSort = new[] { 1, 2, 3 };

        //Act
        SelectionSort.Sort(array);

        //Assert
        Assert.Equal(excpectedSort, array);
    }
}