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
        public static bool checkIfIntArray(object input)
        {
            string[] inputString = Convert.ToString(input).Split('.');

            int dlugosc = inputString.Length;

            if (dlugosc < 2)
            {
                return false;
            }

            if (!(int.TryParse(inputString[0], out int num))){
                return false;
            }

            if (!(int.TryParse(inputString[1], out int num2)))
            {
                return false;
            }

            return true;
        }

        //Sprawdza czy podany objekt można zapisać jako int (nie sprawdza czy objekt jest o wartosci null)
        public static bool checkIfInt(object input)
        {
            int inputInt;

            if (int.TryParse(input.ToString(), out inputInt))
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
