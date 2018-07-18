using System;

namespace GeometricFigures.Figures
{
    public class RegularHexagon:Figure
    {
        public RegularHexagon(Point p, int t)
        {
            /*
                     * <- P1
            P0 -> *     * <- P2
            P5 -> *     * <- P3
                     * <- P4
             */
            points[0] = p;
            points[1] = new Point((int)(p.X + Math.Sqrt(Math.Pow(t, 2) - Math.Pow(t / 2, 2))), p.Y + t / 2);
            points[2] = new Point((int)(p.X + 2 * Math.Sqrt(Math.Pow(t, 2) - Math.Pow(t / 2, 2))), p.Y);
            points[3] = new Point(points[2].X, p.Y - t);
            points[4] = new Point(points[1].X, points[3].Y - t / 2);
            points[5] = new Point(p.X, p.Y - t);
        }

        public override double GetArea()
        {
            return (points[3].Y - points[2].Y) * ((3 * Math.Sqrt(3)) / 2);
        }

        public override Point GetCenter()
        {
            Point result = Point.GetMidPoint(points[0], points[3]);
            return result;
        }
    }
}
