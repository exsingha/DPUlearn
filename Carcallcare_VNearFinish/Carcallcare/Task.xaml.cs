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

namespace Carcallcare
{
    /// <summary>
    /// Interaction logic for Task.xaml
    /// </summary>
    public partial class Task : Window
    {
        public Task()
        {
            InitializeComponent();
        }

        private void exit_task_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void back_btn_Click(object sender, RoutedEventArgs e)
        {
            Home home = new Home();
            home.Show();

            this.Close();
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {

            Home home = new Home();
            home.Show();

            this.Close();
        }

        private void mobile_num_GotFocus(object sender, RoutedEventArgs e)
        {
            mobile_num.Text = string.Empty;
        }
    }
}
