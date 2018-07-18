using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using GeometricFigures.Figures;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace GeometricFigures
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DrawFigure : Page
    {
        private IFigure figure;
        public DrawFigure()
        {
            DrawFigureCanvas = new Canvas();
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
            if (e.Parameter.ToString() != "")
            {
                figure = (Figure)e.Parameter;
            }
            figure.Draw(DrawFigureCanvas);
        }

        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            var t = e.SourcePageType;
        }
    }
}
