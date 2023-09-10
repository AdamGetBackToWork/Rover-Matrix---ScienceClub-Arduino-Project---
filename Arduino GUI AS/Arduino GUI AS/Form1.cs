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

        List<int> indexes = new List<int>();

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

        private void button_0_Click(object sender, EventArgs e)
        {
            indexes.Add(0);
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            indexes.Add(1);
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            indexes.Add(2);
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            indexes.Add(3);
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            indexes.Add(4);
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            indexes.Add(5);
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            indexes.Add(6);
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            indexes.Add(7);
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            indexes.Add(8);
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            indexes.Add(9);
        }

        private void button_10_Click(object sender, EventArgs e)
        {
            indexes.Add(10);
        }

        private void button_11_Click(object sender, EventArgs e)
        {
            indexes.Add(11);
        }

        private void button_12_Click(object sender, EventArgs e)
        {
            indexes.Add(12);
        }

        private void button_13_Click(object sender, EventArgs e)
        {
            indexes.Add(13);
        }

        private void button_14_Click(object sender, EventArgs e)
        {
            indexes.Add(14);
        }

        private void button_15_Click(object sender, EventArgs e)
        {
            indexes.Add(15);
        }

        private void button_16_Click(object sender, EventArgs e)
        {
            indexes.Add(16);
        }

        private void button_17_Click(object sender, EventArgs e)
        {
            indexes.Add(17);
        }

        private void button_18_Click(object sender, EventArgs e)
        {
            indexes.Add(18);
        }

        private void button_19_Click(object sender, EventArgs e)
        {
            indexes.Add(19);
        }

        private void button_20_Click(object sender, EventArgs e)
        {
            indexes.Add(20);
        }

        private void button_21_Click(object sender, EventArgs e)
        {
            indexes.Add(21);
        }

        private void button_22_Click(object sender, EventArgs e)
        {
            indexes.Add(22);
        }

        private void button_23_Click(object sender, EventArgs e)
        {
            indexes.Add(23);
        }

        private void button_24_Click(object sender, EventArgs e)
        {
            indexes.Add(24);
        }

        private void button_25_Click(object sender, EventArgs e)
        {
            indexes.Add(25);
        }

        private void button_26_Click(object sender, EventArgs e)
        {
            indexes.Add(26);
        }

        private void button_27_Click(object sender, EventArgs e)
        {
            indexes.Add(27);
        }

        private void button_28_Click(object sender, EventArgs e)
        {
            indexes.Add(28);
        }

        private void button_29_Click(object sender, EventArgs e)
        {
            indexes.Add(29);
        }

        private void button_30_Click(object sender, EventArgs e)
        {
            indexes.Add(30);
        }

        private void button_31_Click(object sender, EventArgs e)
        {
            indexes.Add(31);
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            serialPort1.Write(indexes());
        }
    }
}
