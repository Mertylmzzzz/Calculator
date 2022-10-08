using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void sıfırsil()
        {
            if(label1.Text=="0")
            {
                label1.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sıfırsil();
            label1.Text = label1.Text + button3.Text;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sıfırsil();
            label1.Text = label1.Text + button1.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sıfırsil();
            label1.Text = label1.Text + button2.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sıfırsil();
            label1.Text = label1.Text + button4.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            sıfırsil();
            label1.Text = label1.Text + button5.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            sıfırsil();
            label1.Text = label1.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sıfırsil();
            label1.Text = label1.Text + button7.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            sıfırsil();
            label1.Text = label1.Text + button8.Text;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            sıfırsil();
            label1.Text = label1.Text + button9.Text;

        }

        private void button10_Click(object sender, EventArgs e)
        {

            button10.Text = "0";
            label1.Text = label1.Text + button10.Text;


        }

        int sayi = 0;
        int faktoriyell = 1;
        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            sayi = sayi2;
            sayi = sayi3;
            faktoriyel = faktoriyell;
            
            

        }

        private void button13_Click(object sender, EventArgs e)
        {
            label4.Text = "+";
            
            label2.Text = label1.Text;
            sayi2 = Convert.ToInt16(label2.Text);
            label1.Text = "";

           
            
            
        }
        int sayi3 = 0;
        int sayi2 = 0;
        private void button12_Click(object sender, EventArgs e)
        {
            if (label4.Text == "+")
            {
                sayi3 = Convert.ToInt16(label1.Text);
                int toplam = sayi2 + sayi3;
                label1.Text = toplam.ToString();
            }
             if(label4.Text=="-")
             {
                sayi3 = Convert.ToInt16(label1.Text);
                int cıkarma = sayi2 - sayi3;
                label1.Text = cıkarma.ToString();
             }
             if(label4.Text=="x")
            {
                sayi3 = Convert.ToInt16(label1.Text);
                int carpma = sayi2 * sayi3;
                label1.Text = carpma.ToString();
                
            }
             if(label4.Text=="/")
            {
                sayi3= Convert.ToInt16(label1.Text);
                int bolme = sayi2 / sayi3;
                label1.Text = bolme.ToString();

            }
             if(label4.Text=="kare")
            {
                int kareal = sayi2 * sayi2;
                label1.Text = kareal.ToString();
            }
             if(label4.Text=="kup")
            {
                int islem = sayi2 * sayi2 * sayi2;
                label1.Text=islem.ToString();   
                
            }
             if(label4.Text=="faktoriyel")
            {
                for (int i = 1; i <= sayi2 ; i++)
                {
                   
                     faktoriyel*= i;
                    
                }
                label1.Text = faktoriyel.ToString();

            }
             
        }
        int faktoriyel = 1;
        
        private void button14_Click(object sender, EventArgs e)
        {
            label4.Text = "-";
            label2.Text = label1.Text;
            sayi2 = Convert.ToInt16(label2.Text);
            label1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label4.Text = "x";
            label2.Text = label1.Text;
            sayi2 = Convert.ToInt32(label2.Text);
            label1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label4.Text = "kup";
            label2.Text = label1.Text;
            sayi2=Convert.ToInt32(label2.Text);



        }

        private void button15_Click(object sender, EventArgs e)
        {
            label4.Text = "/";
            label2.Text = label1.Text;
            sayi2 = Convert.ToInt32(label2.Text);
            label1.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            label4.Text = "kare";
            label2.Text = label1.Text;
            sayi2 = Convert.ToInt32(label2.Text);
            label1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label4.Text = "faktoriyel";
            label2.Text = label1.Text;
            sayi2 = Convert.ToInt32(label2.Text);
            label1.Text = "";
        }
    }
}
