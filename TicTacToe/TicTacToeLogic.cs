using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class TicTacToeLogic
    {
        // -------- CONSTANTS ----------//
        public readonly static int? UNMARKEDINDICATOR = null;
        public const int TOKENCIRCLE = 0;
        public const int TOKENX = 1;
        public const string WINNERINDICATORO = "O";
        public const string WINNERINDICATORX = "X";
        public const string DRAWINDICATOR = "DRAW";

        // -------- EVENTS -------------//
        public event EventHandler FoundAWinner;

        // -------- PROPERTIES ---------//
        /// <summary>
        /// Game board property.
        /// </summary>
        public int?[,] GameBoard { get; set; }

        /// <summary>
        /// A flag indiciating if it is Circle's turn or not.
        /// </summary>
        public bool IsCircleTurn { get; set; }

        /// <summary>
        /// Indicates the winner.
        /// If X wins, this will be set to "X"
        /// If 0 wins, this will be set to "O"
        /// If there is a draw, this will bet set to "DRAW"
        /// </summary>
        public string Winner { get; set; }

        /// <summary>
        /// This has the winning cells.
        /// </summary>
        public List<int[]> WinningSolutionCells { get; set; }


        // -------- CONSTRUCTORS --------//
        /// <summary>
        /// Default Constructor
        /// </summary>
        public TicTacToeLogic()
        {
            ClearBoard();
        }

        // -------- METHODS --------//
        /// <summary>
        /// This will reset the game and clear the board.
        /// </summary>
        public void ResetGame()
        {
            ClearBoard();
            IsCircleTurn = false;
            Winner = string.Empty;
            WinningSolutionCells = null;
        }

        /// <summary>
        /// Clears the game board.
        /// </summary>
        private void ClearBoard()
        {
            GameBoard = new int?[3, 3];
        }

        /// <summary>
        /// Marks the game board and updates the logic.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        public void MakeAmove(int row, int column)
        {
            if(GameBoard[row, column] != UNMARKEDINDICATOR)
            {
                throw new ArgumentException("Error: The given move has already been made", $"[${row}, ${column}]");
            }

            GameBoard[row, column] = IsCircleTurn ? TOKENCIRCLE : TOKENX;
            ChangeWhosTurnItIs();
            CheckForAwinner();
        }

        /// <summary>
        /// This will change who's turn it is to play.
        /// </summary>
        private void ChangeWhosTurnItIs()
        {
            IsCircleTurn = !IsCircleTurn;
        }

        /// <summary>
        /// This will check a game board and check to see if the same value is in the given cells.
        /// </summary>
        /// <param name="gameBoard">The game board to check.</param>
        /// <param name="firstCell">The first cell to check on the game board.</param>
        /// <param name="secondCell">The second cell to check on the game board.</param>
        /// <param name="thirdCell">The third cell to check on the game board.</param>
        /// <returns></returns>
        private static string CheckForAwinner(int?[,] gameBoard, List<int[]> solutionCells)
        {
            var gameBoardCellValue = gameBoard[solutionCells[0][0], solutionCells[0][1]];
            if((gameBoardCellValue != UNMARKEDINDICATOR) && (gameBoardCellValue == gameBoard[solutionCells[1][0], solutionCells[1][1]]))
            {
                if(gameBoardCellValue == gameBoard[solutionCells[2][0], solutionCells[2][1]])
                {
                    if(gameBoardCellValue == TOKENCIRCLE)
                    {
                        return WINNERINDICATORO;

                    }
                    else
                    {
                        return WINNERINDICATORX;
                    }
                }
            }
            return null;

        }

        /// <summary>
        /// Checks the board to see if we have a winner or a draw.
        /// </summary>
        private void CheckForAwinner()
        {
            // Check for left diagonal win.
            Winner = CheckForAwinner(GameBoard, Solutions2D.LeftDiagonal);
            if(Winner != null)
            {
                WinningSolutionCells = Solutions2D.LeftDiagonal;
                RaiseWinnerEvent(this, EventArgs.Empty);
                return;
            }

            // Check for right diagonal win.
            Winner = CheckForAwinner(GameBoard, Solutions2D.RightDiagonal);
            if(Winner != null)
            {
                WinningSolutionCells = Solutions2D.RightDiagonal;
                RaiseWinnerEvent(this, EventArgs.Empty);
                return;
            }

            // Check for top row win.
            Winner = CheckForAwinner(GameBoard, Solutions2D.TopRow);
            if(Winner != null)
            {
                WinningSolutionCells = Solutions2D.TopRow;
                RaiseWinnerEvent(this, EventArgs.Empty);
                return;
            }

            // Check for mid row win.
            Winner = CheckForAwinner(GameBoard, Solutions2D.MiddleRow);
            if(Winner != null)
            {
                WinningSolutionCells = Solutions2D.MiddleRow;
                RaiseWinnerEvent(this, EventArgs.Empty);
                return;
            }

            // Check for a bottom row winner
            Winner = CheckForAwinner(GameBoard, Solutions2D.BottomRow);
            if(Winner != null)
            {
                WinningSolutionCells = Solutions2D.BottomRow;
                RaiseWinnerEvent(this, EventArgs.Empty);
                return;
            }

            // Check column 0 winner
            Winner = CheckForAwinner(GameBoard, Solutions2D.LeftColumn);
            if(Winner != null)
            {
                WinningSolutionCells = Solutions2D.LeftColumn;
                RaiseWinnerEvent(this, EventArgs.Empty);
                return;
            }

            // Check column 1 winner
            Winner = CheckForAwinner(GameBoard, Solutions2D.MiddleColumn);
            if(Winner != null)
            {
                WinningSolutionCells = Solutions2D.MiddleColumn;
                RaiseWinnerEvent(this, EventArgs.Empty);
                return;
            }

            // Check column 2 winner
            Winner = CheckForAwinner(GameBoard, Solutions2D.RightColumn);
            if(Winner != null)
            {
                WinningSolutionCells = Solutions2D.RightColumn;
                RaiseWinnerEvent(this, EventArgs.Empty);
                return;
            }

            // Check for a draw game.
            foreach(var gameBoardCell in GameBoard)
            {
                if(gameBoardCell == UNMARKEDINDICATOR)
                {
                    return;
                }
            }

            Winner = DRAWINDICATOR;
            RaiseWinnerEvent(this, EventArgs.Empty);
        }

        /// <summary>
        /// Raises the event if it has been registered.
        /// </summary>
        private void RaiseWinnerEvent(object sender, EventArgs args)
        {
            FoundAWinner?.Invoke(sender, args);
        }
    }
}
