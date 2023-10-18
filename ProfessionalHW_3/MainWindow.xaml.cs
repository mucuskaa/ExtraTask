using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Linq;


namespace ProfessionalHW_3
{
    public partial class MainWindow : Window
    {
        private string[] imageFiles;
        private int currentIndex = 0;
        private MemoryStream memoryStream;

        public MainWindow()
        {
            InitializeComponent();

            const string ImageFolderPath = @"D:\Катя\kurs";
            imageFiles = Directory.GetFiles(ImageFolderPath, "*.jpg")
                               .Concat(Directory.GetFiles(ImageFolderPath, "*.png"))
                               .ToArray();
            ShowImage(currentIndex);
        }

        private void ShowImage(int index)
        {
            if (index >= 0 && index < imageFiles.Length)
            {
                if (File.Exists(imageFiles[index]))
                {
                    var image = File.ReadAllBytes(imageFiles[index]);

                    memoryStream = new MemoryStream(image);
                    BitmapImage bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.StreamSource = memoryStream;
                    bitmap.EndInit();
                    imageControl.Source = bitmap;
                }
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            memoryStream?.Close();

            currentIndex++;
            if (currentIndex >= imageFiles.Length)
            {
                currentIndex = 0;
            }
            ShowImage(currentIndex);
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {
            memoryStream?.Close();

            currentIndex--;
            if (currentIndex < 0)
            {
                currentIndex = imageFiles.Length - 1;
            }
            ShowImage(currentIndex);
        }
    }
}
