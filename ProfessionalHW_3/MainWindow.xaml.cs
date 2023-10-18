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

            string imageFolderPath = @"D:\Катя\kurs";
            imageFiles = Directory.GetFiles(imageFolderPath, "*.jpg");
            ShowImage(currentIndex);
        }

        private void ShowImage(int index)
        {
            byte[] image = null;
            if (File.Exists(imageFiles[index]))
            {
                image = File.ReadAllBytes(imageFiles[index]);
            }

            memoryStream = new MemoryStream(image);

            if (index >= 0 && index < imageFiles.Length)
            {
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.StreamSource = memoryStream;
                bitmap.EndInit();
                imageControl.Source = bitmap;
                memoryStream.Close();
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {

            currentIndex++;
            if (currentIndex >= imageFiles.Length)
            {
                currentIndex = 0;
            }
            ShowImage(currentIndex);
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {

            currentIndex--;
            if (currentIndex < 0)
            {
                currentIndex = imageFiles.Length - 1;
            }
            ShowImage(currentIndex);
        }
    }
}
