using System.IO;
using System.Windows.Media.Imaging;

namespace Maths.DateBase
{
    public class MathExample
    {
        public int Id { get; set; }
        public string CorrectAnswer { get; set; }
        public byte[] ExampleImage { get; set; }
        public int DifficultyLevel { get; set; }

        public BitmapImage ExampleBitmap
        {
            get
            {
                if (ExampleImage == null || ExampleImage.Length == 0)
                    return null;

                using (var ms = new MemoryStream(ExampleImage))
                {
                    var bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.StreamSource = ms;
                    bitmap.CacheOption = BitmapCacheOption.OnLoad;
                    bitmap.EndInit();
                    return bitmap;
                }
            }
        }
    }

}
