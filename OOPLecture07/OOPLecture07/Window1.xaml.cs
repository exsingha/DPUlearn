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
using System.Windows.Shapes;

namespace OOPLecture07
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            int sub;
            sub = Convert.ToInt32(inputNumber11.Text) - Convert.ToInt32(inputNumber12.Text);
            inputNumber13.Text = sub.ToString();
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            inputNumber11.Text = "0";
            inputNumber12.Text = "0";
            inputNumber13.Text = "0";
        }

        private void tosubtraction_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            Close();
        }
    }
}
