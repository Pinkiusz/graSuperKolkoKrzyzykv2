//using System;
//namespace SuperGraKolkoKrzyzyk2;
//class PlayersMovement
//{

//public static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
//    public static char currentPlayer = 'X';

//    public static void Main()
//    {
//        int moves = 0;
//        bool gameWon = false;

//        while (!gameWon && moves < 9)
//        {
//            Console.Clear();
//            DisplayBoard();

//            Console.WriteLine($"\nGracz {currentPlayer}, wybierz pole (1-9): ");
//            if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 9 && board[choice - 1] == (choice + '0'))
//            {
//                board[choice - 1] = currentPlayer;
//                gameWon = CheckWin();
//                if (gameWon) Console.WriteLine($"\nGracz {currentPlayer} wygrał!");
//                currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
//                moves++;
//            }
//            else
//            {
//                Console.WriteLine("Błędny wybór. Spróbuj ponownie.");
//            }
//        }

//        if (!gameWon) Console.WriteLine("Remis!");
//    }

//    public static void DisplayBoard()
//    {
//        Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
//        Console.WriteLine("---|---|---");
//        Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
//        Console.WriteLine("---|---|---");
//        Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
//    }

//    public static bool CheckWin()
//    {
//        int[,] winPositions = {
//                {0, 1, 2}, {3, 4, 5}, {6, 7, 8},
//                {0, 3, 6}, {1, 4, 7}, {2, 5, 8},
//                {0, 4, 8}, {2, 4, 6}
//            };

//        foreach (var pos in winPositions)
//        {
//            if (board[pos[0]] == currentPlayer && board[pos[1]] == currentPlayer && board[pos[2]] == currentPlayer)
//                return true;
//        }

//        return false;
//    }
//}
