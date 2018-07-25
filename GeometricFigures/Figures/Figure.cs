using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace GeometricFigures.Figures
{
    public abstract class Figure:IFigure
    {
        private const int MAX_NUMBER_OF_POINTS = 6;
        protected Point[] points = new Point[MAX_NUMBER_OF_POINTS];
        public abstract double GetArea();

        public void TurnByDegrees(int degrees)
        {
            double angleRadian = degrees * Math.PI / 180;
            for (int i = 0; i < points.Length; i++)
            {
                if(points[i] != null)
                {
                    int x = (int)((points[i].X - GetCenter().X) * Math.Cos(angleRadian) - (points[i].Y - GetCenter().Y) * Math.Sin(angleRadian) + GetCenter().X);
                    int y = (int)((points[i].X - GetCenter().X) * Math.Sin(angleRadian) + (points[i].Y - GetCenter().Y) * Math.Cos(angleRadian) + GetCenter().Y);
                    points[i] = new Point(x, y);
                }
            }
        }

        public void Displacement(int deltaX, int deltaY)
        {
            for (int i = 0; i < points.Length; i++)
            {
		if(points[i] != null)
                {
		   points[i].X = points[i].X + deltaX;
		   points[i].Y = points[i].Y + deltaY;
		}
            }
        }

        public Point[] GetPoints()
        {
            Point[] ps = points;
            return ps;
        }

        public abstract Point GetCenter();
        public void Draw(Canvas canvas)
        {
            var polygon = new Polygon { Fill = new SolidColorBrush(Windows.UI.Colors.Blue) };
            PointCollection pc = new PointCollection();
            foreach (var p in points)
            {
                if (p != null) { pc.Add(p.ToMicrosoftPoint()); }
                else { break; }
            }
            polygon.Points = pc;
            canvas.Children.Clear();
            Canvas.SetTop(polygon, canvas.Width / 2);
            canvas.Children.Add(polygon);
        }
    }
}
