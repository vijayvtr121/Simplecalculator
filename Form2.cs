using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SImpleCalculator
{
    public partial class Form2 : Form
    {
        Double resultvalue = 0;
        String operationperformed = " ";
        bool isoperationperformed = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBox1_result.Text == "0"||(isoperationperformed))
                textBox1_result.Clear();
            isoperationperformed = false;
            Button button = (Button)sender;
            

            textBox1_result.Text = textBox1_result.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(resultvalue!=0)
            {
                button8.PerformClick();
                operationperformed = button.Text;
               
                labelcurrentoperation.Text = resultvalue + " " + operationperformed;
                isoperationperformed = true;
            }
        else
            operationperformed = button.Text;
            resultvalue = Double.Parse(textBox1_result.Text);
            labelcurrentoperation.Text = resultvalue + " " + operationperformed;
            isoperationperformed = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            switch(operationperformed)
            {
                case "+":
                    textBox1_result.Text=(resultvalue + Double.Parse(textBox1_result.Text)).ToString();
                    break;
                case "-":
                    textBox1_result.Text = (resultvalue - Double.Parse(textBox1_result.Text)).ToString();
                    break;
                default:
                    break;


            }
            resultvalue = Double.Parse(textBox1_result.Text);
            labelcurrentoperation.Text = " ";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1_result.Text = "0";
            resultvalue = 0;
        }
    }
}
