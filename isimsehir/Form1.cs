using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace isimsehir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] harfler = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "İ", "Ç", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" };
        //string[] harfler = new string[] { "A" }; // A harfi seçildiğinde isimlerin, isimler dizisinden kontrolü için deneme amacı ile

        string[] isimler = new string[] { "Ali", "Ahmet", "Ayhan", "Ayşe", "Aynur", "Ayşenur", "Abdullah", "Açelya","Adalet","Adile"
        ,"Ahsen","Ajda","Alev","Anıl","Arife","arzu","asena","asiye","aslı","aslıhan","asu","asude","asya","asuman","ayben","ayfer","aybike"
        ,"ayça","aydoğan","aygün","ayla","ayperi","aysel","aysu","aysun","ayşegül","ayten","azize","azra","abbas","abulaziz","abdulhamit"
        ,"abdulkerim","Abdurrahman","Abidin","Abuzer","adal","adil","ayhan","adnan","alp","alper","akif","akman","aktan","alaaddin","aladdin"
        ,"alican","alişan","alperen","altay","anıl","arda","arif","akif"};
        int saniye = 60;


        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            timer1.Interval = 1000;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int sayı = random.Next(harfler.Count());
            label1.Text =  harfler[sayı];
            timer1.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (label1.Text.Length > 0)
            {
                timer1.Enabled = true;
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Harf seçilmedi...Harf seçiniz");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye--;
            panel1.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            button1.Enabled = false;
            if (saniye > 0)
            {
                label10.Text = "Kalan Süre:" + saniye.ToString();

            }
            
            
            if (saniye == 0)
            {
                
                panel1.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                label10.Text = "Kalan Süre:Bitti" ;
                saniye = 0;
                MessageBox.Show("süre bitti");
                button2.Enabled = false;
               
                

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
           
           
           
           
            if (timer1.Enabled == true)
            {
                if (label1.Text.Length > 0)
                {
                    timer1.Enabled = false;
                    panel1.Enabled = false;
                    textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                    string harf = label1.Text;
                    int kontrol = 0;
                    int puan = 0;
                  
                    
                    
                        if (textBox1.Text == "") { kontrol = 1; puan += 0; }
                     else   if (textBox1.Text.ToUpper().Substring(0, 1) == harf && textBox1.Text.Length >= 2) { kontrol = 1; puan += 10; }

                        
                    if (textBox2.Text=="") { kontrol = 2; puan += 0; }
                    else if(textBox2.Text.ToUpper().Substring(0, 1) == harf && textBox2.Text.Length >= 3)
                    {
                        kontrol = 2; puan += 10;
                    }


                   
                    if (textBox3.Text == "") { kontrol = 3; puan += 0; }
                    else if (textBox3.Text.ToUpper().Substring(0, 1) == harf && textBox3.Text.Length >= 2) { kontrol = 3; puan += 10; }
                    if (textBox4.Text == "") { kontrol = 4; puan += 0; }
                    else if (textBox4.Text.ToUpper().Substring(0, 1) == harf && textBox4.Text.Length >= 2) { kontrol = 4; puan += 10; }
                    if (textBox5.Text == "") { kontrol = 5; puan += 0; }
                    else if (textBox5.Text.ToUpper().Substring(0, 1) == harf && textBox5.Text.Length >= 3) { kontrol = 5; puan += 10; }
                    if (textBox6.Text == "") { kontrol = 6; puan += 0; }
                    else if (textBox6.Text.ToUpper().Substring(0, 1) == harf && textBox6.Text.Length >= 5) { kontrol = 6; puan += 10; }

                        if (kontrol == 6)
                        {
                            MessageBox.Show( "Puanınız: " + puan.ToString());
                        button2.Enabled = false;
                        }
                       
                        label3.Text = "Puan : " + puan.ToString();
                    
                    }
                else
                    {
                        MessageBox.Show("Harf seçilmedi");
                    }
                }
                else
                {
                    MessageBox.Show("Zamanı başlatmadınız.");
                }
            }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms[0] == this)//Uygulamanin main form'u
            {
                //uygulamanin ana formunu kapatirsaniz uygulama kapanir, ana formu yeniden baslatmak uygulamayi yeniden baslatmak demektir.
                Application.Restart();
            }
            else
            {
                Form1 f = new Form1();
                f.Show();
                this.Close();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
    } 
    

