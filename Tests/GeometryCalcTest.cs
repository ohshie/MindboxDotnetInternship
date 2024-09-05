using MindboxDotnetInternship;

namespace Tests;

public class GeometryCalcTest
{
    [Fact]
    public void GetTriangleArea()
    {
        // Короче, это решение нифига не клевое, но альтернативы выходят за рамки тестового
        // все решения что я вижу предлагают экстеншен/хелпер писать для сравнения.
        
        var expectedAnswer = 43.301270189221931;

        var geoCalc = new GeometryCalc();

        var triangleArea = geoCalc.GetTriangleArea(10,10,10);
        
        Assert.Equal(expectedAnswer, triangleArea);
    }

    [Fact]
    public void GetTriangleAreaLessThanZeroReturnsException()
    {
        var geoCalc = new GeometryCalc();

        // подсмотрел на литкоде, прикольно, но очень криво. Создаю метод внутри метода, как-то ощущается неправильно
        void ExceptionAction() => geoCalc.GetTriangleArea(-1, 0, 0);

        Assert.Throws<ArgumentException>(ExceptionAction);
    }

    [Fact]
    public void GetTriangleAreaTwoSidesLessThanThird()
    {
        var geoCalc = new GeometryCalc();

        void ExceptionAction() => geoCalc.GetTriangleArea(1, 1, 0);

        Assert.Throws<ArgumentException>(ExceptionAction);
    }

    [Fact]
    public void GetCircleArea()
    {
        var expectedAnswer = Math.PI;

        var geoCalc = new GeometryCalc();

        var circleArea = geoCalc.GetCircleArea(1);
        
        Assert.Equal(expectedAnswer, circleArea);
    }
    
    [Fact]
    public void GetCirclAreaZeroRadius()
    {
        var expectedAnswer = 0;
        
        var geoCalc = new GeometryCalc();

        var circleArea = geoCalc.GetCircleArea(0);
        
        Assert.Equal(expectedAnswer, circleArea);
    }

    [Fact]
    public void GetCirclAreaNegativeRadius()
    {
        var geoCalc = new GeometryCalc();

        void ExceptionAction() => geoCalc.GetCircleArea(-1);

        Assert.Throws<ArgumentException>(ExceptionAction);
    }
}