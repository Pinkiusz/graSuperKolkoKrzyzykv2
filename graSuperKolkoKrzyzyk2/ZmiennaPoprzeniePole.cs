using System;
using System.Collections.Generic;

namespace graSuperKolkoKrzyzyk2
{
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
