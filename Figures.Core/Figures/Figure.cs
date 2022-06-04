// Sharipov Kamil 220 Figures-4 30.05

using System.Drawing;

namespace Figures.Core.Figures
{
    public abstract class Figure
    {
        public Point StartingPoint { get; }
        public StrokeData Pen { get; }
        
        protected Figure(StrokeData pen, Point p)
        {
            Pen = pen;
            StartingPoint = p;
        }

        public abstract void Draw(IDrawer drawer);
    }
}
