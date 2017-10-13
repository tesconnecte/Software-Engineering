using CompositionHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            helper = new CalculatorCompositionHelper();
            helper.AssembleCalculatorComponents();

            var result = helper.Execute(Convert.ToDouble(textBox1.Text),
                                        Convert.ToDouble(textBox2.Text),"Add");
            textBox3.Text = result.ToString();
        }
    }

}
