using MindboxDotnetInternship;

namespace Tests;

public class GeometryCalcTest
{
    [Fact]
    public void GetSquareAreaReturnsZero()
    {
        var expectedAnswer = 0d;
        
        var geoCalc = new GeometryCalc();

        var squareArea = geoCalc.GetSquareArea();
        
        Assert.Equal(squareArea, expectedAnswer);
    }
}