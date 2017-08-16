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
using TestLib;

namespace WpfAppTestCS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Customer> customers = new List<Customer>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void numericOrderId_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = !((int)e.Key >= 34 && (int)e.Key <= 43);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            customers.Add(new Customer(textBox1.Text));

            RefreshComboList();
        }


        //my func
        private void RefreshComboList()
        {
            comboBox1.Items.Clear();
            foreach (var x in customers)
            {
                comboBox1.Items.Add(x.Name);
            }
        }
        private void UpdateListBox()
        {
            listBox1.Items.Clear();
            foreach (var x in customers.Where(x => x.Name == comboBox1.Text).ElementAt(0).Orders)
            {
                listBox1.Items.Add("Id: " + x.OrderNumber + ": " + x.OrderInfo);
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if(numericOrderId.Text == "")
            {
                MessageBox.Show("Please fill order ID");
                return;
            }
            try
            {
                customers.Where(x => x.Name == comboBox1.Text).ElementAt(0).Orders.Where(x => x.OrderNumber == numericOrderId.Text).ElementAt(0).OrderInfo = textBox2.Text;
                UpdateListBox();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Please select a Customer \n Error message: " + exception.Message);
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                customers.Where(x => x.Name == comboBox1.Text).ElementAt(0).addOrder(textBox2.Text);
                UpdateListBox();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Please select a Customer \n Error message: " + exception.Message);
            }
        }
    }
}
