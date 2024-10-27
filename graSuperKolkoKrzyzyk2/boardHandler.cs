using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace graSuperKolkoKrzyzyk2
{
    // Obsługuje główną planszę gry jako dwuwymiarową tablicę char
    public class boardHandler
    {
        // Główna plansza o wymiarach 9x9, inicjowana jako pusta plansza
        public static char[][] mainBoard = makeCleanBoard();

        // Zmienia wartość w jednym z pól planszy na znak gracza
        public static void changeBoardValue(short malaMapka, short poleMapki, char znakGracza)
        {
            mainBoard[malaMapka][poleMapki] = znakGracza;
        }

        // Wyświetla aktualny stan całej planszy w konsoli
        public static void showMainBoard()
        {
            Console.Write
            ($"               |               |           \n" +
            $"  [{mainBoard[0][0]}]|[{mainBoard[0][1]}]|[{mainBoard[0][2]}]  |  [{mainBoard[1][0]}]|[{mainBoard[1][1]}]|[{mainBoard[1][2]}]  |  [{mainBoard[2][0]}]|[{mainBoard[2][1]}]|[{mainBoard[2][2]}]\n" +
            $"  ---+---+---  |  ---+---+---  |  ---+---+---\n" +
            $"  [{mainBoard[0][3]}]|[{mainBoard[0][4]}]|[{mainBoard[0][5]}]  |  [{mainBoard[1][3]}]|[{mainBoard[1][4]}]|[{mainBoard[1][5]}]  |  [{mainBoard[2][3]}]|[{mainBoard[2][4]}]|[{mainBoard[2][5]}]\n" +
            $"  ---+---+---  |  ---+---+---  |  ---+---+---\n" +
            $"  [{mainBoard[0][6]}]|[{mainBoard[0][7]}]|[{mainBoard[0][8]}]  |  [{mainBoard[1][6]}]|[{mainBoard[1][7]}]|[{mainBoard[1][8]}]  |  [{mainBoard[2][6]}]|[{mainBoard[2][7]}]|[{mainBoard[2][8]}]\n" +
            $"               |               |           \n" +
            $"---------------+---------------+---------------\n" +
            $"               |               |           \n" +
            $"  [{mainBoard[3][0]}]|[{mainBoard[3][1]}]|[{mainBoard[3][2]}]  |  [{mainBoard[4][0]}]|[{mainBoard[4][1]}]|[{mainBoard[4][2]}]  |  [{mainBoard[5][0]}]|[{mainBoard[5][1]}]|[{mainBoard[5][2]}]\n" +
            $"  ---+---+---  |  ---+---+---  |  ---+---+---\n" +
            $"  [{mainBoard[3][3]}]|[{mainBoard[3][4]}]|[{mainBoard[3][5]}]  |  [{mainBoard[4][3]}]|[{mainBoard[4][4]}]|[{mainBoard[4][5]}]  |  [{mainBoard[5][3]}]|[{mainBoard[5][4]}]|[{mainBoard[5][5]}]\n" +
            $"  ---+---+---  |  ---+---+---  |  ---+---+---\n" +
            $"  [{mainBoard[3][6]}]|[{mainBoard[3][7]}]|[{mainBoard[3][8]}]  |  [{mainBoard[4][6]}]|[{mainBoard[4][7]}]|[{mainBoard[4][8]}]  |  [{mainBoard[5][6]}]|[{mainBoard[5][7]}]|[{mainBoard[5][8]}]\n" +
            $"               |               |           \n" +
            $"---------------+---------------+---------------\n" +
            $"               |               |           \n" +
            $"  [{mainBoard[6][0]}]|[{mainBoard[6][1]}]|[{mainBoard[6][2]}]  |  [{mainBoard[7][0]}]|[{mainBoard[7][1]}]|[{mainBoard[7][2]}]  |  [{mainBoard[8][0]}]|[{mainBoard[8][1]}]|[{mainBoard[8][2]}]\n" +
            $"  ---+---+---  |  ---+---+---  |  ---+---+---\n" +
            $"  [{mainBoard[6][3]}]|[{mainBoard[6][4]}]|[{mainBoard[6][5]}]  |  [{mainBoard[7][3]}]|[{mainBoard[7][4]}]|[{mainBoard[7][5]}]  |  [{mainBoard[8][3]}]|[{mainBoard[8][4]}]|[{mainBoard[8][5]}]\n" +
            $"  ---+---+---  |  ---+---+---  |  ---+---+---\n" +
            $"  [{mainBoard[6][6]}]|[{mainBoard[6][7]}]|[{mainBoard[6][8]}]  |  [{mainBoard[7][6]}]|[{mainBoard[7][7]}]|[{mainBoard[7][8]}]  |  [{mainBoard[8][6]}]|[{mainBoard[8][7]}]|[{mainBoard[8][8]}]\n" +
            $"               |               |           \n"
            );
        }

        // Tworzy pustą planszę 9x9, każda komórka zawiera '-'
        internal static char[][] makeCleanBoard()
        {
            char[][] mainBoard = new char[9][];
            for (short i = 0; i < 9; i++)
            {
                mainBoard[i] = new char[9];
                for (short j = 0; j < 9; j++)
                {
                    mainBoard[i][j] = '-';
                }
            }
            return mainBoard;
        }

        // Sprawdza, czy pole jest puste (zawiera '-')
        internal static bool checkIfFree(short malaMapa, short pole)
        {
            return mainBoard[malaMapa][pole] == '-';
        }

        // Obsługuje ruch gracza, pozwalając na wybór miejsca na planszy
        public static void newTurn()
        {
            // Wykonanie pierwszego ruchu
            bool pierwszyRuchWykonany = false;
            while (!pierwszyRuchWykonany)
            {
                // Sprawdza, czy pierwszy ruch już wykonano; jeśli tak, pozwala wybrać pole w poprzednio wybranej "małej mapce"
                if (poprzedniePole.wybrane)
                {
                    Console.WriteLine($"Wybierz pole do postawienia znaku w mapce: {poprzedniePole.value + 1}");
                    object? input = Console.ReadLine();
                    if (input == null)
                    {
                        Console.WriteLine("Wczytana wartość nie może być pusta");
                        continue;
                    }
                    else if (inputFunctions.checkIfShort(input))
                    {
                        short newInput = (short)(Convert.ToInt16(input) - 1);
                        if (newInput >= 0 && newInput <= 8 && checkIfFree(poprzedniePole.value, newInput))
                        {
                            changeBoardValue(poprzedniePole.value, newInput, 'X');
                            Console.WriteLine($"Postawiłeś znak (X) w polu nr.{newInput + 1}");
                            poprzedniePole.set(newInput);
                            pierwszyRuchWykonany = true;
                        }
                        else
                        {
                            Console.WriteLine("Nie można użyć wybranego pola");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidłowa wartość, wprowadź liczbę od 1 do 9");
                    }
                }
                // Pierwszy ruch gry: wybór pola na mapie (format [mapa].[pole])
                else
                {
                    Console.WriteLine("Pierwszy ruch, wybierz mapę i pole ([mapa].[pole])");
                    object? input = Console.ReadLine();
                    if (input == null)
                    {
                        Console.WriteLine("Wczytana wartość nie może być pusta");
                        continue;
                    }
                    else if (inputFunctions.checkIfShortArray(input))
                    {
                        short[] newInput = Array.ConvertAll((Convert.ToString(input).Split('.')), short.Parse);

                        short malaMapka = (short)(newInput[0] - 1);
                        short pole = (short)(newInput[1] - 1);
                        if (malaMapka >= 0 && malaMapka <= 8 && pole >= 0 && pole <= 8 && checkIfFree(malaMapka, pole))
                        {
                            changeBoardValue(malaMapka, pole, 'X');
                            Console.WriteLine($"Postawiłeś znak (X) w polu nr.{pole + 1} w mapce {malaMapka + 1}");
                            poprzedniePole.set(pole);
                            pierwszyRuchWykonany = true;
                        }
                        else
                        {
                            Console.WriteLine("Nieprawidłowe wartości");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wartość powinna być w formacie [mapa].[pole]");
                    }
                }
            }

            // Wykonanie drugiego ruchu w grze dla kolejnego gracza
            bool drugiRuchWykonany = false;
            showMainBoard();
            while (!drugiRuchWykonany)
            {
                Console.WriteLine($"Wpisz pole do postawienia znaku w mapie: {poprzedniePole.value + 1}");
                object? input = Console.ReadLine();
                if (input == null)
                {
                    Console.WriteLine("Wczytana wartość nie może być pusta");
                    continue;
                }
                else if (inputFunctions.checkIfShort(input))
                {

                   
                    short newInput = (short)(Convert.ToInt16(input) - 1);
                    if (newInput >= 0 && newInput <= 8 && checkIfFree(poprzedniePole.value, newInput))
                    {
                        changeBoardValue(poprzedniePole.value, newInput, 'O');
                        Console.WriteLine($"Postawiłeś znak (O) w polu nr.{newInput + 1}");
                        poprzedniePole.set(newInput);
                        drugiRuchWykonany = true;
                    }
                    else
                    {
                        Console.WriteLine("Nie można użyć wybranego pola");
                    }
                }
                else
                {
                    Console.WriteLine("Nieprawidłowa wartość, wprowadź liczbę od 1 do 9");
                }
            }
        }
    }
}