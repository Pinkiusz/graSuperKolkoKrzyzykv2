using System.ComponentModel;

namespace graSuperKolkoKrzyzyk2
{
    public class graTrwa
    {
        //Tworzy zmienną która zapisuje czy gra dalej trwa
        public static bool value = false;

        //Użyj jeśli chcesz zmienić wartość ^^^
        public static void changeState(bool newValue)
        {
            value = newValue;
        }

    }

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

    //Tworzy nowy obiekt który posiada wartość ilości graczy
    public class liczbaGraczy
    {
        //Podstawowe ustawienie wartości zmiennej ilości graczy
        public static short value = 1;

        //Użyj tej funkcji jak chcesz ustawić inną wartość zmiennej ilości graczy
        public static void setValue(short newValue)
        {
            value = newValue;
        }
    }

    //Tworzy nowy obiekt który posiada wartość poprzedniego zagranego pola
    public class poprzedniePole
    {

        //Zmienna która sprawdza czy poprzednie zagrane pole zostało ustawione (istnieje)
        //Mozna byłoby usunąć do optymalizacji kodu i używać value != null ale tak mi było łatwiej
        public static bool wybrane = false;

        //Tworzenie zmiennej która zapisuje poprzednie pole
        public static short value;

        //Użyj jeśli chcesz zmienić wartość poprzedniego pola
        public static void set(short newvalue)
        {
            value = newvalue;
            wybrane = true;
        }
    }
}
