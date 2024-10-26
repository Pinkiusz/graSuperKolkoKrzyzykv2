using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graSuperKolkoKrzyzyk2
{
    public class graTrwa
    {
        //Tworzy zmienną która zapisuje czy gra dalej trwa
        public static bool value = false;

        //Użyj jeśli chcesz zmienić wartość na odwrotną tej zmiennej ^^^
        public static void changeState(bool newValue)
        {
            value = newValue;
        }
        
    }
    //Tworzy nowy obiekt który posiada wartość ilości graczy
    public class liczbaGraczy
    {
        //Podstawowe ustawienie wartości zmiennej ilości graczy
        public static int value = 1;

        //Użyj tej funkcji jak chcesz ustawić inną wartość zmiennej ilości graczy
        public static void setValue(int newvalue)
        {
            value = newvalue;
        }
    }

    //Tworzy nowy obiekt który posiada wartość poprzedniego zagranego pola
    public class poprzedniePole
    {
       
        //Zmienna która sprawdza czy poprzednie zagrane pole zostało ustawione (istnieje)
        //Mozna byłoby usunąć do optymalizacji kodu i używać value != null ale tak mi było łatwiej
        public static bool wybrane = false;

        //Tworzenie zmiennej która zapisuje poprzednie pole
        public static int value;

        //Użyj jeśli chcesz zmienić wartość poprzedniego pola
        public static void set(int newvalue)
        {
            value = newvalue;
            wybrane = true;
        }
    }
}
