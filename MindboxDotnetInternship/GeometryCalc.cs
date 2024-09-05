namespace MindboxDotnetInternship;

// Напишите на C# библиотеку для поставки внешним клиентам,
// которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.
// Дополнительно к работоспособности оценим:
//
//      -Юнит-тесты
//     - Легкость добавления других фигур - 
//     - Вычисление площади фигуры без знания типа фигуры в compile-time
//     - Проверку на то, является ли треугольник прямоугольным


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
        if (a < 0 || b < 0 || c < 0)
        {
            throw new ArgumentException("Triangle side should not be less than 0");
        }

        if (a + b <= c || b+c <= a || c+a <=b)
        {
            throw new ArgumentException("Sum of two triangle sides should not be less or equal to the third side");
        }
        
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
}