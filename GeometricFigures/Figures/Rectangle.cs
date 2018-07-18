using System;

namespace GeometricFigures.Figures
{
    public class Rectangle:Figure
    {
        public Rectangle(Point p, int Heigth, int Width)
        {
            points[0] = p; //левая нижняя точка
            points[1] = new Point(p.X, p.Y + Heigth); //левая верхняя точка
            points[2] = new Point(p.X + Width, p.Y + Heigth); //правая верхняя точка
            points[3] = new Point(p.X + Width, p.Y);  //правая нижняя точка
        }
        public override double GetArea()
        {
            int Heigth = points[1].Y - points[0].Y;
            int Width = points[2].X - points[1].X;
            var result = Math.Abs(Heigth * Width);
            return result;
        }

        public override Point GetCenter()
        {
            Point result = Point.GetMidPoint(points[1], points[3]);
            return result;
        }
    }
}
