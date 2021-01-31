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

        private int attempts;
        private int secretNumber;
        private NumberGuessService.INumberGuessing numberGuessService;
        
        
        public Form1()
        {
            InitializeComponent();
            numberGuessService = new NumberGuessService.NumberGuessingClient();
            limitInputErrorLimit.Text = "";
            playButton.Enabled = false;
        }

        private void lowerLimitLabel_Click(object sender, EventArgs e)
        {

        }

        private void generateRandomNumber_Click(object sender, EventArgs e)
        {
            resetAttempts();
            resetNumberIsLabel();
            limitInputErrorLimit.Text = "";
            try
            {
                int lowerLimit = Int32.Parse(lowerLimitText.Text);
                int upperLimit = Int32.Parse(upperLimitLabel.Text);
                if(lowerLimit > upperLimit)
                {
                    limitInputErrorLimit.Text = "lower limit cannot be larger than upper limit";
                    return;
                }
                secretNumber = numberGuessService.SecretNumber(lowerLimit, upperLimit);
                playButton.Enabled = true;
            } catch (Exception ex) when(ex is FormatException || ex is OverflowException)
            {
                limitInputErrorLimit.Text = "Please enter valid whole numbers as the lower and upper limits.";
            }
           
            

        }

        private void resetNumberIsLabel()
        {
            numberIsLabel.Text = "-";
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            try
            {
                int guess = Int32.Parse(makeAGuessTextBox.Text);
                numberIsLabel.Text = numberGuessService.checkNumber(guess, secretNumber);
                attemptsLabel.Text = "" + (++attempts);
            } catch(Exception ex ) when(ex is FormatException || ex is OverflowException)
            {
                numberIsLabel.Text = "Please enter a valid whole number";
            }
            
           
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

        

    }
}
