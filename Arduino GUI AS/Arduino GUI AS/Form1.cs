using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino_GUI_AS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort1.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("A");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("B");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.Write("a");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.Write("F");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            serialPort1.Write("f");
        }

        private void LEDiterations_Click(object sender, EventArgs e)
        {
            string m1 = "S" + textBox1.Text;
            serialPort1.Write(m1);
        }
    }
}
