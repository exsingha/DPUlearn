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

namespace OOPLecture07_05
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Random rnd = new Random();
            int num;
            num = rnd.Next(1, 101);


            // สร้าง list ของ data ขึ้นมา
            List<Pirate> items = new List<Pirate>();
            items.Add(new Pirate("Luffy", num));
            num = rnd.Next(1, 101);
            num = rnd.Next(1, 101);
            items.Add(new Pirate("Usoop", num));
            num = rnd.Next(1, 101);
            
            items.Add(new Pirate("Zoro", num));
            num = rnd.Next(1, 101);
            num = rnd.Next(1, 101);
            num = rnd.Next(1, 101);
            items.Add(new Pirate("Nami", num));
            num = rnd.Next(1, 101);
            num = rnd.Next(1, 101);
            items.Add(new Pirate("Sanji", num));
            num = rnd.Next(1, 101);

            lvPirate.ItemsSource = items;
        }
    }
}
