namespace Module_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Modul 2 Lekcja 4 zadania

            /*Zadanie 1.
            Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy. Dane
            które chcesz przetrzymywać to:
            a.Imię,
            b.Nazwisko
            c.Wiek
            d.Płeć(‘m’ albo ‘k’)
            e.PESEL
            f.Numer pracownika(np. 2509324094)
            Zadeklaruj zmienne odpowiednich typów, które mogą przetrzymywać te informacje
            */
            Console.WriteLine("Zadanie 1:\n");
            Console.WriteLine("Prosze podaj swoje dane: ");

            Console.WriteLine("Imie: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Nazwisko: ");
            string secondName = Console.ReadLine();

            int age;
            Console.WriteLine("Wiek: ");
            string choice = Console.ReadLine();
            Int32.TryParse(choice, out age);

            char sex;
            Console.WriteLine("Plec \"m\" lub \"k\": ");
            choice = Console.ReadLine();
            char.TryParse(choice, out sex);

            double idNumber;
            Console.WriteLine("Pesel: ");
            choice = Console.ReadLine();
            double.TryParse(choice, out idNumber);

            long employeeNo;
            Console.WriteLine("Number pracownika: ");
            choice = Console.ReadLine();
            long.TryParse(choice, out employeeNo);

            Console.WriteLine($"Wprowadziles dane: \nImie:  {firstName}, \nNazwisko: {secondName}, \nWiek: {age}, \nPlec: {sex}, \nPesel: {idNumber}, \nNumber pracownika: {employeeNo}.");


            /*Zadanie 2
            Napisz program, w którym stworzysz 3 zmienne z jedną literą, a następnie wypiszesz je w
            odwrotnej kolejności niż zostały zadeklarowane.
            */
            Console.WriteLine("\nZadanie 2:\n");
            int a = 1;
            int b = 2;
            int c = 3;

            Console.WriteLine($"c = {c}\nb = {b}\na = {a}");

            /*Zadanie 3
            Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość
            przekątnej. (Aby, obliczyć kwadrat liczby użyj metody Math.Pow())
            */
            Console.WriteLine("\nZadanie 3:\n");

            double width = 0;
            double length = 0;
            double diagonal;
            Console.WriteLine("Podaj dlugosci do wyliczenia dlugosci przekatnej prostokata:");
            Console.WriteLine("Szerokosc: ");
            choice = Console.ReadLine();
            double.TryParse(choice, out width);

            Console.WriteLine("Dlugosc: ");
            choice = Console.ReadLine();
            double.TryParse(choice, out length);

            diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(length, 2));
            Console.WriteLine($"Dlugosc przekatnej wynosi {diagonal}.");

            /*Zadanie 4
            Napisz program w którym stworzysz 2 zmienne liczbowe, oraz jedną tekstową, a następnie
            przypiszesz im następujące wartości:
            a. 10
            b. Szkoła Dotneta
            c. 12,5
            Pamiętaj o użyciu poprawnych typów danych.
            */
            Console.WriteLine("\nZadanie 4:\n");
            int a4;
            string string4;
            double b4;

            a4 = 10;
            string4 = "Szkola Dotneta";
            b4 = 12.5;

            Console.WriteLine($"int = {a4},\nstring: {string4},\ndouble = {b4}");

            /*Zadanie 5
            Napisz program w którym poprosisz użytkownika o jego dane personalne tj. Imię, nazwisko,
            numer telefonu, adres email, wzrost, waga (np. 85,7), itp (postaraj się wymyślić jak najwięcej)
            i spróbuj przekonwertować odpowiedź do odpowiedniego typu danych używając metody:
            typDanych.Parse(odpowiedźOdUżytkownika). 

            Chyba juz to zrobilem w zadaniu pierwszym ;)
            */
            Console.WriteLine("\nZadanie 5:\n");

            Console.WriteLine("Prosze podaj swoje dane: ");

            Console.WriteLine("Imie: ");
            string name = Console.ReadLine();

            Console.WriteLine("Nazwisko: ");
            string lastName = Console.ReadLine();

            long phoneNumber;
            Console.WriteLine("Numer telefonu: ");
            choice = Console.ReadLine();
            long.TryParse(choice, out phoneNumber);

            double heigth5;
            Console.WriteLine("Wzrost: ");
            choice = Console.ReadLine();
            double.TryParse(choice, out heigth5);

            double weight;
            Console.WriteLine("Waga: ");
            choice = Console.ReadLine();
            double.TryParse(choice, out weight);

            int age5;
            Console.WriteLine("Wiek: ");
            choice = Console.ReadLine();
            int.TryParse(choice, out age5);

            Console.WriteLine($"Twoje dane:\nImie i Nazwisko: {name} {lastName}\nNumer telefonu: {phoneNumber}\nWrost: {heigth5}\nWaga: {weight}\nWiek: {age5}");


            Console.WriteLine("To wszystko!!!");
        }
    }
}
