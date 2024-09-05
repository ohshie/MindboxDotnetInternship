using MindboxDotnetInternship.Shapes;

namespace MindboxDotnetInternship.ShapeFactories;

public class CircleFactory : IShapeFactory
{
    public IGeometricShape CreateShape(double[] parameters)
    {
        if (parameters.Length != 1)
        {
            throw new ArgumentException("You can only create circle with 1 parameter");
        }

        if (parameters[0] < 0)
        {
            throw new AggregateException("Circle Radius should be more than 0");
        }

        return new Circle(parameters[0]);
    }
}