/*
using System;
namespace SuperGraKolkoKrzyzyk2
    public class SystemAI
{
    public static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    public static char player = 'X';
    public static char ai = 'O';

    public static void Main()
    {
        int moves = 0;
        bool gameWon = false;

        while (!gameWon && moves < 9)
        {
            Console.Clear();
            DisplayBoard();

            if (moves % 2 == 0)
            {
                Console.WriteLine($"\nGracz {player}, wybierz pole (1-9): ");
                if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 9 && board[choice - 1] == (choice + '0'))
                {
                    board[choice - 1] = player;
                    gameWon = CheckWin(player);
                    if (gameWon) Console.WriteLine("\nGracz wygrał!");
                    moves++;
                }
                else
                {
                    Console.WriteLine("Błędny wybór. Spróbuj ponownie.");
                }
            }
            else
            {
                Random rand = new Random();
                int aiChoice;
                do
                {
                    aiChoice = rand.Next(1, 10);
                } while (board[aiChoice - 1] == player || board[aiChoice - 1] == ai);

                board[aiChoice - 1] = ai;
                gameWon = CheckWin(ai);
                if (gameWon) Console.WriteLine("\nAI wygrało!");
                moves++;
            }
        }

        if (!gameWon) Console.WriteLine("Remis!");
    }

    public static void DisplayBoard()
    {
        Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
        Console.WriteLine("---|---|---");
        Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
        Console.WriteLine("---|---|---");
        Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
    }

    public static bool CheckWin(char player)
    {
        for(int i=0; i<(i*3)+1; i++){
            int[,] winPositions = {
                    {0, 1, 2}, {3, 4, 5}, {6, 7, 8},
                    {0, 3, 6}, {1, 4, 7}, {2, 5, 8},
                    {0, 4, 8}, {2, 4, 6}
                };
        }

        foreach (var pos in winPositions)
        {
            if (board[pos[0]] == player && board[pos[1]] == player && board[pos[2]] == player)
                return true;
        }

        return false;
    }
}
*/