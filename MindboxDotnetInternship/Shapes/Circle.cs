namespace MindboxDotnetInternship.Shapes;

public class Circle(double radius) : IGeometricShape
{
    public double GetArea()
    {
        var answer = Math.PI * Math.Pow(radius, 2);

        return answer;
    }
}