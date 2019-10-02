using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, z;
            if (double.TryParse(textBoxX.Text, out x) == false)
            {
                MessageBox.Show("Помилка введення значення x!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (double.TryParse(textBoxY.Text, out y) == false)
            {
                MessageBox.Show("Помилка введення значення y!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (double.TryParse(textBoxZ.Text, out z) == false)
            {
                MessageBox.Show("Помилка введення значення z!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            x = double.Parse(textBoxX.Text);
            y = double.Parse(textBoxY.Text);
            z = double.Parse(textBoxZ.Text);
            double a = 2 * Math.Cos(x * x) - 0.5;
            double a1 = Math.Pow(y, (2.0 - z));
            double b = 0.5 + Math.Sin(a1);
            double c = (z * z) / (7 - z / 3.0);
            double s = a / b + c;
            textBoxS.Text = s.ToString("F2");
        }
    }
}
