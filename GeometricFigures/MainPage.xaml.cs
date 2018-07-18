using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GeometricFigures
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Frame frame = Window.Current.Content as Frame;

            frame.CacheSize = 5;
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            if (FiguresList.SelectedIndex == 0)
            {
                Frame.Navigate(typeof(CreateTriangle));
            }

            if (FiguresList.SelectedIndex == 1)
            {
                Frame.Navigate(typeof(CreateRectangle));
            }

            if (FiguresList.SelectedIndex == 2)
            {
                Frame.Navigate(typeof(CreateRegularHexagon));
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var t = e.SourcePageType;
        }
    }
}
