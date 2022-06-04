// Sharipov Kamil 220 Figures-4 30.05

using System.Drawing;

namespace Figures.Core.Figures
{
    public class Circle : Figure
    {
        public int Radius { get; set; }

        public Circle(StrokeData pen, Point p, int radius) : base(pen, p)
        {
            Radius = radius;
        }

        public override void Draw(IDrawer drawer)
        {
            drawer.DrawCircle(Pen, StartingPoint, Radius);
        }
    }
}