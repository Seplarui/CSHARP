using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, Resultado;
            x = double.Parse(textBox1.Text);
            y = double.Parse(textBox2.Text);

            Resultado = x + y;
            label4.Text = Convert.ToString(Resultado);
        }
    }
}
