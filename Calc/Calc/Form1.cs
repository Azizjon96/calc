using System;
using System.Windows.Forms;
using Calc.OneArgument;
using Calc.TwoArguments;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Operations(object sender, EventArgs e) 
        {
            double first = Convert.ToDouble(textBox1.Text);
            double second = Convert.ToDouble(textBox2.Text);
            ICalculate Calc = CalculatorFactory.CreateCalcuator(((Button)sender).Name);
            double result = Calc.Calculate(first, second);                    
             textBox3.Text = result.ToString();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OneClick(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(textBox1.Text);
            IoneCalculate Calc = SingleCalcFactory.CreateCalcuator(((Button)sender).Name);
            double result = Calc.Calculate(first);
            textBox3.Text = result.ToString();
            textBox2.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
