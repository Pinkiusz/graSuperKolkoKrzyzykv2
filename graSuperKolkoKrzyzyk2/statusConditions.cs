using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace graSuperKolkoKrzyzyk2
{
    public class statusConditions
    {
        public static void checkMainStatus()
        {
            int[,] winPositions = {
                {0, 1, 2}, {3, 4, 5}, {6, 7, 8},
                {0, 3, 6}, {1, 4, 7}, {2, 5, 8},
                {0, 4, 8}, {2, 4, 6}
            };

            // Iteracja przez każdy zestaw pozycji w winPositions
            for (int i = 0; i < winPositions.GetLength(0); i++)
            {
                // Sprawdza, czy wszystkie pozycje w danym układzie mają ten sam znak
                if (finishedBoards.winnerOfSmallBoard[winPositions[i, 0]] == 'X' &&
                    finishedBoards.winnerOfSmallBoard[winPositions[i, 1]] == 'X' &&
                    finishedBoards.winnerOfSmallBoard[winPositions[i, 2]] == 'X')
                {
                    graTrwa.changeState(false);
                    Console.WriteLine("Wygrał Gracz X");
                }
                else if (finishedBoards.winnerOfSmallBoard[winPositions[i, 0]] == 'O' &&
                         finishedBoards.winnerOfSmallBoard[winPositions[i, 1]] == 'O' &&
                         finishedBoards.winnerOfSmallBoard[winPositions[i, 2]] == 'O')
                {
                    Console.WriteLine("Wygrał Gracz O");
                    graTrwa.changeState(false);
                }
            }
        }

        public static void checkSmallMap()
        {
            int[,] winPositions = {
                {0, 1, 2}, {3, 4, 5}, {6, 7, 8},
                {0, 3, 6}, {1, 4, 7}, {2, 5, 8},
                {0, 4, 8}, {2, 4, 6}
            };

            short poprzedniaMapa = poprzedniePole.value;
            // Iteracja przez każdy zestaw pozycji w winPositions
            for (int i = 0; i < 8; i++)
            {
                
                // Sprawdza, czy wszystkie pozycje w danym układzie mają ten sam znak
                if (boardHandler.mainBoard[poprzedniaMapa][winPositions[i, 0]] == 'X' &&
                    boardHandler.mainBoard[poprzedniaMapa][winPositions[i, 1]] == 'X' &&
                   boardHandler.mainBoard[poprzedniaMapa][winPositions[i, 2]] == 'X')
                {
                    Console.WriteLine("debug:SprawdzamXWYGRAŁ");
                    boardHandler.mapWon(poprzedniaMapa, 'X');
                    finishedBoards.setSmallBoard(poprzedniaMapa, 'X');
                    break;
                }
                else if (boardHandler.mainBoard[poprzedniaMapa][winPositions[i, 0]] == 'O' &&
                         boardHandler.mainBoard[poprzedniaMapa][winPositions[i, 1]] == 'O' &&
                         boardHandler.mainBoard[poprzedniaMapa][winPositions[i, 2]] == 'O')
                {
                    Console.WriteLine("debug:SprawdzamO");
                    boardHandler.mapWon(poprzedniaMapa, 'O');
                    finishedBoards.setSmallBoard(poprzedniaMapa, 'O');
                    break;
                }
            }
        }
    }
}
