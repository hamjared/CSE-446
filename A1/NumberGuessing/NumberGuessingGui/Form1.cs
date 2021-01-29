using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuessingGui
{
    public partial class Form1 : Form
    {

        private int numberTGuess;
        private int attempts;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void lowerLimitLabel_Click(object sender, EventArgs e)
        {

        }

        private void generateRandomNumber_Click(object sender, EventArgs e)
        {
            resetAttempts();
            resetNumberIsLabel();

        }

        private void resetNumberIsLabel()
        {
            numberIsLabel.Text = "-";
        }

        private void playButton_Click(object sender, EventArgs e)
        {

        }

        private void setAttemptsLabel()
        {
                attemptsLabel.Text = "" + attempts;
        }

        private void resetAttempts()
        {
            attempts = 0;
            attemptsLabel.Text = "-";
        }

        private void setNumberIsLabel(int guess)
        {
            if(guess == numberTGuess)
            {
                numberIsLabel.Text = "correct!";
            }
            else if(guess < numberTGuess)
            {
                numberIsLabel.Text = "too small";
            }
            else
            {
                numberIsLabel.Text = "too big";
            }
        }
    }
}
