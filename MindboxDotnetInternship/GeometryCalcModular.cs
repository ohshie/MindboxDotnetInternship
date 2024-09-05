using MindboxDotnetInternship.ShapeFactories;
using MindboxDotnetInternship.Shapes;

namespace MindboxDotnetInternship;

public class GeometryCalcModular
{
    public IGeometricShape CreateShape(string shape, double[] parameters)
    {
        IGeometricShape requestedShape = shape.ToLower() switch
        {
            "circle" => new CircleFactory().CreateShape(parameters),
            "triangle" => new TriangleFactory().CreateShape(parameters),
            _ => throw new ArgumentException("Unknown Shape Type")
        };

        return requestedShape;
    }
}
