using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Английская_система_мер_длины
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

         private void button1_Click(object sender, EventArgs e)
        {
            double inch;
            try
            {
                if (double.Parse(textBox1.Text) > 0)
                {
                    inch = Inch(double.Parse(textBox1.Text));
                    label2.Text = $"{inch:f2} дюймов\n{inch * 12:f2} футов\n{inch * 36:f2}" +
                    $" ярдов\n{inch * 36 * 1760:f2} миль\n{inch * 36 * 1760 * 3.452:f3} морских лиг";//ААААААААААААААААААААААААААААААААААААААААААААААААААААААА
                }
                else label2.Text = "Введено неположительное значение";
                
            }
            catch (FormatException)
            {
                label2.Text = "введено нечисловое значение";
            }
        }
        private double Inch(double km)
        {
            return 39370.1 * km;
        }
    }
}
