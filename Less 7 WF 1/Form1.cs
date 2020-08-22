using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Less_7_WF_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bu_lic(object sender, EventArgs e)
        {
            
            Button  btn = (Button)sender;
            this.textBox1.Text += int.Parse(btn.Text);
        }


        private void Form1_Shown(object sender, EventArgs e)
        {
           for (int i = 0; i<10; i++)
            {
                Button button = new Button();
                button.Text = i.ToString();
                button.Left = 10+i*button.Width;
                button.Top = 10;
                button.Name = "Button " + i.ToString();
                this.Controls.Add(button);
                button.Click += Bu_lic;

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
