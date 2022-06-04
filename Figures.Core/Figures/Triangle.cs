// Sharipov Kamil 220 Figures-3 22.05

using System.Drawing;

namespace Figures.Core.Figures
{
    public class Triangle : Figure
    {
        public Point P2;
        public Point P3;

        public Triangle(StrokeData pen, Point p1, Point p2, Point p3)
            : base(pen, p1)
        {
            P2 = p2;
            P3 = p3;
        }

        public override void Draw(IDrawer drawer)
        {
            drawer.DrawTriangle(Pen, StartingPoint, P2, P3);
        }
    }
}