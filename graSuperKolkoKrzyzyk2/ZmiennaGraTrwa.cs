using System;
using System.Collections.Generic;

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
}
