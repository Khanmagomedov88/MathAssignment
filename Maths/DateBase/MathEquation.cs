using System.IO;
using System.Windows.Media.Imaging;

namespace Maths.DateBase
{
    class MathEquation
    {
        public int Id { get; set; }
        public string EquationName { get; set; }
        public byte[] EquationImage { get; set; } // Фотография уравнения
        public string CorrectAnswer { get; set; }

        public BitmapImage EquationBitmap
        {
            get
            {
                if (EquationImage == null || EquationImage.Length == 0)
                    return null;

                using (var ms = new MemoryStream(EquationImage))
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
