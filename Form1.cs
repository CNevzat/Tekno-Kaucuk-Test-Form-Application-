using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TeknoKaucukYazılım_Test_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Hand; //Mouse resmin üzerine geldiğinde "Hand" cursor'una dönüşür. 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //İŞLEVSELLİK #1
        private void button1_Click(object sender, EventArgs e)
        {      
            //textbox'lara girilen inputların değişkenlere assign edilmesi
            int number_1 = int.Parse(input1.Text);
            int number_2 = int.Parse(input2.Text);
            int number_3 = int.Parse(input3.Text);

            //işlem
            int result = (number_1 + number_2) * number_3;

            textbox_result.Text = result.ToString();  //sonucun textbox'da gösterilmesi
            textbox_result.ReadOnly = true; //Kullanıcı sonuç textbox'ında düzenleme yapamaz. 
        }
        //İŞLEVSELLİK #2
        private void button2_Click(object sender, EventArgs e)
        {   
            //Bu işlem birden fazla yerden kullanılmak istendiğinde method içerisinde yazılıp burada çağrılabilirdi.    
            for (int i = 1; i < 200; i++)
            {
                if (i % 3 == 0 && i % 5 == 0 && i <= 100)
                {
                    textbox_output.Text += "zigzag ";
                }
               else if (i % 3 == 0 && i % 5 == 0 && i > 100)
                {
                    textbox_output.Text += "zagzig ";
                }
               else if (i % 3 == 0)
                {
                    textbox_output.Text += "zig ";
                }
               else if (i % 5 == 0)
                {
                    textbox_output.Text += "zag ";
                }
                else
                {
                    textbox_output.Text += i + " ";
                }
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {     
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(); //Diğer forma geçmek için ikinci formdan bir nesne türettim ve show metodu ile geçiş sağladım.
            frm2.Show();
            this.Hide();
        }
    }
}
