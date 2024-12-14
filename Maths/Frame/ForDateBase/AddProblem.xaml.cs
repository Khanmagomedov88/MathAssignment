using Maths.DateBase;
using Maths.Frame.ForDateBase;
using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Controls;

using System.Windows.Media.Imaging;


namespace Maths.Frame
{
    /// <summary>
    /// Логика взаимодействия для AddTask.xaml
    /// </summary>
    public partial class AddProblem : Page
    {
        public AddProblem()
        {
            InitializeComponent();
            var mainWindow = Application.Current.MainWindow as MainWindow;
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            var parentWindow = Window.GetWindow(this) as MainWindow;
            if (parentWindow != null)
            {
                parentWindow.Frame_W.Navigate(new MainAddTasks());
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string taskName = TaskNameTextBox.Text;
            byte[] taskImage = SelectedImage.Tag as byte[]; // Получаем изображение из Tag
            string correctAnswer = CorrectAnswerTextBox.Text;

            // Проверяем, что данные заполнены корректно
            if (string.IsNullOrWhiteSpace(taskName) || taskImage == null || string.IsNullOrWhiteSpace(correctAnswer))
            {
                MessageBox.Show("Пожалуйста, заполните все поля перед сохранением.", "Информация", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Добавляем данные в базу данных с использованием Entity Framework
            using (var context = new MathDbContext())
            {
                var newTask = new MathTask
                {
                    TaskName = taskName,
                    TaskImage = taskImage,
                    CorrectAnswer = correctAnswer
                };

                context.MathTasks.Add(newTask);
                context.SaveChanges();
            }

            MessageBox.Show("Задача успешно сохранена в базу данных.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void UploadImageButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == true)
            {
                // Отображение изображения в элементе управления Image
                SelectedImage.Source = new BitmapImage(new Uri(openFileDialog.FileName));

                // Сохранение изображения в виде массива байтов для последующего добавления в базу данных
                byte[] imageBytes = File.ReadAllBytes(openFileDialog.FileName);
                SelectedImage.Tag = imageBytes; // Сохраняем байты в Tag элемента для использования позже
            }
        }
    }
}
