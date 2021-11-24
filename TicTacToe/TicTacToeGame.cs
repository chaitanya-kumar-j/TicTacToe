using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class TicTacToeGame
    {
        public static char[] CreateBoard()
        {
            char[] board = new char[10];
            for (int i = 1; i < board.Length; i++)
            {
                board[i] = ' ';
            }
            return board;
        }

        public static char SelectMarker()
        {
            Console.WriteLine("Select your marker, either 'O' or 'X':");
            return Console.ReadLine().ToUpper().ToCharArray()[0];
        }
    }
}
