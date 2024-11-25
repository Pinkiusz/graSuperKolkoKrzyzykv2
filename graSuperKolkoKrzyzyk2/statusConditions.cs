namespace graSuperKolkoKrzyzyk2
{
    public class statusConditions
    {
        internal static void checkMainStatus()
        {
            short[,] winPositions = {
                {0, 1, 2}, {3, 4, 5}, {6, 7, 8},
                {0, 3, 6}, {1, 4, 7}, {2, 5, 8},
                {0, 4, 8}, {2, 4, 6}
            };

            // Iteracja przez każdy zestaw pozycji w winPositions
            for (short i = 0; i < 8; i++)
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

        internal static void checkSmallMap()
        {
            short[,] winPositions = {
                {0, 1, 2}, {3, 4, 5}, {6, 7, 8},
                {0, 3, 6}, {1, 4, 7}, {2, 5, 8},
                {0, 4, 8}, {2, 4, 6}
            };

            short poprzedniaMapa = poprzedniePole.value;
            // Iteracja przez każdy zestaw pozycji w winPositions
            for (short i = 0; i < 8; i++)
            {
                for (short j = 0; j < 9; j++)
                {
                    if (boardHandler.mainBoard[j][winPositions[i, 0]] == 'X' &&
                        boardHandler.mainBoard[j][winPositions[i, 1]] == 'X' &&
                       boardHandler.mainBoard[j][winPositions[i, 2]] == 'X')
                    {
                        boardHandler.mapWon(j, 'X');
                        finishedBoards.setSmallBoard(j, 'X');
                        break;
                    }
                    else if (boardHandler.mainBoard[j][winPositions[i, 0]] == 'O' &&
                             boardHandler.mainBoard[j][winPositions[i, 1]] == 'O' &&
                             boardHandler.mainBoard[j][winPositions[i, 2]] == 'O')
                    {
                        boardHandler.mapWon(j, 'O');
                        finishedBoards.setSmallBoard(j, 'O');
                        break;
                    }
                }


                // Sprawdza, czy wszystkie pozycje w danym układzie mają ten sam znak


            }

        }

        public static void checkDraw()
        {
            for (short i = 0; i < 9; i++)
            {
                if (finishedBoards.iloscRuchow[i] == 9 && finishedBoards.winnerOfSmallBoard[i] == '-')
                {
                    finishedBoards.iloscRuchow[i] = 0;
                    boardHandler.mapDraw(i);
                    break;
                }
            }

        }

        public static void checkBoth()
        {
            checkSmallMap();
            checkMainStatus();
            checkDraw();
        }
    }
}