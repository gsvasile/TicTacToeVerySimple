using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToeGUI : Form
    {
        private readonly TicTacToeLogic ticTacToeGame = new TicTacToeLogic();
        private string startingMessage = "X's turn!";
        private string midGameMessage = "{0}'s turn!";
        private Button[,] buttonGrid;

        public TicTacToeGUI()
        {
            InitializeComponent();
            ticTacToeGame.FoundAWinner += OnFoundAwinner;
            ClearGameBoardAndIndicators();
            buttonGrid = new Button[3, 3]
            {
                { zeroZeroButton, zeroOneButton, zeroTwoButton },
                { oneZeroButton,  oneOneButton,  oneTwoButton },
                { twoZeroButton,  twoOneButton,  twoTwoButton },
            };
        }

        /// <summary>
        /// Sets the game board button.
        /// </summary>
        /// <param name="buttonToMark"></param>
        private void MarkBameBoardItem(Button buttonToMark)
        {
            buttonToMark.Text = ticTacToeGame.IsCircleTurn ? "O" : "X";
            buttonToMark.Enabled = false;
        }

        /// <summary>
        /// Updates the game result text bex.
        /// </summary>
        private void UpdateGameResultMessage()
        {
            gameResultTextBox.Text = string.Format(midGameMessage, !ticTacToeGame.IsCircleTurn ? "O" : "X");
        }

        /// <summary>
        /// This performs a move, updating the logic and the GUI.
        /// </summary>
        /// <param name="moveMade">The place that the player made their move.</param>
        /// <param name="row">The row on the game board where the move was made.</param>
        /// <param name="column">The column on the game board where the move was made.</param>
        private void PerformAMove(Button moveMade, int row, int column)
        {
            MarkBameBoardItem(moveMade);
            UpdateGameResultMessage();
            ticTacToeGame.MakeAmove(row, column);
        }

        /// <summary>
        /// Clears the game board buttons and indicators.
        /// </summary>
        private void ClearGameBoardAndIndicators()
        {
            foreach(Control control in gameBoard.Controls)
            {
                control.Enabled = true;
                control.Text = string.Empty;
                SetButtonBackColor(control as Button, DefaultBackColor);
            }

            gameResultTextBox.Text = startingMessage;
        }

        /// <summary>
        /// Sets the button's back color.
        /// </summary>
        /// <param name="button">The button to have it's back color set.</param>
        /// <param name="color">The color to set.</param>
        private void SetButtonBackColor(Button button, Color color)
        {
            if(button == null)
            {
                return;
            }

            button.BackColor = color;
        }

        /// <summary>
        /// Handles when the found winner event occurs.
        /// </summary>
        private void OnFoundAwinner(object sender, EventArgs args)
        {
            foreach(Control control in gameBoard.Controls)
            {
                control.Enabled = false;
            }

            string gameResult = string.Empty;
            if(ticTacToeGame.Winner == TicTacToeLogic.DRAWINDICATOR)
            {
                gameResultTextBox.Text = "DRAW";
            }
            else if(ticTacToeGame.Winner == TicTacToeLogic.WINNERINDICATORX)
            {
                gameResultTextBox.Text = "X Wins!";
            }
            else // If we get here, then O wins.
            {
                gameResultTextBox.Text = "O Wins!";
            }

            IndicateWinningCells();
        }

        /// <summary>
        /// This will highlight the winning cells.
        /// </summary>
        private void IndicateWinningCells()
        {
            if(ticTacToeGame.WinningSolutionCells != null)
            {
                foreach(var cell in ticTacToeGame.WinningSolutionCells)
                {
                    SetButtonBackColor(buttonGrid[cell[0], cell[1]], SystemColors.ActiveCaption);
                }
            }
        }


        // -------- EVENT HANDLERS ------------------------------//

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            ticTacToeGame.ResetGame();
            ClearGameBoardAndIndicators();
        }

        private void zeroZeroButton_Click(object sender, EventArgs e)
        {
            PerformAMove(zeroZeroButton, 0, 0);
        }

        private void zeroOneButton_Click(object sender, EventArgs e)
        {
            PerformAMove(zeroOneButton, 0, 1);
        }

        private void zeroTwoButton_Click(object sender, EventArgs e)
        {
            PerformAMove(zeroTwoButton, 0, 2);
        }

        private void oneZeroButton_Click(object sender, EventArgs e)
        {
            PerformAMove(oneZeroButton, 1, 0);
        }

        private void oneOneButton_Click(object sender, EventArgs e)
        {
            PerformAMove(oneOneButton, 1, 1);
        }

        private void oneTwoButton_Click(object sender, EventArgs e)
        {
            PerformAMove(oneTwoButton, 1, 2);
        }

        private void twoZeroButton_Click(object sender, EventArgs e)
        {
            PerformAMove(twoZeroButton, 2, 0);
        }

        private void twoOneButton_Click(object sender, EventArgs e)
        {
            PerformAMove(twoOneButton, 2, 1);
        }

        private void twoTwoButton_Click(object sender, EventArgs e)
        {
            PerformAMove(twoTwoButton, 2, 2);
        }

        private void gameResultTextBox_Enter(object sender, EventArgs e)
        {
            gameResultTextBox.Enabled = false;
            gameResultTextBox.Enabled = true;
        }

        private void gameResultTextBox_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void gameResultTextBox_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
        }
    }
}
