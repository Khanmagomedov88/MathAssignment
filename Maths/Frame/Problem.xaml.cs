using Maths.DateBase;
using Microsoft.Data.Sqlite;
using System;
using Microsoft.Data.Sqlite;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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

namespace Maths.Frame
{
    /// <summary>
    /// Логика взаимодействия для Problem.xaml
    /// </summary>
    public partial class Problem : Page
    {
        private MathTask _task;
        public Problem(MathTask task)
        {
            InitializeComponent();
            _task = task;
            TaskNameTextBlock.Text = task.TaskName;

            if (task.TaskImage != null && task.TaskImage.Length > 0)
            {
                using (var stream = new MemoryStream(task.TaskImage))
                {
                    var bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.StreamSource = stream;
                    bitmap.CacheOption = BitmapCacheOption.OnLoad;
                    bitmap.EndInit();
                    TaskImage.Source = bitmap;
                }
            }
        }

        private void CheckAnswer_Click(object sender, RoutedEventArgs e)
        {
            string userAnswer = AnswerTextBox.Text;
            if (userAnswer == _task.CorrectAnswer)
            {
                MessageBox.Show("Ответ правильный", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Ответ неправильный, попробуйте еще раз", "Информация", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void TaskImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (TaskImage.Source is BitmapSource bitmapSource)
            {
                // Конвертируем изображение в byte[]
                byte[] imageBytes = BitmapToByteArray(bitmapSource);
                var imageViewer = new ImageViewer(imageBytes);
                imageViewer.Show();
            }
        }

        private byte[] BitmapToByteArray(BitmapSource bitmapSource)
        {
            using (var memoryStream = new MemoryStream())
            {
                BitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(bitmapSource));
                encoder.Save(memoryStream);
                return memoryStream.ToArray();
            }
        }

        private void DeleteTask_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите удалить эту задачу?", "Подтверждение удаления", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                // Удаление задачи из базы данных
                string dbPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "mathApp.db");
                using (SqliteConnection connection = new SqliteConnection($"Data Source={dbPath}"))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM MathTasks WHERE Id = @Id";
                    using (SqliteCommand command = new SqliteCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Id", _task.Id);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Задача успешно удалена", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);

                var parentWindow = Window.GetWindow(this) as MainWindow;
                parentWindow.Frame_W.Navigate(new Problems());
            }
        }

        private void FindAnswer_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Правильный ответ: {_task.CorrectAnswer}", "Информация", MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void AnswerTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AnswerTextBox.Text))
            {
                WatermarkTextBlock.Visibility = Visibility.Visible;
            }
        }

        private void AnswerTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            WatermarkTextBlock.Visibility = Visibility.Collapsed;
        }
    }
}
