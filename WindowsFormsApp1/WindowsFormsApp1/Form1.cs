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

        int x = 0;
        int y = 0;       
        int ans1 = 0;
        int ans2 = 0;
        int ans3 = 0;
        int pos = 0;
      


        private int random_generator()
        {
            
            Random rnd = new Random();

            int x = rnd.Next(1, 10);
            int y = rnd.Next(1, 10);

            int ans1 = rnd.Next(1, 82);
            int ans2 = rnd.Next(1, 82);
            int ans3 = rnd.Next(1, 82);
            int pos = rnd.Next(1, 5);


            textBox3.Text = $"{x} * {y} = ?";
            if (pos == 1)
            {
                button1.Text = Convert.ToString(x * y);

                button2.Text = Convert.ToString(ans1);
                button3.Text = Convert.ToString(ans2);
                button4.Text = Convert.ToString(ans3);

            }
            else if (pos == 2)
            {
                button2.Text = Convert.ToString(x * y);

                button1.Text = Convert.ToString(ans1);
                button3.Text = Convert.ToString(ans2);
                button4.Text = Convert.ToString(ans3);
            }
            else if (pos == 3)
            {
                button3.Text = Convert.ToString(x * y);

                button1.Text = Convert.ToString(ans1);
                button2.Text = Convert.ToString(ans2);
                button4.Text = Convert.ToString(ans3);
            }
            else if (pos == 4)
            {
                button4.Text = Convert.ToString(x * y);

                button1.Text = Convert.ToString(ans1);
                button2.Text = Convert.ToString(ans2);
                button3.Text = Convert.ToString(ans3);
            }

            return pos;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Домашнее задание №3 Брехин Михаил УТС-22";
            label2.Text = "Правильных ответов:";
            label3.Text = "Неправильных ответов:";

            textBox2.Text = "0";
            textBox1.Text = "0";

            button1.Text = "Начать";
            button2.Text = "Начать";
            button3.Text = "Начать";
            button4.Text = "Начать";

            textBox3.Text = "x * y = ?";

        }

        



        int i = 0;
        int a = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Начать") 
            {
                i = random_generator();
            }

            else
            { 
                if (i == 1)
                {
                    textBox1.Text = (Convert.ToInt32(textBox1.Text) + 1).ToString();
                    textBox4.Text = "Правильно.";
                    textBox4.ForeColor = Color.Green;
                    textBox4.TabIndex = 60;
                }
                else
                {
                    textBox2.Text = (Convert.ToInt32(textBox2.Text) + 1).ToString();
                    textBox4.Text = "Неправильно.";
                    textBox4.ForeColor = Color.Red;
                    textBox4.TabIndex = 60;
                }

                i = random_generator();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (button2.Text == "Начать")
            {
                i = random_generator();
            }

            else
            {
                if (i == 2)
                {
                    textBox1.Text = (Convert.ToInt32(textBox1.Text) + 1).ToString();
                    textBox4.Text = "Правильно.";
                    textBox4.ForeColor = Color.Green;
                    textBox4.TabIndex = 60;
                }
                else
                {
                    textBox2.Text = (Convert.ToInt32(textBox2.Text) + 1).ToString();
                    textBox4.Text = "Неправильно.";
                    textBox4.ForeColor = Color.Red;
                    textBox4.TabIndex = 60;
                }

                i = random_generator();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (button3.Text == "Начать")
            {
                i = random_generator();
            }

            else
            {
                if (i == 3)
                {
                    textBox1.Text = (Convert.ToInt32(textBox1.Text) + 1).ToString();
                    textBox4.Text = "Правильно.";
                    textBox4.ForeColor = Color.Green;
                    textBox4.TabIndex = 60;
                }
                else
                {
                    textBox2.Text = (Convert.ToInt32(textBox2.Text) + 1).ToString();
                    textBox4.Text = "Неправильно.";
                    textBox4.ForeColor = Color.Red;
                    textBox4.TabIndex = 60;
                }

                i = random_generator();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (button4.Text == "Начать")
            {
                i = random_generator();
            }

            else
            {
                if (i == 4)
                {
                    textBox1.Text = (Convert.ToInt32(textBox1.Text) + 1).ToString();
                    textBox4.Text = "Правильно.";
                    textBox4.ForeColor = Color.Green;
                    textBox4.TabIndex = 60;
                }
                else
                {
                    textBox2.Text = (Convert.ToInt32(textBox2.Text) + 1).ToString();
                    textBox4.Text = "Неправильно.";
                    textBox4.ForeColor = Color.Red;
                    textBox4.TabIndex = 60;
                }

                i = random_generator();
            }

        
        }
    }
}
