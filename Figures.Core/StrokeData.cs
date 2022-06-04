using System.Drawing;

namespace Figures.Core
{
    public struct StrokeData
    {
        public int Width;
        public Color Color;

        public StrokeData(Color color, int width)
        {
            Color = color;
            Width = width;
        }
    }
}