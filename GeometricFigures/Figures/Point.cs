using System;
using System.Text.RegularExpressions;

namespace GeometricFigures
{
    public class Point
    {
        public Point() {}
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }

        public static bool CheckOutput(string userAnswerString)
        {
            bool userAnswerValid = true;
            try
            {
                userAnswerValid = !string.IsNullOrEmpty(userAnswerString) && Regex.IsMatch(userAnswerString, @"[\d]");
            }
            catch (FormatException) { userAnswerValid = false; }
            return userAnswerValid;
        }

        public Windows.Foundation.Point ToMicrosoftPoint()
        {
            return new Windows.Foundation.Point(X, Y);
        }

        public static Point GetMidPoint(Point start, Point end)
        {
            int x = (start.X + end.X) / 2;
            int y = (start.Y + end.Y) / 2;
            return new Point(x, y);
        }
    }
}
