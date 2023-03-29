using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace TeknoKaucukYazılım_Test_1_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textbox_input.TextAlign = HorizontalAlignment.Center;
            fibonacci_output.TextAlign = HorizontalAlignment.Center;
            textBox2.Visible = false;   
            l2.Visible = false;
            fibonacci_output2.Visible = false;
            l3.Visible = false;
            fibonacci_output.Visible = false;
        }

        //İŞLEVSELLİK #3
        private void button_mtable_Click(object sender, EventArgs e)
        {
            textbox_multiplication_table.Clear(); //Textbox'ı sıfırlar. Bunu yapmamın sebebi kullanıcı bir tabloyu listeledikten sonra
            //başka bir tablo listelemek isterse sadece yeni tabloyu görmelidir bu nedenle önceki tablo silinmelidir. 
            if (String.IsNullOrEmpty(textbox_input.Text)) //Textbox null olduğunda kodun patlayıp hata vermemesi için null kontrolü yaptım.
            {
                MessageBox.Show("Bir sayı giriniz"); //hata mesajı
            }
            else //textbox boş değilse 
            {
                int input = int.Parse(textbox_input.Text);
                if (input <= 15 && input > 0) //Girilen input'un 0 dan büyük 15 den küçük olması gerekmektedir
                {
                    for (int i = 1; i <= input; i++)
                    {
                        for (int j = 1; j <= input; j++)
                        {

                            int result = i * j;
                            textbox_multiplication_table.Text += "\t" + result;
                        }
                        textbox_multiplication_table.Text += "" + Environment.NewLine; //alt satıra inebilmek için
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen belirtilen aralıkta sayı giriniz!");
                }
            }
        }

        //İŞLEVSELLİK #4
        private void button1_Click(object sender, EventArgs e)
        {                 
            Stream stream = null; //verinin parça parça işlenebilmesi için 
            OpenFileDialog file = new OpenFileDialog(); 
            file.Filter = "Text|*.txt"; //Sadece txt dosyaları geçerlidir

            if (file.ShowDialog() == DialogResult.OK) //kullanıcı seçimi onaylarsa
            {
                try
                {
                    if ((stream = file.OpenFile())!=null) // açılan dosya boş değilse
                    {
                        using (stream)
                        {
                            textBox2.Text = File.ReadAllText(file.FileName); //Textbox'ın içine tüm veriler yazılır.
                        }
                    }
                }
                catch (Exception ex) //hata oluşması durumunda çalışacak olan blok. Aksi takdirde hata oluşması durumunda program patlar.
                {
                    MessageBox.Show("İşlem Gerçekleştirilemedi");
                }
            }

            List<decimal> numbers = new List<decimal>(); //decimal veri tipinde liste
            for (int i = 0; i < textBox2.Lines.Count(); i++)//textbox2'deki satır sayısı kadar 
            {
                //string veri tipinde line adında bir dizi oluşturduk ve textbox2'deki her satırı split fonksiyonu ile ayırdık, boş olanları
                //RemoveEmptyEntries metodu ile sildik.
                string[] line = textBox2.Lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                
                foreach (string item in line) //line dizisindeki her bir itemi parse metodu ile decimal'a çevirere numbers dizisine ekledik.
                    //decimal'a çevirmemizin sebebi number dizisinin veri tipinin decimal olması.
                {
                    numbers.Add(decimal.Parse(item, NumberStyles.Number, new CultureInfo("tr-TR")));
                }
            }

            //numbers dizisindeki her bir item (decimal d) büyükten küçüğe şeklinde sıralanır ve listbox'a eklenir.
            foreach(decimal d in numbers.OrderByDescending( x=> x)) 
            {
                listBox1.Items.Add(d.ToString());
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //İŞLEVSELLİK 5
        private void button2_Click(object sender, EventArgs e)
        {   //Gizlenen bileşenlerin gösterilmesi
            l2.Visible = true;
            fibonacci_output2.Visible = true;
            l3.Visible = true;
            fibonacci_output.Visible = true;

            //İşlem tekrarlanmak istenirse önceki verilerin sillinmesi için clear metodunu kullandım. 
            fibonacci_output.Clear();
            fibonacci_output2.Clear();

            if ((String.IsNullOrEmpty(fibonacci_input.Text))) //null kontrolü
            {
                MessageBox.Show("Bir sayı giriniz");
            }
            else
            {
                int input = int.Parse(fibonacci_input.Text); //kullanıcıdan alınan veri input değişkenine assign edilir. 
                int a = 0; //fibonacci sayılarının ilki
                int b = 1; //fibonacci sayılarının ikincisi
                int c; //a ve b nin toplamları olacak 3.sayı
                string[] fibonacci = new string[input]; //string türünde fibonacci adında bir dizi oluşturdum. Bu diziyi oluşturmamın sebebi
                                                        //istenilen fibonacci sayısına kadar olan diğer sayılarıda kullanıcıya gösterebilmek için.
                fibonacci[0] = a.ToString(); //ilk sayıyı diziye ekledim.
                fibonacci[1] = b.ToString();
                for (int i = 2; i < input; i++) //dizinin ilk 2 item'ı dolu olduğu için döngüyü 2 den başlattım çünkü i değişkenini dizinin
                                                //index'i olarak kullanıyorum.
                {
                    c = a + b;
                    a = b;
                    b = c;
                    fibonacci_output.Text += "\t" + c; //fibonacci sayıları
                    fibonacci[i] = c.ToString();
                    fibonacci_output2.Text = fibonacci[input - 1]; //istenilen sıradaki fibonacci sayısı
                }
            }
            
        }
    }
}
