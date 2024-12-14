using Maths.DateBase;
using System.Globalization;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Maths.Frame
{
    /// <summary>
    /// Логика взаимодействия для Problems.xaml
    /// </summary>
    public partial class Problems : Page
    {
        private readonly MathDbContext _context;

        public Problems()
        {
            InitializeComponent();

            _context = new MathDbContext();

            LoadTasks();
        }

        private void LoadTasks()
        {
            try
            {
                var tasks = _context.MathTasks.ToList(); // Получите все задачи из БД
                TasksListBox.ItemsSource = tasks;

            }
            catch (Exception ex) {
                MessageBox.Show("Ошибка! Обратитесь к разработчику" + ex.Message, "Информация", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void TasksListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var parentWindow = Window.GetWindow(this) as MainWindow;

            parentWindow.Frame_W.Navigate(new AddProblem());


            if (TasksListBox.SelectedItem is MathTask selectedTask)
            {
                Problem problemWindow = new Problem(selectedTask);
                parentWindow.Frame_W.Navigate(problemWindow);
            }
        }
    }
}
