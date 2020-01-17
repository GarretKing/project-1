using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace last_game_rps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int userinput = 1;
            int computerinput = 1;

            //Step 1 create a Random object
            Random myRndNumber = new Random();
            //Step 2 assign a value to computerinput (does not include maxValu of 4)
            computerinput = myRndNumber.Next(1, 4);
            //Show 
            Console.WriteLine(computerinput);

            if (userinput == 1 && computerinput == 1)
                txtresult.Text = " this is a draw";
            else if (userinput == 1 && computerinput == 2)
                txtresult.Text = " computer wins";
            else if (userinput == 1 && computerinput == 3)
                txtresult.Text = "user wins";



        }

        private void Button2_Click(object sender, EventArgs e)
        {

            int userinput = 1;
            int computerinput = 1;

            //Step 1 create a Random object
            Random myRndNumber = new Random();
            //Step 2 assign a value to computerinput (does not include maxValu of 4)
            computerinput = myRndNumber.Next(1, 4);
            //Show 
            Console.WriteLine(computerinput);

            if (userinput == 2 && computerinput == 1)
                txtresult.Text = " user won";
            else if (userinput == 2 && computerinput == 2)
                txtresult.Text = " game draw";
            else if (userinput == 2 && computerinput == 3)
                txtresult.Text = "computer wins";
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            int userinput = 1;
            int computerinput = 1;

            //Step 1 create a Random object
            Random myRndNumber = new Random();
            //Step 2 assign a value to computerInput (does not include maxValu of 4)
            computerinput = myRndNumber.Next(1, 4);
            //Show 
            Console.WriteLine(computerinput);
            if (userinput == 3 && computerinput == 1)
                txtresult.Text = " user lose";
            else if (userinput == 3 && computerinput == 2)
                txtresult.Text = " you win";
            else if (userinput == 3 && computerinput == 3)
                txtresult.Text = "game draw";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
