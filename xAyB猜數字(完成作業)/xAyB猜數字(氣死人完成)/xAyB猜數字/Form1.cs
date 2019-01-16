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
        int[] d = new int[4];
        int A, B;
        int Secondary;
        int[] temp=new int[4];

        private void Form1_Load(object sender, EventArgs e)
        {
            int choice;
            bool if_exist;
            int[] ans = new int[10];

            label1.Text = "你猜不到勒!!...";
            label1.Font = new Font("標楷體", 20, FontStyle.Regular);
            label2.Text = "請在以下欄位輸入數字";
            label2.Font = new Font("標楷體", 18, FontStyle.Regular); Random r = new Random();




            for (int i = 0; i < 4; i++)
            {

                if (i == 0)
                {
                    d[i] = r.Next(0, 9);

                }
                else
                {
                    do
                    {
                        if_exist = false;
                        choice = r.Next(0, 9);

                        for (int j = 0; j < i; j++)
                        {
                            if (d[j] == choice)
                                if_exist = true;

                        } //end for j

                    } while (if_exist);
                    d[i] = choice;
  //                             MessageBox.Show("debug "+d[0] + " " + d[1] + " " + d[2] + " " + d[3]);

                }

            } //end for i



        }



        private void button1_Click(object sender, EventArgs e)
        {
            int[] myans = new int[4];

            Random r = new Random();

            int A = 0;
            int B = 0;
           
            

            // MessageBox.Show("debug "+d[0] + " " + d[1] + " " + d[2] + " " + d[3]);
            try
            {
                myans[0] = int.Parse(textBox1.Text.Substring(0, 1));
                myans[1] = int.Parse(textBox1.Text.Substring(1, 1));
                myans[2] = int.Parse(textBox1.Text.Substring(2, 1));
                myans[3] = int.Parse(textBox1.Text.Substring(3, 1));

            }

            catch
            {
                MessageBox.Show("請輸入4個數字");

            }
           // myans[0] = int.Parse(textBox1.Text);
           // myans[1] = int.Parse(textBox2.Text);
            //myans[2] = int.Parse(textBox3.Text);
            //myans[3] = int.Parse(textBox4.Text);




            for (int i = 0; i < 4; i++)
            {


                //do {
                // if_copy = false;


                for (int j = 0; j < i; j++)
                {
                    if (myans[j] == myans[i])
                    {
                        MessageBox.Show("請輸入四個不同的數字");
                       
                        return;
                    }

                }
            } // END FOR I
        ///------------------------------------------------------------------以下為比較輸入與答案

            for (int x = 0; x < 4; x++)
            {

                for (int y = 0; y < 4; y++)
                {
                    if (d[x] == myans[y])
                    {
                        if (x == y)
                            A++;
                        else
                            B++;
                        
                    }

                } // END FOR Y
                

            } //END FOR x
            
            Secondary++;

            //richBox顯示你的輸入與答案的幾A幾B
            richTextBox1.Text += "第" + Secondary +"輸入:" + myans[0].ToString() + myans[1].ToString() + myans[2].ToString() + myans[3].ToString() + "    你答對了:" + A + "A" + B + "B\n";    

        

            //MessageBox.Show(A + "A" + B + "B");
            if (A == 4)
                MessageBox.Show("冰狗");

           
        }
      
        /*private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("button2  fuck");
            Form1_Load(sender, e);

        }*/

        /*private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button3 fuck");
            if (MessageBox.Show("請問是否離開遊戲嗎？", "猜數字遊戲", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }
        */
        private void button2_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("button2");
            
            Form1_Load(sender, e);
            textBox1.Text="";
            //textBox2.Text = "";
            //textBox3.Text = "";
            //textBox4.Text = "";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
          // MessageBox.Show("button3");
            if (MessageBox.Show("請問是否離開遊戲嗎？", "猜數字遊戲", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }  //END FOR BUTTON_CLICK

    }
}
