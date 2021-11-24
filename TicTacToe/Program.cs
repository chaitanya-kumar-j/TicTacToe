using System;

namespace TicTacToe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!.... Welcome To Tic-Tac-Toe Game!.....");
            
            char[] board = TicTacToeGame.CreateBoard();
            char computerMarker, playerMarker;
            playerMarker = TicTacToeGame.SelectMarker();
            
            while (playerMarker != 'O' && playerMarker != 'X')
            {
                Console.WriteLine("Select the correct marker, either 'O' or 'X' only....");
                playerMarker = TicTacToeGame.SelectMarker();
            }
            
            if (playerMarker == 'O')
            {
                computerMarker = 'X';
            }
            else
            {
                computerMarker = 'O';
            }
        }
    }
}
