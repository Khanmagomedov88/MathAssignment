using Maths.DateBase;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Maths.Frame.LevelExamples
{
    /// <summary>
    /// Логика взаимодействия для Advanced.xaml
    /// </summary>
    public partial class Advanced : Page
    {
        private List<MathExample> _mathExamples;

        public Advanced()
        {
            InitializeComponent();
            LoadExamples();

        }

        private void LoadExamples()
        {
            try
            {
                using (var dbContext = new MathDbContext())
                {
                    // Загружаем только те примеры, у которых DifficultyLevel равен 3
                    _mathExamples = dbContext.MathExamples
                        .Where(example => example.DifficultyLevel == 3)
                        .ToList();

                    // Устанавливаем источником данных для ListView
                    ExamplesListView.ItemsSource = _mathExamples;
                }

            }
            catch (Exception ex) { 
                MessageBox.Show("Ошибка! Обратитесь к разработчику" + ex.Message, "Информация", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void OnAnswerButtonClick(object sender, RoutedEventArgs e)
        {
            // Получаем выбранный элемент MathExample
            var button = sender as Button;
            var example = button?.DataContext as MathExample;

            if (example != null)
            {
                // Логика для обработки ответа пользователя
                var container = ExamplesListView.ItemContainerGenerator.ContainerFromItem(example) as ListViewItem;
                var textBox = FindVisualChild<TextBox>(container);

                if (textBox != null)
                {
                    string userAnswer = textBox.Text;

                    if (userAnswer == example.CorrectAnswer)
                    {
                        MessageBox.Show("Ответ верный!");
                    }
                    else
                    {
                        MessageBox.Show("Ответ неверный, попробуйте снова.");
                    }
                }
            }
        }

        private T FindVisualChild<T>(DependencyObject parent) where T : DependencyObject
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);
                if (child != null && child is T foundChild)
                    return foundChild;
                else
                {
                    var result = FindVisualChild<T>(child);
                    if (result != null)
                        return result;
                }
            }
            return null;
        }

        private void OnDeleteButtonClick(object sender, RoutedEventArgs e)
        {
            // Получаем кнопку, на которую нажали
            var button = sender as Button;
            if (button == null) return;

            // Находим DataContext, который привязан к элементу
            var example = button.DataContext as MathExample;
            if (example == null) return;

            // Подтверждаем удаление
            if (MessageBox.Show("Вы уверены, что хотите удалить этот пример?", "Подтверждение удаления", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                // Удаление задачи из базы данных
                string dbPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "mathApp.db");
                using (SqliteConnection connection = new SqliteConnection($"Data Source={dbPath}"))
                {
                    connection.Open();

                    using (var command = new SqliteCommand("DELETE FROM MathExamples WHERE Id = @Id", connection))
                    {
                        command.Parameters.AddWithValue("@Id", example.Id);
                        command.ExecuteNonQuery();
                    }
                }

                var parentWindow = Window.GetWindow(this) as MainWindow;
                parentWindow.Frame_W.Navigate(new Advanced());
            }
        }
    }
}
