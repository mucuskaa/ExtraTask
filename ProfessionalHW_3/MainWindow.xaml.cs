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
            if (index >= 0 && index < imageFiles.Length)
            {
                memoryStream = new MemoryStream(File.ReadAllBytes(imageFiles[index]));
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.StreamSource = memoryStream;
                bitmap.EndInit();
                imageControl.Source = bitmap;
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            memoryStream.Close();

            currentIndex++;
            if (currentIndex >= imageFiles.Length)
            {
                currentIndex = 0;
            }
            ShowImage(currentIndex);
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {
            memoryStream.Close();

            currentIndex--;
            if (currentIndex < 0)
            {
                currentIndex = imageFiles.Length - 1;
            }
            ShowImage(currentIndex);
        }
    }
}
