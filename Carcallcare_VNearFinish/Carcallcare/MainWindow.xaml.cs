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

namespace Carcallcare
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

        //when click on textbox set empty
        private void Username_GotFocus(object sender, RoutedEventArgs e)
        {
            username.Text = string.Empty;
        }

        private void pass_GotFocus(object sender, RoutedEventArgs e)
        {
            passwordBox.Password = "";
        }

        private void login_btn_Click(object sender, RoutedEventArgs e)
        {
            Home home = new Home();

            home.Show();
            this.Close();
        }
    }
}
