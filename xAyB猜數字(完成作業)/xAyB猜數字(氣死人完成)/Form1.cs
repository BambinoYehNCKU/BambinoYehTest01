using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace xAyB猜數字
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // int myGuess;
            //myguess = txtGuess.Text;
            /*for (int i = 1; i <=4; i++)
            {
                //TextBox q = new TextBox();
                //listBox1.Items.Add(textBox1.Text);
                textBox1.ShortcutsEnabled = false; 
            }*/


            label1.Text = "你猜不到勒!!...";
            label1.Font = new Font("標楷體", 20, FontStyle.Regular);
            label2.Text = "請在以下欄位輸入數字";
            label2.Font = new Font("標楷體", 18, FontStyle.Regular);




            Random r = new Random();
            // int PCradan = r.Next(10);

            int[] ans = new int[10];
            // int pcans;
            for (int i = 0; i < ans.GetUpperBound(0); i++)
            {


                ans[i] = (r.Next(10) + 1) / 2;
                //ansbox.Text =  ans[i]";
                //pcans+=ans[i].ToString()+",";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* string t;
                 if (t = textBox1.Text.Length + textBox2.Text.Length + textBox3.Text.Length + textBox4.Text.Length)
                   if (t.Length != 4)
                 MessageBox.Show("請輸入四個數!");
                   return;
               }*/
            int myguess = 0;
            try
            {
                myguess = int.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("請輸入數字");
            }
        }
    }
}
