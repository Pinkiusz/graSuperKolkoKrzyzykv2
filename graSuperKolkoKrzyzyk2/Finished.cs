public class finishedBoards
{
    public static int[] iloscRuchow = createIloscRuchow();

    public static bool valueBoardMain = false;
    public static char winnerOfBoardMain;

    public static char[] winnerOfSmallBoard = makeCleanWinnerBoardValues();
    public static bool[] valueSmallBoard = makeCleanBoardValues();


    private static int[] createIloscRuchow()
    {
        int[] temp = new int[9];
        for (int i = 0; i < 9; i++)
        {
            temp[i] = 0;
        }
        return temp;
    }

    internal static char[] makeCleanWinnerBoardValues()
    {
        char[] tymczasowa = new char[9];
        for (short i = 0; i < 9; i++)
        {
            tymczasowa[i] = '-';
        }
        return tymczasowa;
    }

    internal static bool[] makeCleanBoardValues()
    {
        bool[] tymczasowa = new bool[9];
        for (short i = 0; i < 9; i++)
        {
            tymczasowa[i] = false;
        }

        return tymczasowa;
    }

    public static void setSmallBoard(short mapa, char znak)
    {
        winnerOfSmallBoard[mapa] = znak;
        valueSmallBoard[mapa] = true;
    }

    public static void changeBigBoardValue(char znak)
    {
        winnerOfBoardMain = znak;
        valueBoardMain = true;
    }

}