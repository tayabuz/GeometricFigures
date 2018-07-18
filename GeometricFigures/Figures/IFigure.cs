using Windows.UI.Xaml.Controls;
using GeometricFigures.Figures;

namespace GeometricFigures
{
    public interface IFigure
    {
        double GetArea();
        void TurnByDegrees(int degrees);
        void Displacement(int deltaX, int deltaY);
        Point[] GetPoints();
        Point GetCenter();
        void Draw(Canvas canvas);
    }
}


