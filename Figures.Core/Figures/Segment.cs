// Sharipov Kamil 220 Figures-4 30.05

using System.Drawing;

namespace Figures.Core.Figures
{
    public class Segment : Figure
    {
        public Point EndingPoint { get; set; }

        public Segment(StrokeData pen, Point p1, Point p2) : base(pen, p1)
        {
            EndingPoint = p2;
        }

        public override void Draw(IDrawer drawer)
        {
            drawer.DrawLine(Pen, StartingPoint, EndingPoint);
        }
    }
}