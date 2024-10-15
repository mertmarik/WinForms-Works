using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace asansor
{
    public partial class Secenekler : Form
    {
        public Secenekler()
        {
            InitializeComponent();
        }

        ortakdegiskenler degiskennesnesi = new ortakdegiskenler();
                
        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            
            if (e.Node.Text == "Proje1" )
            {
                if (ortakdegiskenler.yetki == 1)
                {
                    this.Hide();
                    Proje1 secondform = new Proje1();
                    secondform.Show();
                }
                else
                {
                    MessageBox.Show("Yetkiniz Yok");
                }
            }
            else if (e.Node.Text =="Proje2")
            {
                if (ortakdegiskenler.yetki == 2)
                {
                    this.Hide();
                    Proje2 secondform = new Proje2();
                    secondform.Show();
                }
                else
                {
                    MessageBox.Show("Yetkiniz Yok");
                }
            }
            else if (e.Node.Text == "Proje3" )
            {
                if (ortakdegiskenler.yetki == 3)
                {
                    this.Hide();
                    Proje3 secondform = new Proje3();
                    secondform.Show();
                }
                else
                {
                    MessageBox.Show("Yetkiniz Yok");
                }
            }
            else if (e.Node.Text == "Proje4" )
            {
                if (ortakdegiskenler.yetki == 4)
                {
                    this.Hide();
                    Proje4 secondform = new Proje4();
                    secondform.Show();
                }
                else
                {
                    MessageBox.Show("Yetkiniz Yok");
                }
            }
            else if (e.Node.Text == "Form1" )
            {
                if (ortakdegiskenler.yetki == 5)
                {
                    this.Hide();
                    Form1 secondform = new Form1();
                    secondform.Show();
                }
                else
                {
                    MessageBox.Show("Yetkiniz Yok");
                }
            }
            else if (e.Node.Text == "Form2" )
            {
                if (ortakdegiskenler.yetki == 1 || ortakdegiskenler.yetki == 2)
                {
                    this.Hide();
                    Form2 secondform = new Form2();
                    secondform.Show();
                }
                else
                {
                    MessageBox.Show("Yetkiniz Yok");
                }
            }
            else if (e.Node.Text == "Form3" )
            {
                if (ortakdegiskenler.yetki == 3 || ortakdegiskenler.yetki == 4)
                {
                    this.Hide();
                    Form3 secondform = new Form3();
                    secondform.Show();
                }
                else
                {
                    MessageBox.Show("Yetkiniz Yok");
                }
            }
            else if (e.Node.Text == "Form4" && (ortakdegiskenler.yetki == 2 || ortakdegiskenler.yetki == 5))
            {
                if (ortakdegiskenler.yetki == 2 || ortakdegiskenler.yetki == 5)
                {
                    this.Hide();
                    Form4 secondform = new Form4();
                    secondform.Show();
                }
                else
                {
                    MessageBox.Show("Yetkiniz Yok");
                }
            }
         
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode secilen;
            secilen = treeView1.SelectedNode;
            if (radioButton1.Checked)
            {
                treeView1.Nodes.Add(textBox1.Text);
            }
            else if (radioButton2.Checked && secilen != null)
            {
                secilen.Nodes.Add(textBox1.Text);
            }            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            TreeNode secilen;
            secilen = treeView1.SelectedNode;
            if (!(secilen.Parent == null))
            {
                secilen.Parent.Nodes.Remove(secilen);

            }
            else
            {
                treeView1.Nodes.Remove(secilen);
            }
        }
        
    }
}
