// Sharipov Kamil 220 Figures-4 30.05

using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Figures.Core.Figures;
using Rectangle = Figures.Core.Figures.Rectangle;

namespace Figures.Core
{
    public class FigureController
    {
        private readonly List<Figure> _figures;

        public FigureController()
        {
            _figures = new();
        }

        public FigureController(string fileLocation) : this()
        {
            Load(fileLocation);
        }

        public void Add(Figure figure)
        {
            _figures.Add(figure);
        }

        public void Clear()
        {
            _figures.Clear();
        }

        public void PopBack()
        {
            if (_figures.Count != 0)
                _figures.RemoveAt(_figures.Count - 1);
        }

        public void Draw(IDrawer drawer)
        {
            foreach (var figure in _figures)
            {
                figure.Draw(drawer);
            }
        }

        public void Load(string fileLocation)
        {
            _figures.Clear();
            using BinaryReader br = new BinaryReader(new
                FileStream(fileLocation, FileMode.Open));
            int count = br.ReadInt32();
            for (int i = 0; i < count; i++)
            {
                string figureName = br.ReadString();
                Point startingPoint = new Point(br.ReadInt32(),
                    br.ReadInt32());
                StrokeData pen = new StrokeData(
                    Color.FromArgb(br.ReadByte(), br.ReadByte(), br.ReadByte()),
                    br.ReadInt32());
                switch (figureName)
                {
                    case "Triangle":
                        _figures.Add(new Triangle(pen, startingPoint,
                            new Point(br.ReadInt32(), br.ReadInt32()),
                            new Point(br.ReadInt32(), br.ReadInt32())));
                        break;
                    case "Segment":
                        _figures.Add(new Segment(pen, startingPoint,
                            new Point(br.ReadInt32(), br.ReadInt32())));
                        break;
                    case "Rectangle":
                        _figures.Add(new Rectangle(pen, startingPoint,
                            br.ReadInt32(), br.ReadInt32()));
                        break;
                    case "Circle":
                        _figures.Add(new Circle(pen, startingPoint,
                            br.ReadInt32()));
                        break;
                }
            }
        }

        public void Save(string fileLocation)
        {
            using BinaryWriter bw = new BinaryWriter(new
                FileStream(fileLocation, FileMode.Create, FileAccess.Write));
            bw.Write(_figures.Count);
            foreach (var f in _figures)
            {
                bw.Write(f.GetType().Name);
                bw.Write(f.StartingPoint.X);
                bw.Write(f.StartingPoint.Y);
                bw.Write(f.Pen.Color.R);
                bw.Write(f.Pen.Color.G);
                bw.Write(f.Pen.Color.B);
                bw.Write(f.Pen.Width);
                switch (f)
                {
                    case Triangle t:
                        bw.Write(t.P2.X);
                        bw.Write(t.P2.Y);
                        bw.Write(t.P3.X);
                        bw.Write(t.P3.Y);
                        break;
                    case Segment s:
                        bw.Write(s.EndingPoint.X);
                        bw.Write(s.EndingPoint.Y);
                        break;
                    case Rectangle r:
                        bw.Write(r.Width);
                        bw.Write(r.Height);
                        break;
                    case Circle c:
                        bw.Write(c.Radius);
                        break;
                }
            }
        }
    }
}