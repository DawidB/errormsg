using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DawidBurek.ErrorMsg;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ErrorMsg.EmailRecipient = "a@a.a";
            ErrorMsg.EmailSubject = "Temat maila";
            ErrorMsg.ErrorDetails = "szczegoly \n\n\nbledu...";

            MessageBox.Show("info", "text");//, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //ErrorMsg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ErrorMsg.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ErrorMsg.Show("tresc");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ErrorMsg.Show("tresc", "tytul");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ErrorMsg.Show("tresc", "tytul", ErrorMsgIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ErrorMsg.Show(richTextBox1.Text, "tytul", ErrorMsgIcon.Information, richTextBox1.Text);
        }
    }
}
