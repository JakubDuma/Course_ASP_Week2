namespace Course_ASP_Week2_Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1. Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy. Dane które chcesz przetrzymywać to:
            a. Imię,
            b. Nazwisko
            c. Wiek
            d. Płeć (‘m’ albo ‘k’)
            e. PESEL
            f. Numer pracownika (np. 2509324094)
            Zadeklaruj zmienne odpowiednich typów, które mogą przetrzymywać te informacje
            */
            string imie, nazwisko, pesel, numerPracownika;
            int wiek;
            char plec;

            Console.WriteLine("Podaj imie: ");
            imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko: ");
            nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj wiek: ");
            wiek = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj plec (‘m’ albo ‘k’): ");
            plec = Char.Parse(Console.ReadLine());
            Console.WriteLine("Podaj pesel: ");
            pesel = Console.ReadLine();
            Console.WriteLine("Podaj numer pracownika: ");
            numerPracownika = Console.ReadLine();

            /* 2. Napisz program, w którym stworzysz 3 zmienne z jedną literą, a następnie wypiszesz je w
                  odwrotnej kolejności niż zostały zadeklarowane.
             
            */
            char a1, a2, a3;
            Console.WriteLine("Podaj pierwszą literę: ");
            a1 = Char.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą literę: ");
            a2 = Char.Parse(Console.ReadLine());
            Console.WriteLine("Podaj trzecią literę: ");
            a3 = Char.Parse(Console.ReadLine());

            Console.WriteLine($"a3: {a3}, a2: {a2}, a1: {a1}");

            /* 3. Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość przekątnej.
                  (Aby, obliczyć kwadrat liczby użyj metody Math.Pow())        
            */
            double a, b, c;
            Console.WriteLine("Podaj szerokosc prostokąta: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj dlugosc prostokąta: ");
            b = double.Parse(Console.ReadLine());
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine($"Dlugosc przekatnej to: {c}");

            /* 4. Napisz program w którym stworzysz 2 zmienne liczbowe, oraz jedną tekstową, a następnie
                  przypiszesz im następujące wartości:
                  a. 10
                  b. Szkoła Dotneta
                  c. 12,5
            */
            int x = 10;
            string y = "Szkoła Dotneta";
            float z = 12.5f;

            /* 5. Napisz program w którym poprosisz użytkownika o jego dane personalne tj. Imię, nazwisko,
                  numer telefonu, adres email, wzrost, waga (np. 85,7), itp (postaraj się wymyślić jak najwięcej)
                  i spróbuj przekonwertować odpowiedź do odpowiedniego typu danych używając metody:
                  typDanych.Parse(odpowiedźOdUżytkownika).
            */
            Console.WriteLine("Podaj imie: ");
            string imie1 = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko: ");
            string nazwisko1 = Console.ReadLine();
            Console.WriteLine("Podaj numer telefonu: ");
            string numerTelefonu = Console.ReadLine();
            Console.WriteLine("Podaj adres email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Podaj wzrost: ");
            int wzrost = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wagę: ");
            double waga = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj płeć: ");
            string plec1 = Console.ReadLine();

        }
    }
}
