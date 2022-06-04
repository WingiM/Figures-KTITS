// Sharipov Kamil 220 Figures-4 30.05

using Figures.Core;
using Figures.Core.Figures;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Rectangle = Figures.Core.Figures.Rectangle;

namespace Figures.Winforms
{
    public partial class DrawForm : Form
    {
        private Point _startPoint;
        private Point _endPoint;
        private readonly FigureController _figures;
        private Figure _currentFigure;
        private string _currentFigureName;
        private Color _color = Color.Black;

        public DrawForm()
        {
            _figures = new();
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance |
                BindingFlags.NonPublic,
                null, workplace, new object[] { true });
            btn_ChangeColor.BackColor = _color;
        }

        private void workplace_Paint(object sender, PaintEventArgs e)
        {
            var drawer = new WinformsDrawer(e.Graphics);
            _figures.Draw(drawer);
            _currentFigure?.Draw(drawer);
        }

        private void workplace_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _startPoint = e.Location;
        }

        private void workplace_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _endPoint = e.Location;
                if (_currentFigure is not null)
                    _figures.Add(_currentFigure);
                workplace.Invalidate();
            }
        }

        private void workplace_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _endPoint = e.Location;
                UpdateCurrentFigure();
                workplace.Invalidate();
            }
        }

        private void UpdateCurrentFigure()
        {
            var pen = new StrokeData(_color,
                int.Parse(textBox_ChangeWidth.Text == ""
                    ? "1"
                    : textBox_ChangeWidth.Text));
            switch (_currentFigureName)
            {
                case "T":
                    _currentFigure = new Triangle(pen,
                        new Point { Y = _endPoint.Y, X = _startPoint.X },
                        new Point
                        {
                            X = (_startPoint.X + _endPoint.X) / 2,
                            Y = _startPoint.Y
                        }, _endPoint);
                    break;
                case "C":
                    var radius = (int)Math.Sqrt(
                        Math.Pow(_endPoint.X - _startPoint.X, 2) +
                        Math.Pow(_endPoint.Y - _startPoint.Y, 2));

                    _currentFigure = new Circle(pen, _startPoint, radius);
                    break;
                case "L":
                    _currentFigure = new Segment(pen, _startPoint, _endPoint);
                    break;
                case "R":
                    var startX = Math.Min(_startPoint.X, _endPoint.X);
                    var startY = Math.Min(_startPoint.Y, _endPoint.Y);
                    var width = Math.Abs(_endPoint.X - _startPoint.X);
                    var height = Math.Abs(_endPoint.Y - _startPoint.Y);

                    _currentFigure = new Rectangle(pen,
                        new Point(startX, startY), width, height);
                    break;
            }
        }

        private void DrawForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (ModifierKeys == Keys.Control)
            {
                if (e.KeyCode == Keys.S)
                {
                    SaveDrawings();
                }
                else if (e.KeyCode == Keys.L)
                {
                    LoadDrawings();
                }
                else if (e.KeyCode == Keys.Z)
                {
                    _figures.PopBack();
                    _currentFigure = null;
                    workplace.Invalidate();
                }
            }
        }

        private void SaveDrawings()
        {
            try
            {
                saveDialog.FileName = "figures.pic";
                saveDialog.Filter = "Pic files (*.pic)|*.pic";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    _figures.Save(saveDialog.FileName);
                }
            }
            catch (IOException)
            {
                statusLine.Text = "File already exists";
            }
        }

        private void LoadDrawings()
        {
            try
            {
                loadDialog.Filter = "Pic files (*.pic)|*.pic";
                if (loadDialog.ShowDialog() == DialogResult.OK)
                {
                    _figures.Load(loadDialog.FileName);
                    workplace.Invalidate();
                }
            }
            catch (FileNotFoundException)
            {
                statusLine.Text = "Could not find the file";
            }
            catch (EndOfStreamException)
            {
                statusLine.Text = "Bad file encoding";
            }
        }

        private void NewWorkplace()
        {
            _figures.Clear();
            _currentFigure = null;
            workplace.Invalidate();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDrawings();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDrawings();
        }


        private void DrawingTool_btn_Click(object sender, EventArgs e)
        {
            _currentFigureName = (sender as ToolStripButton)?.Text;
            _currentFigure = null;
        }

        private void btn_ChangeColor_Click(object sender, EventArgs e)
        {
            if (changeColorDialog.ShowDialog() == DialogResult.OK)
            {
                _color = changeColorDialog.Color;
                btn_ChangeColor.BackColor = _color;
            }
        }

        private void textBox_ChangeWidth_KeyPress(object sender,
            KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewWorkplace();
        }
    }
}