using MindboxDotnetInternship.Shapes;

namespace MindboxDotnetInternship.ShapeFactories;

public interface IShapeFactory
{
    IGeometricShape CreateShape(double[] parameters);
}