using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CompositionHelper;

namespace CalculatorUsingMEF
{
    public partial class Form1 : Form
    {
        CalculatorCompositionHelper helper;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoOperation("Add");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoOperation("Subtract");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DoOperation("Multiply");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DoOperation("Divide");
        }

        private void DoOperation(string operationType)
        {
            helper = new CalculatorCompositionHelper();
            helper.AssembleCalculatorComponents();
            var result = helper.Execute(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), operationType);
            textBox3.Text = result.ToString();
        }
    }
}
