using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_task2
{
    public partial class Form1 : Form
    {
        int Totalbill = 0;
        int Totalproduct = 0;
        int price = 0;
        int Price1, Price2, Price3,Price4,Price5,Price6;

        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                numericUpDown1.Enabled = true;
                comboBox1.Enabled = true;
                Totalproduct++;
            }
            /*else
            {
                numericUpDown1.Enabled = false;
                comboBox1.Enabled = false;
                //Totalproduct--;

            }*/


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                numericUpDown2.Enabled = true;
                comboBox2.Enabled = true;
                Totalproduct++;
            }
            else
            {
                numericUpDown2.Enabled = false;
                comboBox2.Enabled = false;
               //Totalproduct--;

            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                numericUpDown3.Enabled = true;
                comboBox3.Enabled = true;
                Totalproduct++;
            }
            else
            {
                numericUpDown3.Enabled = false;
                comboBox3.Enabled = false;
                //Totalproduct--;

            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox4.Checked == true)
            {
                numericUpDown4.Enabled = true;
                comboBox4.Enabled = true;
                Totalproduct++;
            }
            else
            {
                numericUpDown4.Enabled = false;
                comboBox4.Enabled = false;
                //Totalproduct--;

            }

        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                numericUpDown5.Enabled = true;
                comboBox5.Enabled = true;
                Totalproduct++;
            }
            else
            {
                numericUpDown5.Enabled = false;
                comboBox5.Enabled = false;
                //Totalproduct--;

            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            DateTime timeNow = DateTime.Now;
            textBox3.Text = timeNow.ToString();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox6.Checked == true)
            {
                numericUpDown6.Enabled = true;
                comboBox6.Enabled = true;
                Totalproduct++;
            }
            else
            {
                numericUpDown6.Enabled = false;
                comboBox6.Enabled = false;
                //Totalproduct--;

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           /* if (radioButton1.Checked == true)
            {
                price = price + 20;
            }*/
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked == true)
            {
            }

        }


       private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox2.Text = price.ToString();
        }
       
        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime timeNow = DateTime.Now;
            textBox3.Text = timeNow.ToString();
            groupBox2.Visible = true;
                if (checkBox1.Checked == true)
                {

                    label11.Text = "Apple";
                   // label13.Text = (numericUpDown1.Value).ToString();
                    if(comboBox1.Text=="High Quality")
                    {
                    price = 200;
                    label13.Text = numericUpDown1.Value.ToString();
                    Price1 = (int)(numericUpDown1.Value * price);
                    label17.Text = Price1.ToString();
                    }
                    else 
                    {
                    price = 150;
                    label13.Text = numericUpDown1.Value.ToString();
                    Price1 = (int)(numericUpDown1.Value * price);
                    label17.Text = Price1.ToString();
                    }
                textBox1.Text = Totalproduct.ToString();
                Totalbill += Price1;
             

                }
                if (checkBox2.Checked == true)
                {
                    label3.Text = "Orange";
                    label21.Text = (numericUpDown1.Value).ToString();
                    if (comboBox2.Text == "High Quality")
                    {
                    price = 200;
                    label21.Text = numericUpDown2.Value.ToString();
                    Price2 = (int)(numericUpDown2.Value * price);
                    label10.Text = Price2.ToString();
                     }
                    else
                    {
                    price = 200;
                    label21.Text = numericUpDown2.Value.ToString();
                    Price2 = (int)(numericUpDown2.Value * price);
                    label10.Text = Price2.ToString();
                     }
                textBox1.Text = Totalproduct.ToString();
                Totalbill += Price2;

            }

                if (checkBox3.Checked == true)
                {
                    label14.Text = "Mango";
                    label4.Text = (numericUpDown1.Value).ToString();
                    if (comboBox2.Text == "High Quality")
                    {
                    price = 200;
                    label4.Text = numericUpDown3.Value.ToString();
                    Price3 = (int)(numericUpDown3.Value * price);
                    label5.Text = Price3.ToString();
                }
                    else 
                    {
                    price = 200;
                    label4.Text = numericUpDown3.Value.ToString();
                    Price3 = (int)(numericUpDown3.Value * price);
                    label5.Text = Price3.ToString();
                }
                textBox1.Text = Totalproduct.ToString();
                Totalbill += Price3;
            }

                if (checkBox4.Checked == true)
                {
                    label12.Text = "PineApple";
                    label22.Text = (numericUpDown1.Value).ToString();
                    if (comboBox2.Text == "High Quality")
                    {
                    price = 200;
                    label22.Text = numericUpDown4.Value.ToString();
                    Price4 = (int)(numericUpDown4.Value * price);
                    label9.Text = Price4.ToString();
                   
                }
                    else 
                    {
                    price = 200;
                    label22.Text = numericUpDown4.Value.ToString();
                    Price4 = (int)(numericUpDown4.Value * price);
                    label9.Text = Price4.ToString();
                }
                textBox1.Text = Totalproduct.ToString();
                Totalbill += Price4;
            }


                if (checkBox5.Checked == true)
                {
                    label16.Text = "Peach";
                    label19.Text = (numericUpDown1.Value).ToString();
                    if (comboBox2.Text == "High Quality")
                    {
                    price = 200;
                    label19.Text = numericUpDown5.Value.ToString();
                    Price5 = (int)(numericUpDown5.Value * price);
                    label18.Text = Price5.ToString();
                }
                    else
                    {
                    price = 200;
                    label19.Text = numericUpDown5.Value.ToString();
                    Price5 = (int)(numericUpDown5.Value * price);
                    label18.Text = Price5.ToString();
                }
                textBox1.Text = Totalproduct.ToString();
                Totalbill += Price5;

            }

                if (checkBox6.Checked == true)
                {
                    label20.Text = "PineApple";
                    //label24.Text = (numericUpDown1.Value).ToString();
                    if (comboBox2.Text == "High Quality")
                    {
                    price = 200;
                    label24.Text = numericUpDown6.Value.ToString();
                    Price6 = (int)(numericUpDown6.Value * price);
                    label23.Text = Price6.ToString();
                }
                    else
                    {
                    price = 200;
                    label24.Text = numericUpDown6.Value.ToString();
                    Price6 = (int)(numericUpDown6.Value * price);
                    label23.Text = Price6.ToString();
                }
                Totalbill += Price6;

            }

           
            if (radioButton1.Checked == true)
            {
               
            }
            if (radioButton1.Checked == true)
            {
                Totalbill = Totalbill + 20;
            }
            textBox2.Text = Totalbill.ToString();
           // MessageBox.Show(Totalbill.ToString());
        }
    }
}
