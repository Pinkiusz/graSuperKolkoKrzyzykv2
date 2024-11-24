using System;
using System.Diagnostics;

namespace graSuperKolkoKrzyzyk2
{
    public class mainGameLoop
    {

        public static void Main()
        {
            // Wyświetl w megabajtach w Exit, jeśli gra zakończy się
            bool poczatek = true;
            while (poczatek)
            {
                Console.Title = "Super Kółko i Krzyżyk - Gra";
                Console.Write("Super Kółko i Krzyżyk:\n 1.Start.\n 2.Jak grać?\n 3.Wyjdź.\nGra Stworzona przez Antoni Kwiatkowski oraz Marcel Wenderholm.\nPomysł na grę: „Vsauce - How To Play Super Tic-Tac-Toe (Youtube)”.\nAby kontynuoować należy wpisać 1, 2 lub 3.\n");

                object input = Console.ReadLine();

                if (input != null)
                {
                    if (inputFunctions.checkIfShort(input))
                    {
                        short newInput = (short)Convert.ToInt16(input);

                        if (newInput >= 1 && newInput <= 3)
                        {
                            if (newInput == 1)
                            {
                                startGame();
                            }
                            else if (newInput == 2)
                            {
                                howToPlay();
                            }
                            else
                            {
                                Exit();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wybrano nie istniejącą opcję");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wczytana wartość musi być liczbą");
                    }
                }
                else
                {
                    Console.WriteLine("Wczytana wartość nie może być pusta");
                }
            }
        }

        private static void startGame()
        {
            graTrwa.changeState(true);
            while (graTrwa.value)
            {
                boardHandler.showMainBoard();
                boardHandler.newTurn();
            }
            Main();
        }

        private static void howToPlay()
        {
            bool finishedReading = false;
            while (!finishedReading)
            {
                Console.WriteLine("Jak Grać: \n Super Kółko i Krzyżyk to ulepszona wersja znanej gry „kółko i krzyżyk”.\n Gra rozpoczyna się od narysowania planszy, jak w klasycznym kółku i krzyżyku, jednak w każdym polu, \n w którym normalnie umieszczany byłby znak, rysowana jest kolejna plansza do tej gry. \n Pierwszy gracz ma możliwość wyboru dowolnego z 81 pól, aby położyć swój znak. \n Każdy kolejny gracz musi stawiać swój znak w małej planszy odpowiadającej polu, \n w którym umieścił znak poprzedni gracz. \n Na przykład, jeśli pierwszy gracz położy znak w środkowej planszy w prawym górnym rogu, \n następny gracz będzie musiał zagrać w prawej górnej małej planszy. \n Gdy jedna z małych gier zostanie wygrana (tj. gdy gracz ułoży 3 swoje znaki w rządku), \n całej grze przypisywany jest znak zwycięzcy tej małej gry. \n Jeśli gracz zostanie zmuszony do zagrania w zakończonej już grze, może wybrać dowolne pole. \n Gra kończy się, gdy któryś z graczy ułoży w rządku 3 wygrane małe gry.");
                Console.WriteLine("Aby kontynuuować wpisz 1.");
                object input = Console.ReadLine();
                if (input != null)
                {
                    if (inputFunctions.checkIfShort(input))
                    {
                        short newInput = (short)Convert.ToInt16(input);

                        if (newInput == 1)
                        {
                            finishedReading = true;
                        }
                        else
                        {
                            Console.WriteLine("Wczytana wartość jest poza zasięgiem");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wczytana wartość musi być liczbą");
                    }
                }
                else
                {
                    Console.WriteLine("Wczytana wartość nie może być pusta");
                }
            }
            Main();
        }

        private static void Exit()
        { 
            Environment.Exit(0);
        }
    }
}
