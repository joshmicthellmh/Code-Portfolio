using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimesaableGamer2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int num1 = 0;
        public int num2 = 0;
        public int input = 0;
        public int gameScore = 0;
        public int gameLevel = 0;
        public int level = 1;

        // on start the sets random numbers for both numbers, based on the score
        private void BtnStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        //Check if the the corect arnser was reached
        private void BtnCheck_Click(object sender, EventArgs e)
        {
            GameOpiraation();
            Num2Random();
        }
        //Sets all of the paramiters for game
        public void StartGame()
        {
            btnStart.Enabled = false;
            lbllevel.Text = "LEVEL:" + level.ToString();
            Num1Random();
            Num2Random();
        }
        //Alows the user to exit the game
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        // Sets a random numberr for num2 
        public void Num2Random()
        {
            Random rnd = new Random();
            int num2 = rnd.Next(2, 13);
            lblNum2.Text = num2.ToString();
        }
        //this function runs the games operation
        public void GameOpiraation()
        {
            //Checkimg the input is correct.
            num1 = Convert.ToInt32(lblNum1.Text);
            num2 = Convert.ToInt32(lblNum2.Text);
            int Ressult = num1 * num2;
            input = Convert.ToInt32(txtInput.Text);
            if (input == Ressult)
            {
                MessageBox.Show("Well Done");
                gameScore++;
                lblScore.Text = "SCORE:" + gameScore.ToString();
            }
            else if (input != num1 * num2)
            {
                MessageBox.Show("Wrong!");
            }
            txtInput.Clear();
            //Changing the level of the game. 
            if (gameScore < 10 && gameScore >= 0)
            {
                level = 1;
                Num1Random();
                lbllevel.Text = "LEVEL:" + level.ToString();
            }
            else if (gameScore >= 10 && gameScore < 15)
            {
                level = 2;
                Num1Random();
                lbllevel.Text = "LEVEL:" + level.ToString();
            }
            else if (gameScore >= 15)
            {
                level = 3;
                Num1Random();
                lbllevel.Text = "LEVEL:" + level.ToString();
            }
        }
        //controls the num 1 randomnas for all levels. 
        public void Num1Random()
        {    
            //Takes the eusers current level and creares randfom value for num 1
            Random rndl2 = new Random();
            int counter = 0;
            if (level == 1)
            {
                counter = rndl2.Next(1, 6);
            }
            else if (level == 2)
            {
                counter = rndl2.Next(1, 9);
            }
            else if (level == 3)
            {
                counter = rndl2.Next(1, 12);
            }
            switch (counter)
            {
                //Start of level 1
                case 1:
                    num1 = 2;
                    lblNum1.Text = num1.ToString();
                    break;
                case 2:
                    num1 = 3;
                    lblNum1.Text = num1.ToString();
                    break;
                case 3:
                    num1 = 4;
                    lblNum1.Text = num1.ToString();
                    break;
                case 4:
                    num1 = 5;
                    lblNum1.Text = num1.ToString();
                    break;
                case 5:
                    num1 = 10;
                    lblNum1.Text = num1.ToString();
                    break;
                //End of level one 
                //Start of level 2
                case 6:
                    num1 = 6;
                    lblNum1.Text = num1.ToString();
                    break;
                case 7:
                    num1 = 8;
                    lblNum1.Text = num1.ToString();
                    break;
                case 8:
                    num1 = 9;
                    lblNum1.Text = num1.ToString();
                    break;
                //End of level 2 
                //start of level 3
                case 9:
                    num1 = 7;
                    lblNum1.Text = num1.ToString();
                    break;
                case 10:
                    num1 = 11;
                    lblNum1.Text = num1.ToString();
                    break;
                case 11:
                    num1 = 12;
                    lblNum1.Text = num1.ToString();
                    break;
                //End of level 3
                //Defult Case
                default:
                    MessageBox.Show("Erro");
                    break;
            }

        }
    }
}
