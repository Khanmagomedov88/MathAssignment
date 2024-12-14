using Maths.Frame.ForDateBase;
using Maths.Frame.LevelExamples;
using System.Windows;
using System.Windows.Controls;

namespace Maths.Frame
{
    /// <summary>
    /// Логика взаимодействия для Examples.xaml
    /// </summary>
    public partial class Examples : Page
    {
        public Examples()
        {

            InitializeComponent();
        }

        private void Click_Advanced(object sender, System.Windows.RoutedEventArgs e)
        {
            var parentWindow = Window.GetWindow(this) as MainWindow;
            if (parentWindow != null)
            {
                parentWindow.Frame_W.Navigate(new Advanced());
            }
        }

        private void Click_Middle(object sender, System.Windows.RoutedEventArgs e)
        {
            var parentWindow = Window.GetWindow(this) as MainWindow;
            if (parentWindow != null)
            {
                parentWindow.Frame_W.Navigate(new MediumLevel());
            }
        }

        private void Click_Easy(object sender, System.Windows.RoutedEventArgs e)
        {
            var parentWindow = Window.GetWindow(this) as MainWindow;
            if (parentWindow != null)
            {
                parentWindow.Frame_W.Navigate(new EasyLevel());
            }
        }
    }
}
