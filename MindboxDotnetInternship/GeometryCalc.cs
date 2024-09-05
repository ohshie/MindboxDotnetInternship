namespace MindboxDotnetInternship;

// Напишите на C# библиотеку для поставки внешним клиентам,
// которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.
// Дополнительно к работоспособности оценим:
//
//      -Юнит-тесты - Check
//     - Легкость добавления других фигур - Check
//     - Вычисление площади фигуры без знания типа фигуры в compile-time - Check 
//     - Проверку на то, является ли треугольник прямоугольным - Check



/// <summary>
/// Simplest way of implementing this library
/// </summary>
public class GeometryCalc
{
    /// <summary>
    /// Calculates Triangle Area from provided sides lengths. All lengths should be equal or more than 0.
    /// Sum of 2 of any sides should be more or equal than third side.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    /// <returns>Triangle Area</returns>
    /// <exception cref="ArgumentException"></exception>
    public double GetTriangleArea(double a, double b, double c)
    {
        SafetyChecks(a, b, c);
        
        var semiperimeter = (a+b+c) / 2;

        var answer = Math.Sqrt(semiperimeter * (semiperimeter - a)* (semiperimeter - b) * (semiperimeter - c));
        
        return answer;
    }

    /// <summary>
    /// Calculates Circle Area from provided Circle radius.
    /// Radius should not be less than 0
    /// </summary>
    /// <param name="radius"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public double GetCircleArea(double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentException("Radius should not be less than 0");
        }
        var answer = Math.PI * Math.Pow(radius, 2);

        return answer;
    }

    /// <summary>
    /// Performs a math check if provided Triangle sides can be of Right Sided Triangle
    /// All lengths should be equal or more than 0.
    /// Sum of 2 of any sides should be more or equal than third side.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    /// <returns></returns>
    public bool IsRight(double a, double b, double c)
    {
        SafetyChecks(a, b, c);

        var orderedSides = new[] { a, b, c }.OrderBy(x => x).ToArray();

        // Это решение такое неправильное, но оно работа. Хотя мс говорят так не делать. Но вы знали что вы, делали!
        var answer = Math.Abs(Math.Pow(orderedSides[0], 2) + Math.Pow(orderedSides[1], 2) - Math.Pow(orderedSides[2], 2)) < Double.E; 

        return answer;
    }

    private void SafetyChecks(double a, double b, double c)
    {
        if (a < 0 || b < 0 || c < 0)
        {
            throw new ArgumentException("Triangle side should not be less than 0");
        }

        if (a + b <= c || b+c <= a || c+a <=b)
        {
            throw new ArgumentException("Sum of two triangle sides should not be less or equal to the third side");
        }
    }
    
}