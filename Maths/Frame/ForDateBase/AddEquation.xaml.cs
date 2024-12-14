using Maths.DateBase;
using Microsoft.Win32;
using System;
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

namespace Maths.Frame.ForDateBase
{
    /// <summary>
    /// Логика взаимодействия для AddEquation.xaml
    /// </summary>
    public partial class AddEquation : Page
    {
        public AddEquation()
        {
            InitializeComponent();
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

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string equationName = TaskNameTextBox.Text;
            byte[] equationImage = SelectedImage.Tag as byte[]; // Получаем изображение из Tag
            string correctAnswer = CorrectAnswerTextBox.Text;

            // Проверяем, что данные заполнены корректно
            if (equationImage == null || string.IsNullOrWhiteSpace(correctAnswer))
            {
                MessageBox.Show("Пожалуйста, заполните все поля перед сохранением.", "Информация", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Добавляем данные в базу данных с использованием Entity Framework
            using (var context = new MathDbContext())
            {
                var newEquation = new MathEquation
                {
                    EquationName = equationName ?? "Уравнение",
                    EquationImage = equationImage,
                    CorrectAnswer = correctAnswer
                };

                context.MathEquations.Add(newEquation);
                context.SaveChanges();
            }

            MessageBox.Show("Уравнение успешно сохранено в базу данных.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            var parentWindow = Window.GetWindow(this) as MainWindow;
            if (parentWindow != null)
            {
                parentWindow.Frame_W.Navigate(new Home());
            }
        }
    }
}
