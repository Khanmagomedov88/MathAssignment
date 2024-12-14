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
using System.Windows.Shapes;

namespace Maths
{
    /// <summary>
    /// Логика взаимодействия для ImageViewer.xaml
    /// </summary>
    public partial class ImageViewer : Window
    {
        public ImageViewer(byte[] imageBytes)
        {
            InitializeComponent();
            if (imageBytes != null && imageBytes.Length > 0)
            {
                using (var stream = new MemoryStream(imageBytes))
                {
                    var bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.StreamSource = stream;
                    bitmap.CacheOption = BitmapCacheOption.OnLoad; // Загружаем изображение в память
                    bitmap.EndInit();
                    bitmap.Freeze(); // Замораживаем объект, чтобы предотвратить дальнейшие изменения
                    FullSizeImage.Source = bitmap;
                }
            }
            else
            {
                MessageBox.Show("Ошибка: Изображение не загружено.");
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove(); // Перемещение окна
            }
        }

    }
}
