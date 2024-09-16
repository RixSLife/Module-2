namespace Module_2_Lesson_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100.
            Console.WriteLine(" \r\nZadanie 1\n");
            bool isPrime;
            int primeNumbersCount = 0;
            Console.WriteLine("Liczby pierwsze w zakresie 0-100:\n");





            Console.WriteLine($"Jest {primeNumbersCount} liczb pierwszych w zakresie 0-100: ");

            // 2.Napisz program, w którym za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z
            // zakresu 0 – 1000.
            Console.WriteLine(" \r\nZadanie 2\n");

            Console.WriteLine("Liczby parzyste w zakresie 0-1000:\n");

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ", ");
                }
            }
            // 3.Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.
            Console.WriteLine("\n \nZadanie 3\n");

            Console.WriteLine("Pierwsze 30 liczb ciagu Fibonacciego:\n");

            long a = 0;
            long b = 1;
            long c;

            for (int i = 0; i < 10; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                b = c + a;
                Console.Write(b + " ");
                a = b + c;
                Console.Write(a + " ");
            }

            // 4.Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej
            // liczby w formie jak poniżej:
            // 1
            // 2 3
            // 4 5 6
            // 7 8 9 10
            Console.WriteLine("\n \nZadanie 4\n");

            int chosenNumber;

            Console.WriteLine("Podaj liczbe calkowita aby wyswietlic piramide liczb: ");

            string choose = Console.ReadLine();
            Int32.TryParse(choose, out chosenNumber);

            a = 1;
            b = 1;

            for (int i = 1; i <= chosenNumber; i++)
            {
                if (a == b)
                {
                    Console.WriteLine(i);
                    b++;
                    a = 1;
                }
                else
                {
                    Console.Write(i + " ");
                    a++;
                }

            }




            // 5.Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.
            Console.WriteLine(" \r\nZadanie 5\n");

            int thirdPower;

            Console.WriteLine("potega trzecia dla liczb  1-20\n");

            for (int i = 1; i <= 20; i++)
            {
                thirdPower = i * i * i;
                Console.WriteLine($"{i} do potegi trzeciej wynosi {thirdPower}.");
            }

            // 6.Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru:
            //             1 + ½ +1 / 3 + ¼ itd.
            Console.WriteLine(" \r\nZadanie 6\n");

            int num = 20;
            double fractions = 1;

            for (int i = 2; i <= num; i++)
            {
                fractions += (1.0 / i);
            }
            Console.WriteLine($"Suma szeregu harmonicznego do 1/20 wynosi: {fractions}");

            // 7.Napisz program, który dla liczby zadanej przez użytkownika narysuje diament o krótszej
            // przekątnej o długości wprowadzonej przez użytkownika i wg wzoru:
            //               *
            //              ***
            //             *****
            //            *******
            //           *********
            //            *******
            //             *****
            //              ***
            //               *
            Console.WriteLine(" \r\nZadanie 7\n");

            decimal diamondDiagonal;
            Console.WriteLine("Wprowadz dlugosc przekatnej diamentu: ");

            string diamondChoice = Console.ReadLine();
            decimal.TryParse(diamondChoice, out diamondDiagonal);

            if (diamondDiagonal % 2 != 0)
            {
                for (int i = 0; i <= diamondDiagonal; i++)
                {
                    if (i % 2 == 0)
                    {
                        for (int j = 0; j < diamondDiagonal - i; j++)
                        {
                            if (j % 2 == 0)
                            {
                                Console.Write(" ");
                            }
                        }
                        for (int k = 0; k < i + 1; k++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine("");
                    }
                }
                for (int i = 0; i <= diamondDiagonal; i++)
                {
                    if (i % 2 == 0)
                    {
                        for (int l = -4; l < ((diamondDiagonal + i) - diamondDiagonal); l++)
                        {
                            if (l % 2 == 0)
                            {
                                Console.Write(" ");
                            }
                        }
                        for (int m = 2; m < diamondDiagonal - i; m++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.Write("*");
                            }
                        }
                        Console.WriteLine("");
                    }
                }
            }
            else
            {
                for (int i = 0; i <= diamondDiagonal; i++)
                {
                    if (i % 2 == 0)
                    {
                        for (int j = 0; j < (diamondDiagonal + 1) - i; j++)
                        {
                            if (j % 2 == 0)
                            {
                                Console.Write(" ");
                            }
                        }
                        for (int k = 0; k < i + 1; k++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine("");
                    }
                }
                for (int i = 0; i <= diamondDiagonal; i++)
                {
                    if (i % 2 == 0)
                    {
                        for (int l = -4; l < (diamondDiagonal + i) - diamondDiagonal; l++)
                        {
                            if (l % 2 == 0)
                            {
                                Console.Write(" ");
                            }
                        }
                        for (int m = 1; m < diamondDiagonal - i; m++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.Write("*");
                            }
                        }
                        Console.WriteLine("");
                    }
                }
            }
            // 8.Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków.Np.
            // Testowe dane:
            // Abcdefg
            // Rezultat
            // Gfedcba
            Console.WriteLine(" \r\nZadanie 8\n");

            Console.WriteLine("Wpisz ciag znakow ktory zostanie odwrocony przez program:");

            string characters = Console.ReadLine();
            char rotated;

            for (int i = 0; i < characters.Length; i++)
            {
                int l = (characters.Length - 1) - i;
                rotated = characters[l];
                Console.Write(rotated);
            }


            // 9.Napisz program, który zamieni liczbę dziesiętną na liczbę binarną.
            Console.WriteLine("\n \nZadanie 9\n");

            int decimalNumber;
            string reminder = string.Empty; ;
            Console.WriteLine("Podaj liczbę dziesiętną by zmienic ja na liczbę binarną:");

            string choice = Console.ReadLine();
            Int32.TryParse(choice, out decimalNumber);

            while (decimalNumber > 0)
            {
                reminder = (decimalNumber % 2) + reminder;
                decimalNumber /= 2;
            }
            Console.WriteLine($"Twoja liczba w systemie binarnym to {reminder}.");

            // 10.Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb.
            Console.WriteLine(" \r\nZadanie 10\n");

            int numA;
            int numB;
            int leastCommonMultiple = 0;
            Console.WriteLine("Podaj dwie liczby aby wyswietlic najmniejszą wspólną wielokrotność: ");

            Console.WriteLine("Liczba pierwsza: ");
            choice = Console.ReadLine();
            Int32.TryParse(choice, out numA);

            Console.WriteLine("Liczba druga: ");
            choice = Console.ReadLine();
            Int32.TryParse(choice, out numB);

            if (numB % numA == 0)
            {
                leastCommonMultiple = numB;
            }
            else if (numA % numB == 0)
            {
                leastCommonMultiple = numA;
            }
            else if (numA < numB)
            {
                for (int i = 2; i < 100; i++)
                {
                    if ((numB * i) % numA == 0)
                    {
                        leastCommonMultiple = numB * i;
                        break;
                    }
                }
            }
            else if (numB < numA)
            {
                for (int i = 2; i < 100; i++)
                {
                    if ((numA * i) % numB == 0)
                    {
                        leastCommonMultiple = numA * i;
                        break;
                    }
                }
            }
            Console.WriteLine($"Najmniejsza wspólna wielokrotność dla liczb {numA} i {numB} to {leastCommonMultiple}");

            Console.WriteLine("\nEnd of the story.... ;)");
        }
    }
}
