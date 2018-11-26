using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameofFour
{
    class gamelogic
    {
        ////top-left diagonal win check
        //for (int row = 0; row < this.board.GetLength(0)-3; row++)
        //{
        //    for (int col = 0; col < this.board.GetLength(1) - 3; col++)
        //    {
        //        if (this.AllNumbersEqual(playerToCheck, this.board[row, col], this.board[row+1, col + 1], this.board[row+2, col + 2], this.board[row+3, col + 3]))
        //            return playerToCheck;
        //    }
        //}

        ////top-right diagonal win check
        //for (int row = 0; row < this.board.GetLength(0) - 3; row++)
        //{
        //    for (int col = 3; col < this.board.GetLength(1); col++)
        //    {
        //        if (this.AllNumbersEqual(playerToCheck, this.board[row, col], this.board[row + 1, col - 1], this.board[row + 2, col - 2], this.board[row + 3, col - 3]))
        //            return playerToCheck;
        //    }
        //}
    }
}
