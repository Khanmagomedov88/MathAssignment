using Microsoft.Data.Sqlite;
using Microsoft.Win32;
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
using System.IO;
using Maths.DateBase;

namespace Maths.Frame.ForDateBase
{
    /// <summary>
    /// Логика взаимодействия для AddExample.xaml
    /// </summary>
    public partial class AddExample : Page
    {
        public AddExample()
        {
            InitializeComponent();

            UploadImageButton.Click += UploadImageButton_Click;
        }

        private byte[] selectedImageBytes;

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

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            byte[] taskImage = SelectedImage.Tag as byte[]; 
            string correctAnswer = CorrectAnswerTextBox.Text;

            
            int level = Convert.ToInt32(string.IsNullOrEmpty(LevelComboBox.Text) ? "-1" : LevelComboBox.Text);

            // Проверяем, что данные заполнены корректно
            if (taskImage == null || string.IsNullOrWhiteSpace(correctAnswer) || level == -1)
            {
                MessageBox.Show("Пожалуйста, заполните все поля перед сохранением.", "Информация", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Добавляем данные в базу данных с использованием Entity Framework
            using (var context = new MathDbContext())
            {
                var newExample = new MathExample
                {
                    ExampleImage = taskImage,
                    CorrectAnswer = correctAnswer,
                    DifficultyLevel = level
                };

                context.MathExamples.Add(newExample);
                context.SaveChanges();
            }

            MessageBox.Show("Пример успешно сохранен в базу данных.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            var parentWindow = Window.GetWindow(this) as MainWindow;
            if (parentWindow != null)
            {
                parentWindow.Frame_W.Navigate(new MainAddTasks());
            }
        }
    }
}
