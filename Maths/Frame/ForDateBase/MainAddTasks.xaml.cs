using System.Windows;
using System.Windows.Controls;

namespace Maths.Frame.ForDateBase
{
    /// <summary>
    /// Логика взаимодействия для MainAddTasks.xaml
    /// </summary>
    public partial class MainAddTasks : Page
    {
        public MainAddTasks()
        {
            InitializeComponent();
        }

        private void Click_AddTasks(object sender, RoutedEventArgs e)
        {
            var parentWindow = Window.GetWindow(this) as MainWindow;
            if (parentWindow != null)
            {
                parentWindow.Frame_W.Navigate(new AddProblem());
            }
        }

        private void Click_AddEquations(object sender, RoutedEventArgs e)
        {
            var parentWindow = Window.GetWindow(this) as MainWindow;
            if (parentWindow != null)
            {
                parentWindow.Frame_W.Navigate(new AddEquation());
            }
        }

        private void Click_AddExamples(object sender, RoutedEventArgs e)
        {
            var parentWindow = Window.GetWindow(this) as MainWindow;
            if (parentWindow != null)
            {
                parentWindow.Frame_W.Navigate(new AddExample());
            }
        }
    }
}
