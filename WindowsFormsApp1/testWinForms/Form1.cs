using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                System.Threading.Thread.Sleep(1000);
                textBox1.Text = i.ToString();
            }

            // 일부러 exception을 만듦.
            String a = null;
            a.ToString();
        }
    }
}
