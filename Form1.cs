using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a;

            // Отримуємо значення, введене в textBox1 і перетворюємо його на тип double.
            a = Convert.ToDouble(textBox1.Text);

            // Обчислюємо площу (S) та об'єм (V) куба.
            double S = 6 * a * a;
            double V = a * a * a;

            // Відображаємо результати в textBox2 і textBox3.
            textBox2.Text = Convert.ToString(S);
            textBox3.Text = Convert.ToString(V);
        }
    }
}