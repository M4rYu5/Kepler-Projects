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
using WpfAppTestCS;

namespace Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butonPressed(object sender, EventArgs e)
        {
            string option= textBox1.Text;
            if (option.Any() && int.Parse(option) <= 16)
            {
                System.Diagnostics.Process.Start("Teste.exe", option);
            }
        }

        private void keyPressedController(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(Exercitiul1.message(), "Exercitiul 1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Exercitiul2.hyMessage(textBox2.Text), "Exercitiul 2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Exercitiul3.hyMessage(textBox3.Text, checkBox2.Checked), "Exercitiu 3");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Exercitiul4.message(new DateTime((int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value)), "Exercitiu 4");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Customer_Order customerForm = new Customer_Order();
            customerForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show(); //I added a couple of reference to be able to do this :)
        }
    }
}
