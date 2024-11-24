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

        public static void mapDraw(short mapa)
        {
            for (int i = 0; i<9; i++)
            {
                mainBoard[mapa][i] = '-';
            }
        }

        public static void mapWon(short mapa, char znak)
        {
            if (znak == 'X')
            {
                mainBoard[mapa][0] = 'X'; mainBoard[mapa][1] = ' '; mainBoard[mapa][2] = 'X';
                mainBoard[mapa][3] = ' '; mainBoard[mapa][4] = 'X'; mainBoard[mapa][5] = ' ';
                mainBoard[mapa][6] = 'X'; mainBoard[mapa][7] = ' '; mainBoard[mapa][8] = 'X';
            }
            else
            {
                mainBoard[mapa][0] = 'O'; mainBoard[mapa][1] = 'O'; mainBoard[mapa][2] = 'O';
                mainBoard[mapa][3] = 'O'; mainBoard[mapa][4] = ' '; mainBoard[mapa][5] = 'O';
                mainBoard[mapa][6] = 'O'; mainBoard[mapa][7] = 'O'; mainBoard[mapa][8] = 'O';
            }
        }

        // Wyświetla aktualny stan całej planszy w konsoli
        internal static void showMainBoard()
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
        internal static void newTurn()
        {
            List<string> mapSlownie =
                [
                    "w lewej górnej mapie", "w środkowej górnej mapie", "w prawej górnej mapie",
                    "w lewej środkowej mapie", "w środkowej mapie", "w prawej środkowej mapie",
                    "w lewej dolnej mapie", "w środkowej dolnej mapie", "w prawej dolnej mapie"
                ];


            // Wykonanie pierwszego ruchu
            bool pierwszyRuchWykonany = false;
            while (!pierwszyRuchWykonany && graTrwa.value)
            {
                statusConditions.checkMainStatus();
                // Sprawdza, czy pierwszy ruch już wykonano; jeśli tak, pozwala wybrać pole w poprzednio wybranej "małej mapce"
                if (poprzedniePole.wybrane && finishedBoards.winnerOfSmallBoard[poprzedniePole.value] != 'X' && finishedBoards.winnerOfSmallBoard[poprzedniePole.value] != 'O')
                {
                    Console.WriteLine($"Tura gracza 'X':\nWybierz pole do postawienia swojego znaku {mapSlownie[poprzedniePole.value]} (wartość mui być w zakresie <1,9>)");
                    object? input = Console.ReadLine();
                    string inputInput = input.ToString();
                    if (inputInput == "admin.setPole")
                    {
                        object? liczby = Console.ReadLine();
                        string[] liczbyString = liczby.ToString().Split(' ');
                        short[] liczbyLiczby = Array.ConvertAll(liczbyString, short.Parse);
                        liczbyLiczby[1]--;
                        liczbyLiczby[0]--;
                        finishedBoards.iloscRuchow[liczbyLiczby[0]]++;
                        Console.WriteLine(finishedBoards.iloscRuchow[liczbyLiczby[0]]);

                        changeBoardValue(liczbyLiczby[0], liczbyLiczby[1], 'X');
                        Console.WriteLine($"Postawiłeś znak (X) w polu nr.{liczbyLiczby[1] + 1} {mapSlownie[liczbyLiczby[0]]}");
                        statusConditions.checkBoth();
                        poprzedniePole.set(liczbyLiczby[1]);
                        pierwszyRuchWykonany = true;

                    }
                    else if (input == null || !(inputFunctions.checkIfShort(input)))
                    {
                        Console.WriteLine("Nieprawidłowa wartość, wprowadź liczbę od 1 do 9");
                        continue;
                    }
                    else
                    {
                        short newInput = (short)(Convert.ToInt16(input) - 1);
                        if (newInput >= 0 && newInput <= 8)
                        {
                            if (checkIfFree(poprzedniePole.value, newInput))
                            {
                                changeBoardValue(poprzedniePole.value, newInput, 'X');
                                Console.WriteLine($"Postawiłeś znak (X) w polu nr.{newInput + 1} {mapSlownie[poprzedniePole.value]}");
                                finishedBoards.iloscRuchow[poprzedniePole.value]++;
                                statusConditions.checkBoth();
                                poprzedniePole.set(newInput);
                                pierwszyRuchWykonany = true;
                            }
                            else
                            {
                                Console.WriteLine("Nie można użyć pola, które jest już zajęte");
                                continue;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wartość musi być w zakresie <1,9>");
                            continue;
                        }
                    }
                }
                // Pierwszy ruch gry: wybór pola na mapie (format [mapa].[pole])
                else
                {
                    Console.WriteLine("Tura gracza 'X':\nWybierz mape i pole do postawienia swojego znaku (obie wartości muszą być w zakresie <1,9>)\nWartość należy wpisać w formacie mapa.pole\n(Na przykład: '7.8' postawi znak w mapie w lewym dolnym rogu w środkowym dolnym polu)");
                    object? input = Console.ReadLine();
                    string inputInput = input.ToString();
                    if (inputInput == "admin.setPole")
                    {
                        object? liczby = Console.ReadLine();
                        string[] liczbyString = liczby.ToString().Split(' ');
                        short[] liczbyLiczby = Array.ConvertAll(liczbyString, short.Parse);
                        liczbyLiczby[0]--;
                        liczbyLiczby[1]--;
                        finishedBoards.iloscRuchow[liczbyLiczby[0]]++;
                        Console.WriteLine(finishedBoards.iloscRuchow[liczbyLiczby[0]]);
                        changeBoardValue(liczbyLiczby[0], liczbyLiczby[1], 'X');
                        Console.WriteLine($"Postawiłeś znak (X) w polu nr.{liczbyLiczby[1] + 1} {mapSlownie[liczbyLiczby[0]]}");
                        statusConditions.checkBoth();
                        poprzedniePole.set(liczbyLiczby[0]);
                        pierwszyRuchWykonany = true;


                    }

                    else if (input == null || !(inputFunctions.checkIfShortArray(input)))
                    {
                        Console.WriteLine("Nieprawidłowa wartość, wprowadź dwie liczby w zakresie <1,9>");
                        continue;
                    }
                    else
                    {
                        short[] newInput = Array.ConvertAll((Convert.ToString(input).Split('.')), short.Parse);
                        short malaMapka = (short)(newInput[0] - 1);
                        short pole = (short)(newInput[1] - 1);
                        if (malaMapka >= 0 && malaMapka <= 8 && pole >= 0 && pole <= 8 && checkIfFree(malaMapka, pole))
                        {

                            changeBoardValue(malaMapka, pole, 'X');
                            Console.WriteLine($"Postawiłeś znak (X) w polu nr.{pole + 1} {mapSlownie[malaMapka]}");
                            statusConditions.checkBoth();
                            poprzedniePole.set(pole);
                            pierwszyRuchWykonany = true;
                        }
                        else
                        {
                            Console.WriteLine("Obie wartości muszą być w zakresie <1,9>");
                            continue;
                        }
                    }
                }
            }


            // Wykonanie drugiego ruchu w grze dla kolejnego gracza
            bool drugiRuchWykonany = false;
            showMainBoard();
            while (!drugiRuchWykonany && graTrwa.value)
            {
                statusConditions.checkMainStatus();
                if (poprzedniePole.wybrane && finishedBoards.winnerOfSmallBoard[poprzedniePole.value] != 'X' && finishedBoards.winnerOfSmallBoard[poprzedniePole.value] != 'O')
                {
                    Console.WriteLine($"Tura gracza 'O':\nWybierz pole do postawienia swojego znaku {mapSlownie[poprzedniePole.value]} (wartość mui być w zakresie <1,9>)");
                    object? input = Console.ReadLine();
                    string inputInput = input.ToString();
                    if (inputInput == "admin.setPole")
                    {
                        object? liczby = Console.ReadLine();
                        string[] liczbyString = liczby.ToString().Split(' ');
                        short[] liczbyLiczby = Array.ConvertAll(liczbyString, short.Parse);
                        liczbyLiczby[0]--;
                        liczbyLiczby[1]--;

                        finishedBoards.iloscRuchow[liczbyLiczby[0]]++;
                        Console.WriteLine(finishedBoards.iloscRuchow[liczbyLiczby[0]]);

                        changeBoardValue(liczbyLiczby[0], liczbyLiczby[1], 'O');
                        Console.WriteLine($"Postawiłeś znak (O) w polu nr.{liczbyLiczby[1] + 1} {mapSlownie[liczbyLiczby[0]]}");
                        statusConditions.checkBoth();
                        poprzedniePole.set(liczbyLiczby[0]);
                        drugiRuchWykonany = true;

                    }
                    else if (input == null || !(inputFunctions.checkIfShort(input)))
                    {
                        Console.WriteLine("Nieprawidłowa wartość, wprowadź liczbę od 1 do 9");
                        continue;
                    }
                    else
                    {
                        short newInput = (short)(Convert.ToInt16(input) - 1);
                        if (newInput >= 0 && newInput <= 8)
                        {
                            if (checkIfFree(poprzedniePole.value, newInput))
                            {
                                changeBoardValue(poprzedniePole.value, newInput, 'O');
                                Console.WriteLine($"Postawiłeś znak (O) w polu nr.{newInput + 1} {mapSlownie[poprzedniePole.value]}");
                                statusConditions.checkBoth();
                                poprzedniePole.set(newInput);
                                drugiRuchWykonany = true;
                            }
                            else
                            {
                                Console.WriteLine("Nie można użyć pola, które jest już zajęte");
                                continue;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wartość musi być w zakresie <1,9>");
                            continue;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Tura gracza 'O':\nWybierz mape i pole do postawienia swojego znaku (obie wartości muszą być w zakresie <1,9>)\nWartość należy wpisać w formacie mapa.pole\n(Na przykład: '7.8' postawi znak w mapie w lewym dolnym rogu w środkowym dolnym polu)");
                    object? input = Console.ReadLine();
                    string inputInput = input.ToString();
                    if (inputInput == "admin.setPole")
                    {
                        object? liczby = Console.ReadLine();
                        string[] liczbyString = liczby.ToString().Split(' ');
                        short[] liczbyLiczby = Array.ConvertAll(liczbyString, short.Parse);
                        liczbyLiczby[0]--;
                        liczbyLiczby[1]--;
                        finishedBoards.iloscRuchow[liczbyLiczby[0]]++;
                        Console.WriteLine(finishedBoards.iloscRuchow[liczbyLiczby[0]]);

                        changeBoardValue(liczbyLiczby[0], liczbyLiczby[1], 'O');
                        Console.WriteLine($"Postawiłeś znak (O) w polu nr.{liczbyLiczby[1] + 1} {mapSlownie[liczbyLiczby[0]]}");
                        statusConditions.checkBoth();
                        poprzedniePole.set(liczbyLiczby[1]);
                        drugiRuchWykonany = true;


                    }
                    else if (input == null || !(inputFunctions.checkIfShortArray(input)))
                    {
                        Console.WriteLine("Nieprawidłowa wartość, wprowadź dwie liczby w zakresie <1,9>");
                        continue;
                    }
                    else
                    {
                        short[] newInput = Array.ConvertAll((Convert.ToString(input).Split('.')), short.Parse);
                        short malaMapka = (short)(newInput[0] - 1);
                        short pole = (short)(newInput[1] - 1);
                        if (malaMapka >= 0 && malaMapka <= 8 && pole >= 0 && pole <= 8 && checkIfFree(malaMapka, pole))
                        {

                            changeBoardValue(malaMapka, pole, 'O');
                            Console.WriteLine($"Postawiłeś znak (O) w polu nr.{pole + 1} {mapSlownie[malaMapka]}");
                            statusConditions.checkBoth();
                            poprzedniePole.set(pole);
                            drugiRuchWykonany = true;
                        }
                        else
                        {
                            Console.WriteLine("Obie wartości muszą być w zakresie <1,9>");
                            continue;
                        }
                    }
                }
            }
        }
    }
}