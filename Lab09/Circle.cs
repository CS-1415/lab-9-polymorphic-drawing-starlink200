using System.CodeDom.Compiler;

namespace Lab09;

public class Circle : AbstractGraphic2D
{
    public int CenterX;
    public int CenterY;
    public decimal Radius;

    public Circle(int x, int y, decimal r)
    {
        CenterX = x;
        CenterY = y;
        Radius = r;
    }
    public override decimal LowerBoundX => CenterX - Radius;
    public override decimal UpperBoundX => CenterX + Radius;

    public override decimal LowerBoundY => CenterY - Radius;

    public override decimal UpperBoundY => CenterY + Radius;

    public override bool ContainsPoint(decimal x, decimal y)
    {
        if(x >= LowerBoundX && x <= UpperBoundX && y >= LowerBoundY && y <= UpperBoundY)
        {
            return true;
        }
        return false;
    }
}