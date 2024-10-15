using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asansor
    

{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        int i=0;
        bool sirala = false;

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            await Task.Delay(1500);
            button1.Enabled = true;

            if (!sirala)
            {
                sirala = true;
                Random sayilar = new Random();
                List<int> elemanlar = new List<int>();


                for (int i = 0; i < 20; i++)
                {
                    int sayi = sayilar.Next(1, 100);
                    textBox1.Text = sayi.ToString();
                }
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Ceren";
        }
        //public async void button1_EventHandler(object sender, EventArgs e)
        //{

        //    // Do something

        //    button1.Enabled = false;
        //    await Task.Delay(2000);
        //    button1.Enabled = true;
        //}
    }
}
