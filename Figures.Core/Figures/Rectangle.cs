// Sharipov Kamil 220 Figures-4 30.05

using System.Drawing;

namespace Figures.Core.Figures
{
    public class Rectangle : Figure
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(StrokeData pen, Point p, int width, int height)
            : base(pen, p)
        {
            Height = height;
            Width = width;
        }

        public override void Draw(IDrawer drawer)
        {
            drawer.DrawRectangle(Pen, StartingPoint, Width, Height);
        }
    }
}