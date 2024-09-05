using MindboxDotnetInternship;
using MindboxDotnetInternship.Shapes;

namespace Tests;

public class GeometryCalcModularTest
{
    [Fact]
    public void GetTriangleArea()
    {
        var expectedAnswer = 43.301270189221931;
        
        var triangle = new GeometryCalcModular().CreateShape("triangle", [10,10,10]);

        var triangleArea = triangle.GetArea();
        
        Assert.Equal(expectedAnswer, triangleArea);
    }
    
    [Fact]
    public void GetTriangleAreaLessThanZeroReturnsException()
    {
        void ExceptionAction() => new GeometryCalcModular().CreateShape("triangle", [-1,10,10]);

        Assert.Throws<ArgumentException>(ExceptionAction);
    }
    
    [Fact]
    public void GetTriangleAreaTwoSidesLessThanThird()
    {
        void ExceptionAction() => new GeometryCalcModular().CreateShape("triangle", [1,1,0]);

        Assert.Throws<ArgumentException>(ExceptionAction);
    }
    
    [Fact]
    public void GetCircleArea()
    {
        var expectedAnswer = Math.PI;

        var circle = new GeometryCalcModular().CreateShape("circle", [1]);

        var circleArea = circle.GetArea();
        
        Assert.Equal(expectedAnswer, circleArea);
    }
    
    [Fact]
    public void IsRight()
    {
        var requestedShape = new GeometryCalcModular().CreateShape("triangle", [1, 1, 1]);
        
        Assert.True(requestedShape is Triangle);
        
        var triangle = requestedShape as Triangle;
        
        Assert.True(triangle.IsRight());
    }
}