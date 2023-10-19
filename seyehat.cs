using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İl_İlçe_Seyehat
{
    public partial class seyehat : Form
    {
        public seyehat()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            {
                listBox1.Items.Add(comboBox3.Text);
                listBox3.Items.Add(textBox1.Text);
                listBox4.Items.Add(textBox2.Text);
                listBox5.Items.Add(comboBox1.Text);
                listBox7.Items.Add(dateTimePicker1.Text);
                listBox8.Items.Add(comboBox2.Text);
                if (radioButton1.Checked == true)
                {
                    listBox6.Items.Add(radioButton1.Text);
                }
                else if(radioButton2.Checked == true)
                {
                    listBox6.Items.Add(radioButton2.Text);
                }
                else
                {
                    MessageBox.Show("Cinsiyet Seçmediniz..");
                }
                

            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("1");
            btn1.Enabled = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("2");
            btn2.Enabled = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("3");
            btn3.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("4");
            btn4.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("5");
            btn5.Enabled = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("6");
            btn6.Enabled = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("7");
            btn7.Enabled = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("8");
            btn8.Enabled = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("9");
            btn9.Enabled = false;
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("10");
            btn10.Enabled = false;
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("11");
            btn11.Enabled = false;
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("12");
            btn12.Enabled = false;
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("13");
            btn13.Enabled = false;
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("14");
            btn14.Enabled = false;
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("15");
            btn15.Enabled = false;
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("16");
            btn16.Enabled = false;
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("17");
            btn17.Enabled = false;
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("18");
            btn18.Enabled = false;
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("19");
            btn19.Enabled = false;
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("20");
            btn20.Enabled = false;
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("21");
            btn21.Enabled = false;
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("22");
            btn22.Enabled = false;
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("23");
            btn23.Enabled = false;
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("24");
            btn24.Enabled = false;
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("25");
            btn25.Enabled = false;
        }

        private void btn26_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("26");
            btn26.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Biletiniz başarıyla alındı.. "+" "+"İyi Yolculuklar :)");
        }
    }
}
