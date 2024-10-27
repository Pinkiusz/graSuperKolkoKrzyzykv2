using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graSuperKolkoKrzyzyk2
{
    public class inputFunctions
    {
        //Sprawdza czy podany objekt można zapisać jako tablica intów (nie sprawdza czy objekt jest o wartości null)
        public static bool checkIfShortArray(object input)
        {
            string[] inputString = Convert.ToString(input).Split('.');

            short dlugosc = (short)(inputString.Length);

            if (dlugosc < 2)
            {
                return false;
            }

            if (!(short.TryParse(inputString[0], out short num))){
                return false;
            }

            if (!(short.TryParse(inputString[1], out short num2)))
            {
                return false;
            }

            return true;
        }

        //Sprawdza czy podany objekt można zapisać jako int (nie sprawdza czy objekt jest o wartosci null)
        public static bool checkIfShort(object input)
        {
            if (short.TryParse(input.ToString(), out short inputInt))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
