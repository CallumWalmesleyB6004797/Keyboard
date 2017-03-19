using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyboard_V1
{
    public partial class Form1 : Form
    {
        int OneButtonPress = -1;
        int TwoButtonPress = -1;
        int ThreeButtonPress = -1;
        int FourButtonPress = -1;
        int FiveButtonPress = -1;
        int SixButtonPress = -1;
        int SevenButtonPress = -1;
        int EightButtonPress = -1;
        int NineButtonPress = -1;
        int ZeroButtonPress = -1;
        int AsterixButtonPress = -1;
        int HashButtonPress = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Seven_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Eight_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Nine_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Six_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Five_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Four_Btn_Click(object sender, EventArgs e)
        {

        }

        private void One_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Two_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Three_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Hash_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Symbols_Btn_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Mode_Btn_Click(object sender, EventArgs e)
        {
            if (this.Mode_Box.Text == "Multi-Press")
            {
                this.Mode_Box.Text = "Prediction";
            }
            else if (this.Mode_Box.Text == "Prediction")
            {
                this.Mode_Box.Text = "Multi-Press";
            }
        }

        private void Mode_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Zero_Btn_Click(object sender, EventArgs e)
        {
        
        }

        private void One_Btn_Click_1(object sender, EventArgs e)
        {
            OneButtonPress++;

            switch (OneButtonPress)
            {
                case 0:
                    richTextBox1.Text = One_ListBox.Items[OneButtonPress].ToString();
                    break;

                case 1:
                    richTextBox1.Text = One_ListBox.Items[OneButtonPress].ToString();
                    break;

                case 2:
                    richTextBox1.Text = One_ListBox.Items[OneButtonPress].ToString();
                    break;

                case 3:
                    richTextBox1.Text = One_ListBox.Items[OneButtonPress].ToString();
                    break;

                case 4:
                    richTextBox1.Text = One_ListBox.Items[OneButtonPress].ToString();
                    break;

                case 5:
                    richTextBox1.Text = One_ListBox.Items[OneButtonPress].ToString();
                    break;

                case 6:
                    richTextBox1.Text = One_ListBox.Items[OneButtonPress].ToString();
                    break;

                case 7:
                    richTextBox1.Text = One_ListBox.Items[OneButtonPress].ToString();
                    break;

                case 8:
                    richTextBox1.Text = One_ListBox.Items[OneButtonPress].ToString();
                    break;

                case 9:
                    richTextBox1.Text = One_ListBox.Items[OneButtonPress].ToString();
                    break;

            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void One_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
