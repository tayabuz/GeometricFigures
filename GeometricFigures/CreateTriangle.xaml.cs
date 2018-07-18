using System;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using GeometricFigures.Figures;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace GeometricFigures
{
    public sealed partial class CreateTriangle : Page
    {
        public CreateTriangle()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Enabled;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Frame frame = Window.Current.Content as Frame;
            if (frame.CanGoBack)
            {
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            }
            else
            {
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
            }
        }

        private void DrawTriangle_OnClick_Click(object sender, RoutedEventArgs e)
        {

            if (Point.CheckOutput(SetUpFirstXValue.Text) && Point.CheckOutput(SetUpFirstYValue.Text) &&
                Point.CheckOutput(SetUpSecondXValue.Text) && Point.CheckOutput(SetUpSecondYValue.Text) &&
                Point.CheckOutput(SetUpThirdXValue.Text) && Point.CheckOutput(SetUpThirdYValue.Text))
            {

                int firstPointX = Int32.Parse(SetUpFirstXValue.Text);
                int firstPointY = Int32.Parse(SetUpFirstYValue.Text);
                int secondPointX = Int32.Parse(SetUpSecondXValue.Text);
                int secondPointY = Int32.Parse(SetUpSecondYValue.Text);
                int thirdPointX = Int32.Parse(SetUpThirdXValue.Text);
                int thirdPointY = Int32.Parse(SetUpThirdYValue.Text);

                Point firstPoint = new Point(firstPointX, firstPointY);
                Point secondPoint = new Point(secondPointX, secondPointY);
                Point thirdPoint = new Point(thirdPointX, thirdPointY);

                IFigure figure = new Triangle(new[] { firstPoint, secondPoint, thirdPoint });
                Frame.Navigate(typeof(DrawFigure), figure);
            }
            else
            {
                SetUpFirstXValue.Text = "";
                SetUpFirstYValue.Text = "";
                SetUpSecondXValue.Text = "";
                SetUpSecondYValue.Text = "";
                SetUpThirdXValue.Text = "";
                SetUpThirdYValue.Text = "";
            }
        }
    }
}
