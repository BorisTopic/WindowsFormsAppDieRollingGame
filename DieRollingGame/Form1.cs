using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DieRollingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Attributes

        /// <summary>
        /// Holds number of times user has played the game.
        /// </summary>
        int iNumTimesPlayed;
        /// <summary>
        /// Holds number of times user as won the game.
        /// </summary>
        int iNumTimesWon;
        /// <summary>
        /// Holds number of times user has lost the game.
        /// </summary>
        int iNumTimesLost;
        /// <summary>
        /// Holds the result from the die roll.
        /// </summary>
        int iDieRollResult;
        /// <summary>
        /// Holds the user's guess.
        /// </summary>
        int iUserGuess;
        /// <summary>
        /// Holds the frequency of each die number.
        /// </summary>
        int iOneFreq;
        int iTwoFreq;
        int iThreeFreq;
        int iFourFreq;
        int iFiveFreq;
        int iSixFreq;
        /// <summary>
        /// Holds the number of times a user has guessed a specific number.
        /// </summary>
        int iOneGuessed;
        int iTwoGuessed;
        int iThreeGuessed;
        int iFourGuessed;
        int iFiveGuessed;
        int iSixGuessed;

        #endregion

        #region Methods

        /// <summary>
        /// Allows the user to roll the die.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRoll_Click(object sender, EventArgs e)
        {
            if (ValidateUserGuess(txtBoxUserGuess.Text))
            {
                RollDie();
                UpdateGameInfo(iUserGuess);
                UpdateDisplay();
            }
        }

        /// <summary>
        /// Allows the user to reset the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        /// <summary>
        /// Rolls the die.
        /// </summary>
        private void RollDie()
        {
            //Increment the number of times played.
            iNumTimesPlayed++;
            lblTimesPlayed.Text = iNumTimesPlayed.ToString();

            picBoxDiceImage.SizeMode = PictureBoxSizeMode.StretchImage;
            Random randNum = new Random();

            //Generate random number and simulate the die rolling.
            for (int i = 1; i < 7; i++)
            {
                iDieRollResult = randNum.Next(1, 7);
                picBoxDiceImage.Image = Image.FromFile("die" + iDieRollResult.ToString() + ".gif");
                picBoxDiceImage.Refresh();
                Thread.Sleep(100);
            }
        }

        /// <summary>
        /// Checks if the user's guess was correct or not.
        /// </summary>
        /// <param name="userGuess"></param>
        private void UpdateGameInfo(int userGuess)
        {
            //Determine if the user won or lost and update accordingly.
            if (userGuess == iDieRollResult)
            {
                iNumTimesWon++;
                lblTimesWon.Text = iNumTimesWon.ToString();
            }
            else
            {
                iNumTimesLost++;
                lblTimesLost.Text = iNumTimesLost.ToString();
            }

            //Update the frequency field.
            switch (iDieRollResult)
            {
                case 1:
                    iOneFreq++;
                    break;
                case 2:
                    iTwoFreq++;
                    break;
                case 3:
                    iThreeFreq++;
                    break;
                case 4:
                    iFourFreq++;
                    break;
                case 5:
                    iFiveFreq++;
                    break;
                case 6:
                    iSixFreq++;
                    break;
            }

            //Update the number of times guessed field.
            switch (txtBoxUserGuess.Text)
            {
                case "1":
                    iOneGuessed++;
                    break;
                case "2":
                    iTwoGuessed++;
                    break;
                case "3":
                    iThreeGuessed++;
                    break;
                case "4":
                    iFourGuessed++;
                    break;
                case "5":
                    iFiveGuessed++;
                    break;
                case "6":
                    iSixGuessed++;
                    break;
            }

        }

        /// <summary>
        /// Updates the display stats.
        /// </summary>
        private void UpdateDisplay()
        {
            richTxtBoxDisplay.Text =
                "FACE\tFREQUENCY\tPERCENT\tNUMBER OF TIMES GUESSED\n" +
                "1\t" + iOneFreq + "\t\t" + ((double)iOneFreq / iNumTimesPlayed).ToString("#0.##%") + "\t\t\t" + iOneGuessed +
                "\n2\t" + iTwoFreq + "\t\t" + ((double)iTwoFreq / iNumTimesPlayed).ToString("#0.##%") + "\t\t\t" + iTwoGuessed +
                "\n3\t" + iThreeFreq + "\t\t" + ((double)iThreeFreq / iNumTimesPlayed).ToString("#0.##%") + "\t\t\t" + iThreeGuessed +
                "\n4\t" + iFourFreq + "\t\t" + ((double)iFourFreq / iNumTimesPlayed).ToString("#0.##%") + "\t\t\t" + iFourGuessed +
                "\n5\t" + iFiveFreq + "\t\t" + ((double)iFiveFreq / iNumTimesPlayed).ToString("#0.##%") + "\t\t\t" + iFiveGuessed +
                "\n6\t" + iSixFreq + "\t\t" + ((double)iSixFreq / iNumTimesPlayed).ToString("#0.##%") + "\t\t\t" + iSixGuessed;
        }

        /// <summary>
        /// Validates the user's guess and displays an error label if needed.
        /// </summary>
        /// <param name="userGuess"></param>
        /// <returns>True if valid, false if not.</returns>
        private bool ValidateUserGuess(string userGuess)
        {
            if (!Int32.TryParse(txtBoxUserGuess.Text, out iUserGuess))
            {
                lblError.Text = "Error, you must enter a number.";
                return false;
            }
            if (iUserGuess < 0 || iUserGuess > 6)
            {
                lblError.Text = "Error, please enter a number between 1 and 6.";
                return false;
            }
            else
            {
                lblError.Text = "";
                return true;
            }
        }

        /// <summary>
        /// Resets the game.
        /// </summary>
        private void ResetGame()
        {
            txtBoxUserGuess.Text = "";

            iNumTimesPlayed = 0;
            iNumTimesWon = 0;
            iNumTimesLost = 0;
            lblTimesPlayed.Text = "0";
            lblTimesWon.Text = "0";
            lblTimesLost.Text = "0";

            iOneFreq = 0;
            iTwoFreq = 0;
            iThreeFreq = 0;
            iFourFreq = 0;
            iFiveFreq = 0;
            iSixFreq = 0;

            iOneGuessed = 0;
            iTwoGuessed = 0;
            iThreeGuessed = 0;
            iFourGuessed = 0;
            iFiveGuessed = 0;
            iSixGuessed = 0;

            richTxtBoxDisplay.Text =
                "FACE\tFREQUENCY\tPERCENT\tNUMBER OF TIMES GUESSED";

            lblError.Text = "";
        }

        #endregion

    }
}
