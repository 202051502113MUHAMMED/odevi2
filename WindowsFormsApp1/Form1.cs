using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void nothsaplama(object sender, EventArgs e)
        {
              double vize, final, ortalama;
            try
            {

               vize = Convert.ToDouble(textBox1.Text);
               final = Convert.ToDouble(textBox2.Text);
               ortalama = vize * 0.4 + final * 0.6;
                    label3.Text = ortalama.ToString();
                if (ortalama >= 50 && final >= 50 )
                {
                    MessageBox.Show("Geçti");
                   
                }
                else
                {
                    MessageBox.Show("kaldı");
                }
         
                     
              
            }
              catch (Exception ex)

            {

                if(textBox1.Text != "" && textBox2.Text != ""  )
                {
                    MessageBox.Show("lütfen sayi giriniz");
                }
            }
       

        }
    }
}
