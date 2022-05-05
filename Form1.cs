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
            try
            {
                label2.Text = $"{Inch((int)label1.Text):f1}";
            }
            catch(FormatException)
            {

            }
        }
        private double Inch(double km)
        {
            return 39370.1 * km;
        }
    }
}
