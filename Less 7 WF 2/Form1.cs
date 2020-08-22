using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Less_7_WF_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          Form_C = new Form2();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Text = "Мой первы графический интерфейс ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Form_C.Show();
            label1.Text = "данный текст появляется при нажатии на кнопку";
            label2.Text = " text";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_C.Hide() ;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button2.Text = textBox1.Text;
          //  button2.Width += 2;
        }
    }
}
