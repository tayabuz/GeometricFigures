using System;

namespace GeometricFigures.Figures
{
    public class Triangle:Figure
    {
        public Triangle(params Point[] p)
        {
            points = p;
        }

        public override double GetArea()
        {
            return 0.5 * Math.Abs((points[0].X - points[2].X) * (points[1].Y - points[2].Y) - (points[1].X - points[2].X) * (points[0].Y - points[2].Y));
        }

        public override Point GetCenter()
        {
            int x = (points[0].X + points[1].X + points[2].X) / 3;
            int y = (points[0].Y + points[1].Y + points[2].Y) / 3;
            return new Point(x,y);
        }
    }
}
