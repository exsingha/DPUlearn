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
        public int choose1;
        public int choose2;
        public int num;
        Random rnd = new Random();
        Pirate[] p = new Pirate[5];
        

        public MainWindow()
        {
            InitializeComponent();
            p[0] = new Pirate("Luffy", num);
            num = rnd.Next(1, 101);
            p[1] = new Pirate("Usoop", num);
            num = rnd.Next(1, 101);
            num = rnd.Next(1, 101);
            p[2] = new Pirate("Zoro", num);
            num = rnd.Next(1, 101);
            p[3] = new Pirate("Nami", num);
            num = rnd.Next(1, 101);
            num = rnd.Next(1, 101);
            p[4] = new Pirate("Sanji", num);
            num = rnd.Next(1, 101);
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
            //labelshow.Content = firstName + " Fights " + secondName + "!!!";
            //string filename01 = "/Lab10;component/Images/" + firstName + ".jpg";
            //string filename02 = "/Lab10;component/Images/" + secondName + ".jpg";

            //BitmapImage bitmap = new BitmapImage();
            //bitmap.BeginInit();
            //bitmap.UriSource = new Uri(filename01, UriKind.Relative);
            //bitmap.EndInit();
            //image1.Source = bitmap;

            //BitmapImage bitmap01 = new BitmapImage();
            //bitmap01.BeginInit();
            //bitmap01.UriSource = new Uri(filename02, UriKind.Relative);
            //bitmap01.EndInit();
            //image2.Source = bitmap01;

            // สร้าง list ของ data ขึ้นมา
            List<Pirate> items = new List<Pirate>();
            items.Add(p[choose1]);
            items.Add(p[choose2]);
            lvPirate.ItemsSource = items;

            labelshow.Content = p[choose1].Name + " is FIGHT " + p[choose2].Name;
        }

        private void luffy_Checked(object sender, RoutedEventArgs e)
        {
            //firstName = "Luffy";
            choose1 = 0;
        }

        private void usoop_Checked(object sender, RoutedEventArgs e)
        {
            //firstName = "Usoop";
            choose1 = 1;

        }

        private void zolo_Checked(object sender, RoutedEventArgs e)
        {
            //firstName = "Zoro";
            choose1 = 2;


        }

        private void nami_Checked(object sender, RoutedEventArgs e)
        {
            //firstName = "Nami";
            choose1 = 3;

        }

        private void sanji_Checked(object sender, RoutedEventArgs e)
        {
            //firstName = "Sanji";
            choose1 = 4;

        }

        private void luffy01_Checked(object sender, RoutedEventArgs e)
        {
            //secondName = "Luffy";
            choose2 = 0;
        }

        private void usoop01_Checked(object sender, RoutedEventArgs e)
        {
            //secondName = "Usoop";
            choose2 = 1;
        }

        private void zolo01_Checked(object sender, RoutedEventArgs e)
        {
            //secondName = "Zoro";
            choose2 = 2;
        }

        private void nami01_Checked(object sender, RoutedEventArgs e)
        {
            //secondName = "Nami";
            choose2 = 3;
        }

        private void sanji01_Checked(object sender, RoutedEventArgs e)
        {
            //secondName = "Sanji";
            choose2 = 4;
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
            if (p[choose1].Health > p[choose2].Health)
            {
                labelchange.Content = "Winner is " + p[choose1].Name;
            }
            else
            {
                labelchange.Content = "Winner is " + p[choose2].Name;

            }
            //labelchange.Content = firstName;
        }
    }
}
