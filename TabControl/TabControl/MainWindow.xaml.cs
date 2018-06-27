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

namespace TabControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string firstpirate;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            Maintab.SelectedIndex = 1;
            fightLabel.Content = firstpirate;
        }

        private void luffy_Checked(object sender, RoutedEventArgs e)
        {
            firstpirate = "Luffy";
        }

        private void usoop_Checked(object sender, RoutedEventArgs e)
        {
            firstpirate = "Usoop";
        }

        private void zolo_Checked(object sender, RoutedEventArgs e)
        {
            firstpirate = "Zolo";
        }

        private void nami_Checked(object sender, RoutedEventArgs e)
        {
            firstpirate = "Nami";
        }

        private void sanji_Checked(object sender, RoutedEventArgs e)
        {
            firstpirate = "Sanji";
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            luffy.IsChecked = false;
            usoop.IsChecked = false;
            zolo.IsChecked = false;
            nami.IsChecked = false;
            sanji.IsChecked = false;
        }
    }
}
