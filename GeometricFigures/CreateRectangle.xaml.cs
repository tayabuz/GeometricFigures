using System;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using GeometricFigures.Figures;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace GeometricFigures
{
    public sealed partial class CreateRectangle : Page
    {
        public CreateRectangle()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Enabled;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Frame frame = Window.Current.Content as Frame;
            if (frame.CanGoBack)
            {
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
                    AppViewBackButtonVisibility.Visible;
            }
            else
            {
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
                    AppViewBackButtonVisibility.Collapsed;
            }
        }

        private void DrawRectangle_OnClick_Click(object sender, RoutedEventArgs e)
        {
            if (Point.CheckOutput(SetUpFirstXValue.Text) && Point.CheckOutput(SetUpFirstYValue.Text) &&
                Point.CheckOutput(SetRectangleHeigth.Text) && Point.CheckOutput(SetRectangleWidth.Text))
            {

                int firstPointX = Int32.Parse(SetUpFirstXValue.Text);
                int firstPointY = Int32.Parse(SetUpFirstYValue.Text);
                int height = Int32.Parse(SetRectangleHeigth.Text);
                int width = Int32.Parse(SetRectangleWidth.Text);
                Point firstPoint = new Point(firstPointX, firstPointY);
                IFigure figure = new Rectangle(firstPoint, height, width);
                Frame.Navigate(typeof(DrawFigure), figure);
            }
            else
            {
                SetUpFirstXValue.Text = "";
                SetUpFirstYValue.Text = "";
                SetRectangleWidth.Text = "";
                SetRectangleHeigth.Text = "";
            }
        }
    }
}
