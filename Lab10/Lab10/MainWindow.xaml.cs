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

namespace Lab10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string firstName;
        public string secondName;
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            luffy.IsChecked = false;
            usoop.IsChecked = false;
            zolo.IsChecked = false;
            nami.IsChecked = false;
            sanji.IsChecked = false;
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            MainTab.SelectedIndex = 1;
            
        }
        private void saveBtn01_Click(object sender, RoutedEventArgs e)
        {
            MainTab.SelectedIndex = 2;
            labelshow.Content = firstName + " Fights " + secondName + "!!!";
            string filename01 = "/Lab10;component/Images/" + firstName + ".jpg";
            string filename02 = "/Lab10;component/Images/" + secondName + ".jpg";

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(filename01, UriKind.Relative);
            bitmap.EndInit();
            image1.Source = bitmap;

            BitmapImage bitmap01 = new BitmapImage();
            bitmap01.BeginInit();
            bitmap01.UriSource = new Uri(filename02, UriKind.Relative);
            bitmap01.EndInit();
            image2.Source = bitmap01;
        }

        private void luffy_Checked(object sender, RoutedEventArgs e)
        {
            firstName = "Luffy";
        }

        private void usoop_Checked(object sender, RoutedEventArgs e)
        {
            firstName = "Usoop";
        }

        private void zolo_Checked(object sender, RoutedEventArgs e)
        {
            firstName = "Zoro";

        }

        private void nami_Checked(object sender, RoutedEventArgs e)
        {
            firstName = "Nami";
        }

        private void sanji_Checked(object sender, RoutedEventArgs e)
        {
            firstName = "Sanji";
        }

        private void luffy01_Checked(object sender, RoutedEventArgs e)
        {
            secondName = "Luffy";
        }

        private void usoop01_Checked(object sender, RoutedEventArgs e)
        {
            secondName = "Usoop";
        }

        private void zolo01_Checked(object sender, RoutedEventArgs e)
        {
            secondName = "Zoro";
        }

        private void nami01_Checked(object sender, RoutedEventArgs e)
        {
            secondName = "Nami";
        }

        private void sanji01_Checked(object sender, RoutedEventArgs e)
        {
            secondName = "Sanji";
        }

        private void clearBtn01_Click(object sender, RoutedEventArgs e)
        {
            luffy01.IsChecked = false;
            usoop01.IsChecked = false;
            zolo01.IsChecked = false;
            nami01.IsChecked = false;
            sanji01.IsChecked = false;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            labelchange.Content = firstName;
        }
    }
}
