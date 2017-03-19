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
        int OneButtonPress = -1; //Declaring global variables.
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

        private void Form1_Load(object sender, EventArgs e)
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void One_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void One_Btn_Click_1(object sender, EventArgs e)
        {
            if (Mode_Box.Text == "Multi-Press") //If the text box has the writing "Multi-Press" inside, then execute the code.
            {
                OneButtonPress++; //Increments the value of the variable by 1 everytime the button is clicked.

                switch (OneButtonPress) //Switch case for the variable OneButtonPress
                {
                    case 0:
                        richTextBox1.Text = One_ListBox.Items[OneButtonPress].ToString(); //If the number is zero, then execute this.
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
                        OneButtonPress = -1; //I revert the value inside the variable to -1 so it will cycle through the switch case.
                        break;
                }
            }
        }      

        private void Two_Btn_Click_1(object sender, EventArgs e)
        {
            if (Mode_Box.Text == "Multi-Press")
            {
                TwoButtonPress++;

                switch (TwoButtonPress)
                {
                    case 0:
                        richTextBox1.Text = Two_ListBox.Items[TwoButtonPress].ToString();
                        break;

                    case 1:
                        richTextBox1.Text = Two_ListBox.Items[TwoButtonPress].ToString();
                        break;

                    case 2:
                        richTextBox1.Text = Two_ListBox.Items[TwoButtonPress].ToString();
                        break;

                    case 3:
                        richTextBox1.Text = Two_ListBox.Items[TwoButtonPress].ToString();
                        break;

                    case 4:
                        richTextBox1.Text = Two_ListBox.Items[TwoButtonPress].ToString();
                        break;

                    case 5:
                        richTextBox1.Text = Two_ListBox.Items[TwoButtonPress].ToString();
                        break;

                    case 6:
                        richTextBox1.Text = Two_ListBox.Items[TwoButtonPress].ToString();
                        TwoButtonPress = -1;
                        break;
                }
            }
        }

        private void Three_Btn_Click_1(object sender, EventArgs e)
        {
            if (Mode_Box.Text == "Multi-Press")
            {
                ThreeButtonPress++;

                switch (ThreeButtonPress)
                {
                    case 0:
                        richTextBox1.Text = Three_ListBox.Items[ThreeButtonPress].ToString();
                        break;

                    case 1:
                        richTextBox1.Text = Three_ListBox.Items[ThreeButtonPress].ToString();
                        break;

                    case 2:
                        richTextBox1.Text = Three_ListBox.Items[ThreeButtonPress].ToString();
                        break;

                    case 3:
                        richTextBox1.Text = Three_ListBox.Items[ThreeButtonPress].ToString();
                        break;

                    case 4:
                        richTextBox1.Text = Three_ListBox.Items[ThreeButtonPress].ToString();
                        break;

                    case 5:
                        richTextBox1.Text = Three_ListBox.Items[ThreeButtonPress].ToString();
                        break;

                    case 6:
                        richTextBox1.Text = Three_ListBox.Items[ThreeButtonPress].ToString();
                        break;

                    case 7:
                        richTextBox1.Text = Three_ListBox.Items[ThreeButtonPress].ToString();
                        break;
                    case 8:
                        richTextBox1.Text = Three_ListBox.Items[ThreeButtonPress].ToString();
                        ThreeButtonPress = -1;
                        break;
                }
            }
        }

        private void Four_Btn_Click_1(object sender, EventArgs e)
        {
            if (Mode_Box.Text == "Multi-Press")
            {
                FourButtonPress++;

                switch (FourButtonPress)
                {
                    case 0:
                        richTextBox1.Text = Four_ListBox.Items[FourButtonPress].ToString();
                        break;

                    case 1:
                        richTextBox1.Text = Four_ListBox.Items[FourButtonPress].ToString();
                        break;

                    case 2:
                        richTextBox1.Text = Four_ListBox.Items[FourButtonPress].ToString();
                        break;

                    case 3:
                        richTextBox1.Text = Four_ListBox.Items[FourButtonPress].ToString();
                        break;

                    case 4:
                        richTextBox1.Text = Four_ListBox.Items[FourButtonPress].ToString();
                        break;

                    case 5:
                        richTextBox1.Text = Four_ListBox.Items[FourButtonPress].ToString();
                        break;

                    case 6:
                        richTextBox1.Text = Four_ListBox.Items[FourButtonPress].ToString();
                        FourButtonPress = -1;
                        break;
                }
            }


        }

        private void Five_Btn_Click_1(object sender, EventArgs e)
        {
            if (Mode_Box.Text == "Multi-Press")
            {
                FiveButtonPress++;

                switch (FiveButtonPress)
                {
                    case 0:
                        richTextBox1.Text = Five_ListBox.Items[FiveButtonPress].ToString();
                        break;

                    case 1:
                        richTextBox1.Text = Five_ListBox.Items[FiveButtonPress].ToString();
                        break;

                    case 2:
                        richTextBox1.Text = Five_ListBox.Items[FiveButtonPress].ToString();
                        break;

                    case 3:
                        richTextBox1.Text = Five_ListBox.Items[FiveButtonPress].ToString();
                        break;

                    case 4:
                        richTextBox1.Text = Five_ListBox.Items[FiveButtonPress].ToString();
                        break;

                    case 5:
                        richTextBox1.Text = Five_ListBox.Items[FiveButtonPress].ToString();
                        break;

                    case 6:
                        richTextBox1.Text = Five_ListBox.Items[FiveButtonPress].ToString();
                        FiveButtonPress = -1;
                        break;
                }
            }

        }

        private void Six_Btn_Click_1(object sender, EventArgs e)
        {
            if (Mode_Box.Text == "Multi-Press")
            {
                SixButtonPress++;

                switch (SixButtonPress)
                {
                    case 0:
                        richTextBox1.Text = Six_ListBox.Items[SixButtonPress].ToString();
                        break;

                    case 1:
                        richTextBox1.Text = Six_ListBox.Items[SixButtonPress].ToString();
                        break;

                    case 2:
                        richTextBox1.Text = Six_ListBox.Items[SixButtonPress].ToString();
                        break;

                    case 3:
                        richTextBox1.Text = Six_ListBox.Items[SixButtonPress].ToString();
                        break;

                    case 4:
                        richTextBox1.Text = Six_ListBox.Items[SixButtonPress].ToString();
                        break;

                    case 5:
                        richTextBox1.Text = Six_ListBox.Items[SixButtonPress].ToString();
                        break;

                    case 6:
                        richTextBox1.Text = Six_ListBox.Items[SixButtonPress].ToString();
                        SixButtonPress = -1;
                        break;
                }
            }

        }

        private void Seven_Btn_Click_1(object sender, EventArgs e)
        {
            if (Mode_Box.Text == "Multi-Press")
            {
                SevenButtonPress++;

                switch (SevenButtonPress)
                {
                    case 0:
                        richTextBox1.Text = Seven_ListBox.Items[SevenButtonPress].ToString();
                        break;

                    case 1:
                        richTextBox1.Text = Seven_ListBox.Items[SevenButtonPress].ToString();
                        break;

                    case 2:
                        richTextBox1.Text = Seven_ListBox.Items[SevenButtonPress].ToString();
                        break;

                    case 3:
                        richTextBox1.Text = Seven_ListBox.Items[SevenButtonPress].ToString();
                        break;

                    case 4:
                        richTextBox1.Text = Seven_ListBox.Items[SevenButtonPress].ToString();
                        break;

                    case 5:
                        richTextBox1.Text = Seven_ListBox.Items[SevenButtonPress].ToString();
                        break;

                    case 6:
                        richTextBox1.Text = Seven_ListBox.Items[SevenButtonPress].ToString();
                        SevenButtonPress = -1;
                        break;
                }
            }

        }

        private void Eight_Btn_Click_1(object sender, EventArgs e)
        {
            if (Mode_Box.Text == "Multi-Press")
            {
                EightButtonPress++;

                switch (EightButtonPress)
                {
                    case 0:
                        richTextBox1.Text = Eight_ListBox.Items[EightButtonPress].ToString();
                        break;

                    case 1:
                        richTextBox1.Text = Eight_ListBox.Items[EightButtonPress].ToString();
                        break;

                    case 2:
                        richTextBox1.Text = Eight_ListBox.Items[EightButtonPress].ToString();
                        break;

                    case 3:
                        richTextBox1.Text = Eight_ListBox.Items[EightButtonPress].ToString();
                        break;

                    case 4:
                        richTextBox1.Text = Eight_ListBox.Items[EightButtonPress].ToString();
                        break;

                    case 5:
                        richTextBox1.Text = Eight_ListBox.Items[EightButtonPress].ToString();
                        break;

                    case 6:
                        richTextBox1.Text = Eight_ListBox.Items[EightButtonPress].ToString();
                        EightButtonPress = -1;
                        break;
                }
            }

        }

        private void Nine_Btn_Click_1(object sender, EventArgs e)
        {
            if (Mode_Box.Text == "Multi-Press")
            {
                NineButtonPress++;

                switch (NineButtonPress)
                {
                    case 0:
                        richTextBox1.Text = Nine_ListBox.Items[NineButtonPress].ToString();
                        break;

                    case 1:
                        richTextBox1.Text = Nine_ListBox.Items[NineButtonPress].ToString();
                        break;

                    case 2:
                        richTextBox1.Text = Nine_ListBox.Items[NineButtonPress].ToString();
                        break;

                    case 3:
                        richTextBox1.Text = Nine_ListBox.Items[NineButtonPress].ToString();
                        break;

                    case 4:
                        richTextBox1.Text = Nine_ListBox.Items[NineButtonPress].ToString();
                        break;

                    case 5:
                        richTextBox1.Text = Nine_ListBox.Items[NineButtonPress].ToString();
                        break;

                    case 6:
                        richTextBox1.Text = Nine_ListBox.Items[NineButtonPress].ToString();
                        NineButtonPress = -1;
                        break;
                }
            }

        }

        private void Empty2_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Hash_Btn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
