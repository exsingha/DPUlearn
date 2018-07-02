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
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public int customerCount = 0;

        public Home()
        {
            InitializeComponent();
        }

        // exit button event
        void OnImageButtonClick(object sender, RoutedEventArgs e)
        {
            MainWindow openLogin = new MainWindow();
            openLogin.Show();
            this.Close();
        }

        //private void add_btn_Click(object sender, RoutedEventArgs e)
        //{
        //    Task newtask = new Task();
        //    newtask.Show();

        //    this.Close();
        //}

        private void mobile_num_GotFocus(object sender, RoutedEventArgs e)
        {
            mobile_num.Text = string.Empty;
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            String mob = mobile_num.Text;
            String cus = customer_name.Text;
            String boo = booking_no.Text;
            String typ;
            String sta;
            if (task_type.SelectedItem.ToString().Equals("Complain"))
            {
                typ = "Complain";
            }
            else
            {
                typ = "Accident";
            }
            if (status.SelectedItem.ToString().Equals("Open"))
            {
                sta = "Open";
            }
            else
            {
                sta = "Close";
            }
            String des = task_des.Text;

            Customer addCustomer = new Customer(mob, cus, boo, typ, sta, des);
            Customer.Items.Add(addCustomer);

            customerCount++;
            seeAllRecord.Content = "Total item " + customerCount + " record(s).";
        }

        private void clear_btn_Click(object sender, RoutedEventArgs e)
        {
            mobile_num.Text = "";
            customer_name.Text = "";
            booking_no.Text = "";
            task_des.Text = "";
        }
    }
}
