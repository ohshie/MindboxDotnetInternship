using MindboxDotnetInternship.Shapes;

namespace MindboxDotnetInternship.ShapeFactories;

public class TriangleFactory : IShapeFactory
{
    public IGeometricShape CreateShape(double[] parameters)
    {
        if (parameters.Length != 3)
        {
            throw new ArgumentException("Triangle should have only 3 sides");
        }
        
        if (parameters[0] < 0 || parameters[1] < 0 || parameters[2] < 0)
        {
            throw new ArgumentException("Triangle side should not be less than 0");
        }

        if (parameters[0] + parameters[1] <= parameters[2] 
            || parameters[1] + parameters[2] <= parameters[0] 
            || parameters[0] + parameters[2] <= parameters[1])
        {
            throw new ArgumentException("Sum of two triangle sides should not be less or equal to the third side");
        }

        return new Triangle(parameters[0], parameters[1], parameters[2]);
    }
}