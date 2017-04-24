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
        int AsterixButtonPress = -1;
        int HashButtonPress = -1;
        String str_keystrokes;
        int Int_Interval_Required = 500; //500 Milliseconds (0.5 Seconds).
        public Form1()
        {
            InitializeComponent();
        }

        private void Notepad_TextChanged(object sender, EventArgs e)
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
        {   //Appends the value of the WordBuilder text box to the notepad.
            Notepad.AppendText(WordBuilder.Text.ToString());
            //Followed by a sapce in the notepad.
            Notepad.AppendText(" ");
            //Empty the KeySequence textbox.
            KeySequence_TextBox.Clear();
            //Empty the WordBuilder
            WordBuilder.Clear();
            
        }

        private void WordBuilder_TextChanged(object sender, EventArgs e)
        {

        }
        private void One_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void One_Btn_Click_1(object sender, EventArgs e)
        {
            KeySequence_TextBox.AppendText("1".ToString());
            //If the text box has the writing "Multi-Press" inside, then execute the code.
            if (Mode_Box.Text == "Multi-Press")
            {   //Increments the value of the variable by 1 everytime the button is clicked.
                OneButtonPress++;
                TwoButtonPress = -1;
                ThreeButtonPress = -1;
                FourButtonPress = -1;
                FiveButtonPress = -1;
                SixButtonPress = -1;
                SevenButtonPress = -1;
                EightButtonPress = -1;
                NineButtonPress = -1;
                HashButtonPress = -1;
                AsterixButtonPress = -1;
                //Switch case for the variable OneButtonPress
                switch (OneButtonPress)
                {
                    case 0:
                        WordBuilder.AppendText(One_ListBox.Items[OneButtonPress].ToString()); //If the number is zero, then execute this.
                        break;

                    case 1:
                        WordBuilder.AppendText(One_ListBox.Items[OneButtonPress].ToString());
                        break;

                    case 2:
                        WordBuilder.AppendText(One_ListBox.Items[OneButtonPress].ToString());
                        break;

                    case 3:
                        WordBuilder.AppendText(One_ListBox.Items[OneButtonPress].ToString());
                        break;

                    case 4:
                        WordBuilder.AppendText(One_ListBox.Items[OneButtonPress].ToString());
                        break;

                    case 5:
                        WordBuilder.AppendText(One_ListBox.Items[OneButtonPress].ToString());
                        break;

                    case 6:
                        WordBuilder.AppendText(One_ListBox.Items[OneButtonPress].ToString());
                        break;

                    case 7:
                        WordBuilder.AppendText(One_ListBox.Items[OneButtonPress].ToString());
                        break;

                    case 8:
                        WordBuilder.AppendText(One_ListBox.Items[OneButtonPress].ToString());
                        //I revert the value inside the variable to -1 so it will cycle through the switch case.
                        OneButtonPress = -1;
                        break;
                }
            }
        }
      

        private void Two_Btn_Click_1(object sender, EventArgs e)
        {
            KeySequence_TextBox.AppendText("2".ToString());
            
            if (Mode_Box.Text == "Multi-Press")
            {   
                TwoButtonPress++;
                OneButtonPress = -1;
                ThreeButtonPress = -1;
                FourButtonPress = -1;
                FiveButtonPress = -1;
                SixButtonPress = -1;
                SevenButtonPress = -1;
                EightButtonPress = -1;
                NineButtonPress = -1;
                HashButtonPress = -1;
                AsterixButtonPress = -1;

                switch (TwoButtonPress)
                {
                    case 0:
                        WordBuilder.AppendText(Two_ListBox.Items[TwoButtonPress].ToString());
                        break;

                    case 1:
                        WordBuilder.AppendText(Two_ListBox.Items[TwoButtonPress].ToString());
                        break;

                    case 2:
                        WordBuilder.AppendText(Two_ListBox.Items[TwoButtonPress].ToString());
                        break;

                    case 3:
                        WordBuilder.AppendText(Two_ListBox.Items[TwoButtonPress].ToString());
                        break;

                    case 4:
                        WordBuilder.AppendText(Two_ListBox.Items[TwoButtonPress].ToString());
                        break;

                    case 5:
                        WordBuilder.AppendText(Two_ListBox.Items[TwoButtonPress].ToString());
                        break;

                    case 6:
                        WordBuilder.AppendText(Two_ListBox.Items[TwoButtonPress].ToString());
                        TwoButtonPress = -1;
                        break;                    
                }
            }
        }


        private void Three_Btn_Click_1(object sender, EventArgs e)
        {
            KeySequence_TextBox.AppendText("3".ToString());
            
            if (Mode_Box.Text == "Multi-Press")
            {
                ThreeButtonPress++;
                OneButtonPress = -1;
                TwoButtonPress = -1;
                FourButtonPress = -1;
                FiveButtonPress = -1;
                SixButtonPress = -1;
                SevenButtonPress = -1;
                EightButtonPress = -1;
                NineButtonPress = -1;
                HashButtonPress = -1;
                AsterixButtonPress = -1;

                switch (ThreeButtonPress)
                {
                    case 0:
                        WordBuilder.AppendText(Three_ListBox.Items[ThreeButtonPress].ToString());
                        break;

                    case 1:
                        WordBuilder.AppendText(Three_ListBox.Items[ThreeButtonPress].ToString());
                        break;

                    case 2:
                        WordBuilder.AppendText(Three_ListBox.Items[ThreeButtonPress].ToString());
                        break;

                    case 3:
                        WordBuilder.AppendText(Three_ListBox.Items[ThreeButtonPress].ToString());
                        break;

                    case 4:
                        WordBuilder.AppendText(Three_ListBox.Items[ThreeButtonPress].ToString());
                        break;

                    case 5:
                        WordBuilder.AppendText(Three_ListBox.Items[ThreeButtonPress].ToString());
                        break;

                    case 6:
                        WordBuilder.AppendText(Three_ListBox.Items[ThreeButtonPress].ToString());                        
                        break;
                    
                    case 7:
                        WordBuilder.AppendText(Three_ListBox.Items[ThreeButtonPress].ToString());
                        break;

                    case 8:
                        WordBuilder.AppendText(Three_ListBox.Items[ThreeButtonPress].ToString());
                        ThreeButtonPress = -1;
                        break;
                }
            }
        }


        private void Four_Btn_Click_1(object sender, EventArgs e)
        {
            KeySequence_TextBox.AppendText("4".ToString());

            if (Mode_Box.Text == "Multi-Press")
            {
                FourButtonPress++;
                OneButtonPress = -1;
                TwoButtonPress = -1;
                ThreeButtonPress = -1;
                FiveButtonPress = -1;
                SixButtonPress = -1;
                SevenButtonPress = -1;
                EightButtonPress = -1;
                NineButtonPress = -1;
                HashButtonPress = -1;
                AsterixButtonPress = -1;

                switch (FourButtonPress)
                {
                    case 0:
                        WordBuilder.AppendText(Four_ListBox.Items[FourButtonPress].ToString());
                        break;

                    case 1:
                        WordBuilder.AppendText(Four_ListBox.Items[FourButtonPress].ToString());
                        break;

                    case 2:
                        WordBuilder.AppendText(Four_ListBox.Items[FourButtonPress].ToString());
                        break;

                    case 3:
                        WordBuilder.AppendText(Four_ListBox.Items[FourButtonPress].ToString());
                        break;

                    case 4:
                        WordBuilder.AppendText(Four_ListBox.Items[FourButtonPress].ToString());
                        break;

                    case 5:
                        WordBuilder.AppendText(Four_ListBox.Items[FourButtonPress].ToString());
                        break;

                    case 6:
                        WordBuilder.AppendText(Four_ListBox.Items[FourButtonPress].ToString());
                        FourButtonPress = -1;
                        break;
                }
            }
        }


        private void Five_Btn_Click_1(object sender, EventArgs e)
        {
            KeySequence_TextBox.AppendText("5".ToString());

            if (Mode_Box.Text == "Multi-Press")
            {
                FiveButtonPress++;
                OneButtonPress = -1;
                TwoButtonPress = -1;
                ThreeButtonPress = -1;
                FourButtonPress = -1;
                SixButtonPress = -1;
                SevenButtonPress = -1;
                EightButtonPress = -1;
                NineButtonPress = -1;
                HashButtonPress = -1;
                AsterixButtonPress = -1;

                switch (FiveButtonPress)
                {
                    case 0:
                        WordBuilder.AppendText(Five_ListBox.Items[FiveButtonPress].ToString());
                        break;

                    case 1:
                        WordBuilder.AppendText(Five_ListBox.Items[FiveButtonPress].ToString());
                        break;

                    case 2:
                        WordBuilder.AppendText(Five_ListBox.Items[FiveButtonPress].ToString());
                        break;

                    case 3:
                        WordBuilder.AppendText(Five_ListBox.Items[FiveButtonPress].ToString());
                        break;

                    case 4:
                        WordBuilder.AppendText(Five_ListBox.Items[FiveButtonPress].ToString());
                        break;

                    case 5:
                        WordBuilder.AppendText(Five_ListBox.Items[FiveButtonPress].ToString());
                        break;

                    case 6:
                        WordBuilder.AppendText(Five_ListBox.Items[FiveButtonPress].ToString());
                        FiveButtonPress = -1;
                        break;
                }
            }
        }


        private void Six_Btn_Click_1(object sender, EventArgs e)
        {
            KeySequence_TextBox.AppendText("6".ToString());

            if (Mode_Box.Text == "Multi-Press")
            {
                SixButtonPress++;
                OneButtonPress = -1;
                TwoButtonPress = -1;
                ThreeButtonPress = -1;
                FourButtonPress = -1;
                FiveButtonPress = -1;
                SevenButtonPress = -1;
                EightButtonPress = -1;
                NineButtonPress = -1;
                HashButtonPress = -1;
                AsterixButtonPress = -1;

                switch (SixButtonPress)
                {
                    case 0:
                        WordBuilder.AppendText(Six_ListBox.Items[SixButtonPress].ToString());
                        break;

                    case 1:
                        WordBuilder.AppendText(Six_ListBox.Items[SixButtonPress].ToString());
                        break;

                    case 2:
                        WordBuilder.AppendText(Six_ListBox.Items[SixButtonPress].ToString());
                        break;

                    case 3:
                        WordBuilder.AppendText(Six_ListBox.Items[SixButtonPress].ToString());
                        break;

                    case 4:
                        WordBuilder.AppendText(Six_ListBox.Items[SixButtonPress].ToString());
                        break;

                    case 5:
                        WordBuilder.AppendText(Six_ListBox.Items[SixButtonPress].ToString());
                        break;

                    case 6:
                        WordBuilder.AppendText(Six_ListBox.Items[SixButtonPress].ToString());
                        SixButtonPress = -1;
                        break;
                }
            }
        }


        private void Seven_Btn_Click_1(object sender, EventArgs e)
        {
            KeySequence_TextBox.AppendText("7".ToString());

            if (Mode_Box.Text == "Multi-Press")
            {
                SevenButtonPress++;
                OneButtonPress = -1;
                TwoButtonPress = -1;
                ThreeButtonPress = -1;
                FourButtonPress = -1;
                FiveButtonPress = -1;
                SixButtonPress = -1;
                EightButtonPress = -1;
                NineButtonPress = -1;
                HashButtonPress = -1;
                AsterixButtonPress = -1;
                switch (SevenButtonPress)
                {
                    case 0:
                        WordBuilder.AppendText(Seven_ListBox.Items[SevenButtonPress].ToString());
                        break;

                    case 1:
                        WordBuilder.AppendText(Seven_ListBox.Items[SevenButtonPress].ToString());
                        break;

                    case 2:
                        WordBuilder.AppendText(Seven_ListBox.Items[SevenButtonPress].ToString());
                        break;

                    case 3:
                        WordBuilder.AppendText(Seven_ListBox.Items[SevenButtonPress].ToString());
                        break;

                    case 4:
                        WordBuilder.AppendText(Seven_ListBox.Items[SevenButtonPress].ToString());
                        break;

                    case 5:
                        WordBuilder.AppendText(Seven_ListBox.Items[SevenButtonPress].ToString());
                        break;

                    case 6:
                        WordBuilder.AppendText(Seven_ListBox.Items[SevenButtonPress].ToString());
                        SevenButtonPress = -1;
                        break;
                }
            }
        }


        private void Eight_Btn_Click_1(object sender, EventArgs e)
        {
            KeySequence_TextBox.AppendText("8".ToString());

            if (Mode_Box.Text == "Multi-Press")
            {
                EightButtonPress++;
                OneButtonPress = -1;
                TwoButtonPress = -1;
                ThreeButtonPress = -1;
                FourButtonPress = -1;
                FiveButtonPress = -1;
                SixButtonPress = -1;
                SevenButtonPress = -1;
                NineButtonPress = -1;
                HashButtonPress = -1;
                AsterixButtonPress = -1;

                switch (EightButtonPress)
                {
                    case 0:
                        WordBuilder.AppendText(Eight_ListBox.Items[EightButtonPress].ToString());
                        break;

                    case 1:
                        WordBuilder.AppendText(Eight_ListBox.Items[EightButtonPress].ToString());
                        break;

                    case 2:
                        WordBuilder.AppendText(Eight_ListBox.Items[EightButtonPress].ToString());
                        break;

                    case 3:
                        WordBuilder.AppendText(Eight_ListBox.Items[EightButtonPress].ToString());
                        break;

                    case 4:
                        WordBuilder.AppendText(Eight_ListBox.Items[EightButtonPress].ToString());
                        break;

                    case 5:
                        WordBuilder.AppendText(Eight_ListBox.Items[EightButtonPress].ToString());
                        break;

                    case 6:
                        WordBuilder.AppendText(Eight_ListBox.Items[EightButtonPress].ToString());
                        EightButtonPress = -1;
                        break;
                }
            }
        }


        private void Nine_Btn_Click_1(object sender, EventArgs e)
        {
            KeySequence_TextBox.AppendText("9".ToString());

            if (Mode_Box.Text == "Multi-Press")
            {
                NineButtonPress++;
                OneButtonPress = -1;
                TwoButtonPress = -1;
                ThreeButtonPress = -1;
                FourButtonPress = -1;
                FiveButtonPress = -1;
                SixButtonPress = -1;
                SevenButtonPress = -1;
                EightButtonPress = -1;
                HashButtonPress = -1;
                AsterixButtonPress = -1;

                switch (NineButtonPress)
                {
                    case 0:
                        WordBuilder.AppendText(Nine_ListBox.Items[NineButtonPress].ToString());
                        break;

                    case 1:
                        WordBuilder.AppendText(Nine_ListBox.Items[NineButtonPress].ToString());
                        break;

                    case 2:
                        WordBuilder.AppendText(Nine_ListBox.Items[NineButtonPress].ToString());
                        break;

                    case 3:
                        WordBuilder.AppendText(Nine_ListBox.Items[NineButtonPress].ToString());
                        break;

                    case 4:
                        WordBuilder.AppendText(Nine_ListBox.Items[NineButtonPress].ToString());
                        break;

                    case 5:
                        WordBuilder.AppendText(Nine_ListBox.Items[NineButtonPress].ToString());
                        break;

                    case 6:
                        WordBuilder.AppendText(Nine_ListBox.Items[NineButtonPress].ToString());
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
            if (Mode_Box.Text == "Multi-Press")
            {
                HashButtonPress++;
                OneButtonPress = -1;
                TwoButtonPress = -1;
                ThreeButtonPress = -1;
                FourButtonPress = -1;
                FiveButtonPress = -1;
                SixButtonPress = -1;
                SevenButtonPress = -1;
                EightButtonPress = -1;
                NineButtonPress = -1;
                AsterixButtonPress = -1;

                switch (HashButtonPress)
                {
                    case 0:
                        WordBuilder.AppendText(Hash_ListBox.Items[HashButtonPress].ToString());
                        break;

                    case 1:
                        WordBuilder.AppendText(Hash_ListBox.Items[HashButtonPress].ToString());
                        break;

                    case 2:
                        WordBuilder.AppendText(Hash_ListBox.Items[HashButtonPress].ToString());
                        HashButtonPress = -1;
                        break;
                }

            }
        }

        private void Enter_Btn_Click(object sender, EventArgs e)
        {
            Notepad.AppendText(Environment.NewLine); //Creates a new line
            Notepad.Focus(); //Makes a cursor appear in the notepad showing where the text is going to be appended to
            
        }

        private void KeySequence_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonTimer_Tick(object sender, EventArgs e)
        {

        }

        private void Symbols_Btn_Click(object sender, EventArgs e)
        {
            if (Mode_Box.Text == "Multi-Press")
            {
                AsterixButtonPress++;
                OneButtonPress = -1;
                TwoButtonPress = -1;
                ThreeButtonPress = -1;
                FourButtonPress = -1;
                FiveButtonPress = -1;
                SixButtonPress = -1;
                SevenButtonPress = -1;
                EightButtonPress = -1;
                NineButtonPress = -1;
                HashButtonPress = -1;

                switch (AsterixButtonPress)
                {
                    case 0:
                        WordBuilder.AppendText(Asterix_ListBox.Items[AsterixButtonPress].ToString());
                        break;

                    case 1:
                        WordBuilder.AppendText(Asterix_ListBox.Items[AsterixButtonPress].ToString());
                        break;

                    case 2:
                        WordBuilder.AppendText(Asterix_ListBox.Items[AsterixButtonPress].ToString());
                        AsterixButtonPress = -1;
                        break;
                }

            }
        }

        private void Eight_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Seven_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Nine_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Six_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Five_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Four_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Two_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Three_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Hash_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Asterix_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
