using Lab2.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private SumController controller = new SumController();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            var text = "";
            if (textBox != null)
            {
                text = textBox.Text;
            }
            var value = 0.0d;
            if (double.TryParse(text, out value))
            {
                controller.ParamsModel.A = double.Parse(text);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            var text = "";
            if (textBox != null)
            {
                text = textBox.Text;
            }
            var value = 0.0d;
            if(double.TryParse(text, out value))
            {

                controller.ParamsModel.B = double.Parse(text);
                controller.CalculateSum();
                textBox3.Text = controller.SumModel.Sum.ToString();
            }
        }

    }
}
