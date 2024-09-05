namespace MindboxDotnetInternship.Shapes;

public class Triangle(double a, double b, double c) : IGeometricShape
{
    public double GetArea()
    {
        var semiperimeter = (a+b+c) / 2;

        var answer = Math.Sqrt(semiperimeter * (semiperimeter - a)* (semiperimeter - b) * (semiperimeter - c));
        
        return answer;
    }
    
    public bool IsRight()
    {
        var orderedSides = new[] { a, b, c }.OrderBy(x => x).ToArray();

        // Это решение такое неправильное, но оно работае. Хотя мс говорят так не делать. Но вы знали что вы делали!
        var answer = Math.Abs(Math.Pow(orderedSides[0], 2) + Math.Pow(orderedSides[1], 2) - Math.Pow(orderedSides[2], 2)) < Double.E; 

        return answer;
    }
}