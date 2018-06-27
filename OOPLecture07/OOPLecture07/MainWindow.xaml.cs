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

namespace OOPLecture07
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void inputNumber11_Click(object sender, System.EventArgs e)
        {
            //inputNumber11.Clear();
            //inputNumber11.Text = "";
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            int result;
            result = Convert.ToInt32(inputNumber11.Text) + Convert.ToInt32(inputNumber12.Text);
            inputNumber13.Text = result.ToString();

            result = Convert.ToInt32(inputNumber21.Text) + Convert.ToInt32(inputNumber22.Text);
            inputNumber23.Text = result.ToString();

            result = Convert.ToInt32(inputNumber31.Text) + Convert.ToInt32(inputNumber32.Text);
            inputNumber33.Text = result.ToString();
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            inputNumber11.Text = "0";
            inputNumber12.Text = "0";
            inputNumber13.Text = "0";

            inputNumber21.Text = "0";
            inputNumber22.Text = "0";
            inputNumber23.Text = "0";

            inputNumber31.Text = "0";
            inputNumber32.Text = "0";
            inputNumber33.Text = "0";
        }

        private void tosubtraction_Click(object sender, RoutedEventArgs e)
        {
            Window1 wp = new Window1();
            wp.inputNumber11.Text = inputNumber11.Text;
            wp.inputNumber12.Text = inputNumber12.Text;
            wp.Show();
            this.Close();
        }

        private void inputNumber11_GotFocus(object sender, RoutedEventArgs e)
        {
            inputNumber11.Text = "";
        }

        private void inputNumber12_GotFocus(object sender, RoutedEventArgs e)
        {
            inputNumber12.Text = "";
        }
    }
}
