namespace Module_2_Lesson_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Zadanie 1
            Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są
            one równe czy nie.
            Dane testowe:
            a: 5
            b: 5
            Rezultat w terminalu:
            5 i 5 są równe
                */
            Console.WriteLine("\nZadanie 1\n");

            int a;
            int b;
            Console.WriteLine("Podaj dwie liczby aby sprawdzic czy sa rowne: ");

            Console.WriteLine("Liczba pierwsza: ");
            string choice = Console.ReadLine();
            Int32.TryParse(choice, out a);

            Console.WriteLine("Liczba druga: ");
            choice = Console.ReadLine();
            Int32.TryParse(choice, out b);

            if (a == b)
            {
                Console.WriteLine($"Liczby {a} i {b} sa rowne.");
            }
            else
            {
                Console.WriteLine($"Liczby {a} i {b} nie sa rowne.");
            }


            /* Zadanie 2
            Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba
            jest parzysta czy nieparzysta.
            Dane testowe : 15
            Rezultat w terminalu:
            15 jest liczbą nieparzystą
                */
            Console.WriteLine("\nZadanie 2\n");

            int number;
            int zero;
            Console.WriteLine("Podaj liczbe aby sprawdzic czy jest parzysta:");

            choice = Console.ReadLine();
            Int32.TryParse(choice, out number);

            if (number == 0)
            {
                Console.WriteLine("Liczba 0 nie jest parzyst lub nieparzysta.");
            }
            else
            {
                string even = number % 2 == 0 ? $"Liczba {number} jest liczba parzysta" : $"Liczba {number} jest liczba nieparzysta.";
                Console.WriteLine(even);
            }

            /* Zadanie 3 
            Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba
            jest dodatnia czy ujemna.
            Dane testowe : 14
            Rezultat w terminalu:
            14 jest liczbą dodatnią
                */
            Console.WriteLine("\nZadanie 3\n");


            /* Zadanie 4
            Napisz program w C#, który sprawdzi czy podany przez użytkownika rok
            jest rokiem przestępnym.
            Dane testowe : 2016
            Rezultat w terminalu :
            2016 jest rokiem przestępnym
                */
            Console.WriteLine("\nZadanie 4\n");

            Console.WriteLine("Podaj rok aby sprawdzic czy jest rokiem przestepnym");

            string year = Console.ReadLine();

            int chosenYear;

            Int32.TryParse(year, out chosenYear);

            if ((chosenYear % 4 == 0 && chosenYear % 100 == 0 && chosenYear % 400 == 0) || (chosenYear % 4 == 0 && chosenYear % 100 != 0))
            {
                Console.WriteLine($"Rok {chosenYear} jest rokiem przestepnym.");
            }
            else
            {
                Console.WriteLine($"Rok {chosenYear} nie jest rokiem przestepnym.");
            }

            /* Zadanie 5
            Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek
            uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora,
            prezydenta.
            Dane testowe : 21
            Rezultat w terminalu :
            Możesz zostać posłem
                */
            Console.WriteLine("\nZadanie 5\n");

            int age;

            Console.WriteLine("Podaj swoj wiek aby sprawdzic o jakie stanowisko mozesz sie ubiegac: ");

            choice = Console.ReadLine();
            Int32.TryParse(choice, out age);

            if (age < 21)
            {
                Console.WriteLine("Jestes zbyt mlody by ubiegac sie o jakiekolwiek stanowisko. ");
            }
            else if (age >= 21 && age < 30)
            {
                Console.WriteLine("Mozesz ubiegac sie o stanowisko posla i premiera. ");
            }
            else if (age >= 21 && age < 35)
            {
                Console.WriteLine("Mozesz ubiegac sie o stanowisko posla, premiera i senatora. ");
            }
            else if (age >= 35)
            {
                Console.WriteLine("Mozesz ubiegac sie o stanowisko posla, premiera, senatora i prezydenta. ");
            }
            else
            {
                Console.WriteLine("Niepoprawny format, sprobuj ponownie.");
            }


            /* Zadanie 6
            Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu
            wymyśloną kategorię wzrostu.
            Dane testowe : 140
            Rezultat w terminalu :
            Jesteś krasnoludem
                */
            Console.WriteLine("\nZadanie 6\n");

            int height;

            Console.WriteLine("Podaj swoj wzrost(cm): ");

            choice = Console.ReadLine();
            Int32.TryParse(choice, out height);

            if (height < 150)
            {
                Console.WriteLine("Jesteś krasnoludem.");
            }
            else if (height >= 150 && height < 170)
            {
                Console.WriteLine("Slodki maluszek.");
            }
            else if (height >= 170 && height < 190)
            {
                Console.WriteLine("Prawie jak facet.");
            }
            else if (height >= 190 && height < 205)
            {
                Console.WriteLine("No i to sie rozumie.");
            }
            else if (height >= 205)
            {
                Console.WriteLine("Gortat to rodzina?");
            }
            else
            {
                Console.WriteLine("Niepoprawny format, sprobuj ponownie.");
            }

            /* Zadanie 7 
            Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi,
            która jest największa
            Dane testowe:
            25
            63
            79
            Rezultat w terminalu :
            79 jest największa z podanych
                */
            Console.WriteLine("\nZadanie 7\n");

            int numberOne;
            int numberTwo;
            int numberThree;

            Console.WriteLine("Podaj trzy liczby aby sprawdzic ktora jest najwieksza: ");

            Console.WriteLine("Liczba pierwsza: ");

            choice = Console.ReadLine();
            Int32.TryParse(choice, out numberOne);

            Console.WriteLine("Liczba druga: ");

            choice = Console.ReadLine();
            Int32.TryParse(choice, out numberTwo);

            Console.WriteLine("Liczba trzecia: ");

            choice = Console.ReadLine();
            Int32.TryParse(choice, out numberThree);

            if ((numberOne > numberTwo && numberOne >= numberThree) || (numberOne >= numberTwo && numberOne > numberThree))
            {
                Console.WriteLine($"Najwieksza liczba jest liczba {numberOne}");
            }
            else if ((numberTwo > numberThree && numberTwo >= numberOne) || (numberTwo >= numberThree && numberTwo > numberOne))
            {
                Console.WriteLine($"Najwieksza liczba jest liczba {numberTwo}");
            }
            else if ((numberThree > numberOne && numberThree >= numberTwo) || (numberThree >= numberOne && numberThree > numberTwo))
            {
                Console.WriteLine($"Najwieksza liczba jest liczba {numberThree}");
            }
            else
            {
                Console.WriteLine("Niepoprawny format, sprobuj ponownie.");
            }


            /* Zadanie 8
            Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce
            na studiach wg. Następujących kryteriów:
            Wynik z Matury z matematyki powyżej 70
            Wynik z fizyki powyżej 55
            Wynik z chemii powyżej 45
            Łączny wynik z 3 przedmiotów powyżej 180
            Albo
            Wynik z matematyki i jednego przedmiotu powyżej 150
            Dane testowe:
            Matematyka 80
            Fizyka 71
            Chemia 0
            Rezultat w terminalu :
            Kandydat dopuszczony do rekrutacji
                */
            Console.WriteLine("\nZadanie 8\n");

            int mathGrade;
            int physicsGrade;
            int chemistryGrade;

            Console.WriteLine("Podaj uzyskane wyniki aby sprawdzic czy mozesz ubiegac sie o miejsce na studiach: ");
            Console.WriteLine("Matematyka: ");

            choice = Console.ReadLine();
            Int32.TryParse(choice, out mathGrade);

            Console.WriteLine("Fizyka: ");

            choice = Console.ReadLine();
            Int32.TryParse(choice, out physicsGrade);

            Console.WriteLine("Chemia: ");

            choice = Console.ReadLine();
            Int32.TryParse(choice, out chemistryGrade);

            if ((mathGrade > 70 && physicsGrade > 55 && chemistryGrade > 45)
                &&
                (mathGrade + physicsGrade + chemistryGrade > 180 || mathGrade + physicsGrade > 150 || mathGrade + chemistryGrade > 150))
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji.");
            }
            else
            {
                Console.WriteLine("Kandydat niedopuszczony do rekrutacji.");
            }

            /* Zadanie 9
            Napisz program, który odczyta temperaturę I zwróci nazwę jak w
            poniższych kryteriach
            Temp < 0 – cholernie piździ
            Temp 0 – 10 – zimno
            Temp 10 – 20 – chłodno
            Temp 20 – 30 – w sam raz
            Temp 30 – 40 – zaczyna być słabo, bo gorąco
            Temp >= 40 – a weź wyprowadzam się na Alaskę.
            Dane testowe : 41
            Rezultat w terminalu :
            a weź wyprowadzam się na Alaskę.
                        */
            Console.WriteLine("\nZadanie 9\n");

            double temp;

            Console.WriteLine("Podaj temperature ('C):");

            string temperature = Console.ReadLine();
            double.TryParse(temperature, out temp);

            if (temp < 0)
            {
                Console.WriteLine("Cholernie piździ.");
            }
            else if (temp >= 0 && temp < 10)
            {
                Console.WriteLine("Zimno.");
            }
            else if (temp >= 10 && temp < 20)
            {
                Console.WriteLine("Chłodno.");
            }
            else if (temp >= 20 && temp < 30)
            {
                Console.WriteLine("W sam raz.");
            }
            else if (temp >= 30 && temp < 40)
            {
                Console.WriteLine("Zaczyna być słabo, bo gorąco.");
            }
            else if (temp >= 40)
            {
                Console.WriteLine("a weź wyprowadzam się na Alaskę.");
            }
            else
            {
                Console.WriteLine("Niepoprawny format, sprobuj ponownie.");
            }

            /* Zadanie 10
            Napisz program, który sprawdzi, czy z 3 podanych długości można
            stworzyć trójkąt
            Dane testowe : 40 55 65
            Rezultat w terminalu :
            Można zbudować trójkąt      
                */
            Console.WriteLine("\nZadanie 10\n");

            double triangleA;
            double triangleB;
            double triangleC;

            Console.WriteLine("Podaj trzy dlugosci aby sprawdzic czy mozna z nich zbudowac trojkat: ");

            Console.WriteLine("Podaj pierwsza dlugosc: ");

            choice = Console.ReadLine();
            double.TryParse(choice, out triangleA);

            Console.WriteLine("Podaj druga dlugosc: ");

            choice = Console.ReadLine();
            double.TryParse(choice, out triangleB);

            Console.WriteLine("Podaj trzecia dlugosc: ");

            choice = Console.ReadLine();
            double.TryParse(choice, out triangleC);

            if ((triangleA + triangleB > triangleC) && (triangleA + triangleC > triangleB) && (triangleB + triangleC > triangleC))
            {
                Console.WriteLine("Z podanych dlugosci mozna zbudowac trojkat.");
            }
            else
            {
                Console.WriteLine("Z podanych dlugosci nie mozna zbudowac trojkata");
            }


            /* Zadanie 11
            Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:
            Ocena Opis
            6 Celujący
            5 Bardzo dobry
            4 Dobry
            3 Dostateczny
            2 Dopuszczający
            1 Niedostateczny
            Dane testowe : 3
            Rezultat w terminalu :
            Dostateczny
                */
            Console.WriteLine("\nZadanie 11\n");

            int grade;
            Console.WriteLine("Podaj stopien aby wyswietlic jego nazwe: ");

            choice = Console.ReadLine();
            Int32.TryParse(choice, out grade);

            switch (grade)
            {
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczający");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("Celujący");
                    break;
                default:
                    Console.WriteLine("Nie ma takiego stopnia.");
                    break;
            }

            /* Zadanie 12
            Napisz program, który pobierze numer dnia tygodnia i wyświetli jego
            nazwę
            Dane testowe : 4
            Rezultat w terminalu :
            Czwartek
                */
            Console.WriteLine("\nZadanie 12\n");

            int weekDay;

            Console.WriteLine("Podaj numer dnia tygodnia aby wyswietlic jego nazwe: ");

            choice = Console.ReadLine();
            Int32.TryParse(choice, out weekDay);

            switch (weekDay)
            {
                case 1:
                    Console.WriteLine("Poniedzialek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Sroda");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piatek");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("Jest tylko siedem dni w tygodniu...");
                    break;
            }



            /* Zadanie 13
            Napisz program, który będzie posiadał proste menu (wg. Wzoru poniżej) I
            będzie prostym kalkulatorem
            Podaj pierwszą liczbę:
            …
            Podaj drugą liczbę:
            …
            Podaj numer operacji do wykonania:
            1. Dodawanie
            2. Odejmowanie
            3. Mnożenie
            4. Dzielenie
            …
            Twój wynik to:
                */
            Console.WriteLine("\nZadanie 13\n");

            double firstNumber;
            double secondNumber;

            Console.WriteLine("Podaj liczby na ktorych chcesz wykonac dzialanie: ");
            Console.WriteLine("Podaj liczbe pierwsza: ");

            string firstChoice = Console.ReadLine();
            double.TryParse(firstChoice, out firstNumber);

            Console.WriteLine("Podaj liczbe druga: ");

            string secondChoice = Console.ReadLine();
            double.TryParse(secondChoice, out secondNumber);

            Console.WriteLine("Podaj numer operacji do wykonania:\r\n1. Dodawanie\r\n2. Odejmowanie\r\n3. Mnożenie\r\n4. Dzielenie");
            string mathOperation = Console.ReadLine();

            if (mathOperation == "1")
            {
                Console.WriteLine("Twoj wynik to: " + (firstNumber + secondNumber));
            }
            else if (mathOperation == "2")
            {
                Console.WriteLine("Twoj wynik to: " + (firstNumber - secondNumber));
            }
            else if (mathOperation == "3")
            {
                Console.WriteLine("Twoj wynik to: " + (firstNumber * secondNumber));
            }
            else if (mathOperation == "4")
            {
                Console.WriteLine("Twoj wynik to: " + (firstNumber / secondNumber));
            }
            else
            {
                Console.WriteLine("Wybrana opcja jest nieprawidlowa. Sprobuj ponownie.");
            }

            Console.WriteLine("The End :)");
        }
    }
}
