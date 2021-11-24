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

        public static void ShowBoard(char[] board)
        {
            Console.WriteLine(
                $"\n {board[1]} | {board[2]} | {board[3]}" +
                $"\n-----------" +
                $"\n {board[4]} | {board[5]} | {board[6]}" +
                $"\n-----------" +
                $"\n {board[7]} | {board[8]} | {board[9]}" );
        }
    }
}
