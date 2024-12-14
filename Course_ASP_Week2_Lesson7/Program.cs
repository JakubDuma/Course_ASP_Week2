using System.Linq;
namespace Course_ASP_Week2_Lesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1. Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są one równe czy nie.  
              Dane testowe:
              a : 5
              b : 5
              Rezultat w terminalu : 5 i 5 są równe
            */
            int a, b;
            Console.WriteLine("Podaj liczbę a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę b: ");
            b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine($"{a} i {b} są równe");
            }
            else
            {
                Console.WriteLine($"{a} i {b} nie są równe");
            }

            /* 2. Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest parzysta czy nieparzysta.
              Dane testowe : 15
              Rezultat w terminalu : 15 jest liczbą nieparzystą
            */
            Console.WriteLine("Podaj liczbę: ");
            int c = int.Parse(Console.ReadLine());

            if (c % 2 == 0)
            {
                Console.WriteLine($"{c} jest liczbą parzystą");
            }
            else
            {
                Console.WriteLine($"{c} jest liczbą nieparzystą");
            }

            /* 3. Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest dodatnia czy ujemna.  
               Dane testowe : 14
               Rezultat w terminalu : 14 jest liczbą dodatnią
            */
            long d = 14;
            string result = (d > 0 ? $"{c} jest liczbą dodatnią" : $"{c} jest liczbą ujemną");
            Console.WriteLine(result);

            /* 4. Napisz program w C#, który sprawdzi czy podany przez użytkownika rok jest rokiem przestępnym.
                  Dane testowe : 2016
                  Rezultat w terminalu : 2016 jest rokiem przestępnym
            */
            Console.WriteLine("Podaj rok: ");
            int rok = int.Parse(Console.ReadLine());

            if ((rok % 4 == 0 && rok % 100 != 0) || (rok % 400 == 0))
            {
                Console.WriteLine($"{rok} jest rokiem przestępnym");
            }
            else
            {
                Console.WriteLine($"{rok} nie jest rokiem przestępnym");
            }

            /* 5. Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek uprawnia go 
                  do ubiegania się o stanowisko posła, premiera, sentarora, prezydenta.
                  Dane testowe : 21
                  Rezultat w terminalu : Możesz zostać posłem
            */
            Console.WriteLine("Podaj wiek: ");
            int wiek = int.Parse(Console.ReadLine());

            if (wiek >= 18)
                Console.WriteLine("Możesz zostać premierem");
            else if (wiek >= 21)
                Console.WriteLine("Możesz zostać posłem");
            else if (wiek >= 30)
                Console.WriteLine("Możesz zostać senatorem");
            else if (wiek >= 35)
                Console.WriteLine("Możesz zostać prezydentem");

            /* 6. Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu wymyśloną kategorię wzrostu.
                  Dane testowe : 140
                  Rezultat w terminalu : Jesteś krasnoludem
            */
            Console.WriteLine("Podaj wzrost w centymetrach: ");
 
            int wzrost = int.Parse(Console.ReadLine());
            {


                if (wzrost <= 160)
                {
                    Console.WriteLine("Jesteś krasnoludem");
                }
                else if (wzrost <= 180 && wzrost > 160)
                {
                    Console.WriteLine("Jesteś półelfem");
                }
                else if (wzrost <= 200 && wzrost > 180)
                {
                    Console.WriteLine("Jesteś elfem");
                }
                else if (wzrost > 200)
                {
                    Console.WriteLine("Jesteś potężny");
                }
            }

            /* 7. Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi, która jest największa
            Dane testowe:
            25
            63
            79
            Rezultat w terminalu : 79 jest największa z podanych
            */

            Console.WriteLine("Podaj pierwszą liczbę: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj trzecią liczbę: ");
            int z = int.Parse(Console.ReadLine());

            if (x >= y && x >= z) //Można również zastosować Math.Max
            {
                Console.WriteLine($"{x} jest największą z podanych liczb");
            }
            else if (y >= z && y >= x)
            {
                Console.WriteLine($"{y} jest największą z podanych liczb");
            }
            else if (z >= x && z >= y)
            {
                Console.WriteLine($"{z} jest największą z podanych liczb");
            }

            /* 8. Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce na studiach wg. Następujących kryteriów:

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
                Rezultat w terminalu : Kandydat dopuszczony do rekrutacji
            */
            Console.WriteLine("Podaj wynik z matematyki: ");
            int matematyka = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wynik z fizyki: ");
            int fizyka = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wynik z chemii: ");
            int chemia = int.Parse(Console.ReadLine());
            if(matematyka > 70 && fizyka > 55 && chemia > 45)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else if (matematyka + chemia > 150 || matematyka + fizyka > 150)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else
            {
                Console.WriteLine("Kandydat niedopuszczony do rekrutacji");
            }

            /* 9. Napisz program, który odczyta temperaturę I zwróci nazwę jak w poniższych kryteriach
            Temp < 0 – cholernie piździ
            Temp 0 – 10 – zimno
            Temp 10 – 20 – chłodno
            Temp 20 – 30 – w sam raz
            Temp 30 – 40 – zaczyna być słabo, bo gorąco
            Temp >= 40 – a weź wyprowadzam się na Alaskę.
            Dane testowe : 41
            Rezultat w terminalu : a weź wyprowadzam się na Alaskę.
            */

            Console.WriteLine("Podaj temperaturę: ");
            int temp = int.Parse(Console.ReadLine());
            if ((temp < 0))
            {
                Console.WriteLine("Cholernie pizdzi");
            }
            else if (temp > 0 && temp <= 10)
            {
                Console.WriteLine("Zimno");
            }
            else if (temp > 10 && temp <= 20)
            {
                Console.WriteLine("Chłodno");
            }
            else if (temp > 20 && temp <= 30)
            {
                Console.WriteLine("W sam raz");
            }
            else if (temp > 30 && temp <= 40)
            {
                Console.WriteLine("Zaczyna być słabo, bo gorąco");
            }
            else if (temp > 40)
            {
                Console.WriteLine("A weź wyprowadzam się na Alaskę.");
            }
            /* 10. Napisz program, który sprawdzi, czy z 3 podanych długości można stworzyć trójkąt

            Dane testowe : 40 55 65
            Rezultat w terminalu :
            Można zbudować trójkąt
            */
            Console.WriteLine("Podaj długość pierwszego boku trójkąta: ");
            double a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długość drugiego boku trójkąta: ");
            double a2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długość trzeciego boku trójkąta: ");
            double a3 = double.Parse(Console.ReadLine());
            if(a1 + a2 > a3 || a1 + a3 > a2 || a2 + a3 > a1)
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else
            {
                Console.WriteLine("Nie można zbudować trójkąta");
            }
            /* 11. Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:
            Ocena Opis
            6 Celujący
            5 Bardzo dobry
            4 Dobry
            3 Dostateczny
            2 Dopuszczający
            1 Niedostateczny
            */
            ocena:
            Console.WriteLine("Podaj ocenę: ");
            int mark = int.Parse(Console.ReadLine());
            switch (mark)
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
                    Console.WriteLine("Błędna ocena");
                    goto ocena;
            }
            /* 12. Napisz program, który pobierze numer dnia tygodnia i wyświetli jego nazwę
               Dane testowe : 4
               Rezultat w terminalu : Czwartek
            */
            dzien:
            Console.WriteLine("Podaj numer dnia tygodnia: ");
            int weekDay = int.Parse(Console.ReadLine());
            switch (mark)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("Błędny numer dnia tygodnia");
                    goto dzien;
            }
            /* 13. Napisz program, który będzie posiadał proste menu (wg. Wzoru poniżej) I będzie prostym kalkulatorem

                   Podaj pierwszą liczbę:
                   Podaj drugą liczbę:
                   Podaj numer operacji do wykonania:
                   1. Dodawanie
                   2. Odejmowanie
                   3. Mnożenie
                   4. Dzielenie
                   Twój wynik to:
            */
            Console.WriteLine("Podaj pierwszą liczbę: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            double n2 = double.Parse(Console.ReadLine());

        operation:
            Console.WriteLine("Podaj numer operacji do wykonania: \n1. Dodawanie \n2. Odejmowanie \n3. Mnożenie \n4. Dzielenie");
            string op = Console.ReadLine();
            double result1;
            
            switch (op)
            {
                case "1":
                    result1 = n1 + n2;
                    Console.WriteLine($"Wynik: {result1}");
                    break;
                case "2":
                    result1 = n1 - n2;
                    Console.WriteLine($"Wynik: {result1}");
                    break;
                case "3":
                    result1 = n1 * n2;
                    Console.WriteLine($"Wynik: {result1}");
                    break;
                case "4":
                    if (n2 == 0)
                    {
                        Console.WriteLine("Nie można dzielić przez 0");
                    }
                    else
                    {
                        result1 = n1 / n2;
                        Console.WriteLine($"Wynik: {result1}");
                    }
                    break;
                default:
                    Console.WriteLine("Błędna operacja, wybierz poprawną");
                    goto operation;
            }
        }
    }
}
