using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_DELEGATE
{
    //ınvoke,begınInvoke,delegates,Delegates ile asenkron çalışmak.

    //Delegate ler birden fazla metodun aynı anda çalışmasını sağlar.


    public delegate void MesajVer(string mesaj);
    public delegate void DortIslem(int g,int h);
   
    public partial class Form1 : Form
    {
        void message(string msg) { 
        
        
        }
        void Toplam(int a,int b)
        {
            textBox1.Text = (a + b).ToString();
        
        }
        void Fark(int c, int d)
        {

            
                textBox2.Text = (c-d).ToString();

        }
        void Carpim(int e ,int f) {

            textBox3.Text = (e * f).ToString();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*Mesajver msg = new Mesajver(Message);
            msg.Invoke("MERHABA BU İLK DELEGATE ÇALIŞMAM");*/

            DortIslem islemler = new DortIslem(Toplam);
            islemler += Fark;
            islemler += Carpim;
          
            islemler(10, 5);

        }
    }
}
