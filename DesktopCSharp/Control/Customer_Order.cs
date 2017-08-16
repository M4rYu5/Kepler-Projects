using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestLib;

namespace Control
{
    public partial class Customer_Order : Form
    {
        public Customer_Order()
        {
            InitializeComponent();
        }

        private List<Customer> customers = new List<Customer>();
        private void button1_Click(object sender, EventArgs e)
        {
            customers.Add(new Customer(textBox1.Text));

            RefreshComboList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                customers.Where(x => x.Name == comboBox1.Text).ElementAt(0).addOrder(textBox2.Text);
                UpdateListBox();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Please select a Customer \n Error message: "  + exception.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                customers.Where(x => x.Name == comboBox1.Text).ElementAt(0).Orders.Where(x => x.OrderNumber == ((int)(numericUpDown1.Value)).ToString()).ElementAt(0).OrderInfo = textBox2.Text;
                UpdateListBox();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Please select a Customer \n Error message: " + exception.Message);
            }
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

    }
}
