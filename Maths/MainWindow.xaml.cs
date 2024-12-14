using Maths.Frame;
using Maths.Frame.ForDateBase;
using System.Data;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Maths
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static Timer timer;

        public MainWindow()
        {
            InitializeComponent();
            Frame_W.Content = PageManager.PageHome;
            
            timer = new Timer(DisplayCurrentTime, null, 0, 10000);
        }

        private void Click_Style(object sender, RoutedEventArgs e)
        {
            string source = Image_Style.Source.ToString();

            if (source.Contains("Images/Moon.png"))
            {
                Image_Style.Source = new BitmapImage(new Uri("Images/Sun.png", UriKind.Relative));
                Button_Administration.Visibility = Visibility.Visible;
            }
            else
            {
                Image_Style.Source = new BitmapImage(new Uri("Images/Moon.png", UriKind.Relative));
                Button_Administration.Visibility = Visibility.Hidden;

            }
        }

        private void Click_Home(object sender, RoutedEventArgs e)
        {
            TitleText.Text = "Главная страница";
            Frame_W.Content = PageManager.PageHome;
        }

        private void Click_Handbook(object sender, RoutedEventArgs e)
        {
            TitleText.Text = "Справочник";
            Frame_W.Content = PageManager.HandbookPage;
        }

        private void Click_Examples(object sender, RoutedEventArgs e)
        {
            TitleText.Text = "Решение примеров";
            Frame_W.Content = new Examples();
        }

        private void Click_Problems(object sender, RoutedEventArgs e)
        {
            TitleText.Text = "Решение задач";
            Frame_W.Content = new Problems();
        }

        private void Click_Equations(object sender, RoutedEventArgs e)
        {
            TitleText.Text = "Решение уравнений";
            Frame_W.Content = new Equations();
        }

        private void Click_AddTask(object sender, RoutedEventArgs e)
        {
            TitleText.Text = "Добавить задачу";
            Frame_W.Content = PageManager.MainAddTasksPage;
        }

        private void Click_Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void DisplayCurrentTime(object state)
        {
            // Получаем текущее время
            DateTime currentTime = DateTime.Now;

            // Обновляем TextBlock в UI-потоке
            Dispatcher.Invoke(() =>
            {
                // Проверяем, что элемент управления доступен и не равен null
                if (textTime != null)
                {
                    // Устанавливаем текст в элемент управления
                    textTime.Text = currentTime.ToString("HH:mm");
                }
            });
        }
    }
}