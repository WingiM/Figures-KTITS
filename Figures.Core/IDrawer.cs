using System.Drawing;

namespace Figures.Core
{
    public interface IDrawer
    {
        public void DrawRectangle(StrokeData pen, Point basePoint, int width,
            int height);

        public void DrawTriangle(StrokeData pen, Point a, Point b, Point c);

        public void DrawLine(StrokeData pen, Point basePoint,
            Point secondPoint);

        public void DrawCircle(StrokeData pen, Point basePoint, int radius);
    }
}