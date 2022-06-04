using Figures.Core;
using System.Drawing;

namespace Figures.Winforms
{
    class WinformsDrawer : IDrawer
    {
        private readonly Graphics _graphics;

        public WinformsDrawer(Graphics g)
        {
            _graphics = g;
        }

        public void DrawCircle(StrokeData pen, Point basePoint, int radius)
        {
            _graphics.DrawEllipse(StrokeDataToPen(pen), basePoint.X - radius,
                basePoint.Y - radius, radius * 2, radius * 2);
        }

        public void DrawLine(StrokeData pen, Point basePoint, Point secondPoint)
        {
            _graphics.DrawLine(StrokeDataToPen(pen), basePoint, secondPoint);
        }

        public void DrawRectangle(StrokeData pen, Point basePoint, int width,
            int height)
        {
            _graphics.DrawRectangle(StrokeDataToPen(pen), basePoint.X,
                basePoint.Y, width, height);
        }

        public void DrawTriangle(StrokeData pen, Point a, Point b, Point c)
        {
            _graphics.DrawPolygon(StrokeDataToPen(pen), new[] { a, b, c });
        }

        private static Pen StrokeDataToPen(StrokeData stroke)
        {
            return new Pen(stroke.Color, stroke.Width);
        }
    }
}