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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOPLecture07_04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //string[] pirate = { "Luffy.jpg", "Nami.jpg", "Sanji.jpg", "Usoop.jpg", "Zoro.jpg" };
        int imgindex = 1;
        Pirate[] p = new Pirate[10];

        public MainWindow()
        {
            InitializeComponent();
            p[0] = new Pirate("Luffy");
            p[1] = new Pirate("Zoro");
            p[2] = new Pirate("Nami");
            p[3] = new Pirate("Usoop");
            p[4] = new Pirate("Sanji");
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            //string filename = "/OOPLecture07_04;component/Images/" + pirate[imgindex];
            string filename = p[imgindex].GetImageName();

            labelchange.Content = p[imgindex].Name;
            imgindex = (imgindex + 1) % 5;
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(filename, UriKind.Relative);
            bitmap.EndInit();
            image1.Source = bitmap;
        }
    }
}
