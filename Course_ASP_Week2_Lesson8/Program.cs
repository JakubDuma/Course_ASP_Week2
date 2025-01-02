using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Course_ASP_Week2_Lesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100
            int counter = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i < 2)
                {
                    continue;
                }
                else if (i == 2)
                {
                    counter++;
                }
                else if (i % 2 == 0)
                {
                    continue;
                }
                else 
                {
                    bool isPrime = true;
                    int boundary = (int)Math.Sqrt(i);
                    for (int j = 3; j <= boundary; j += 2)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine($"W zakresie 0-100 jest {counter} liczb pierwszych.");

            // 2. Napisz program, w którym za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z zakresu 0 – 1000.
            int min = 0;
            int max = 1000;
            List<int> numbers = new List<int>();
            do
            {
                if( min % 2 == 0 )
                {
                    numbers.Add(min);
                    min += 2;
                }
                else
                {
                    min++;
                }
            }
            while (min >= max);
            /*foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            */

            //3. Napisz program, który zaimplenetuje ciąg Fibonacciego i wyświetli go na ekranie

            Console.Write("Podaj liczbę elementów ciągu Fibonacciego do wydrukowania: ");
            int liczbaElementow = int.Parse(Console.ReadLine());

            int[] fibbNumbers = new int[liczbaElementow];
            
            if(liczbaElementow > 0)
            {
                fibbNumbers[0] = 0;
                Console.WriteLine($"1: {fibbNumbers[0]}");
            }
            if (liczbaElementow > 1)
            {
                fibbNumbers[1] = 1;
                Console.WriteLine($"2: {fibbNumbers[1]}");
            }
            for (int i = 2; i < liczbaElementow; i++)
            {
                fibbNumbers[i] = fibbNumbers[i - 1] + fibbNumbers[i - 2];
                Console.WriteLine($"{i}: {fibbNumbers[i]}");
            }

            /*4. Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej liczby w formie jak poniżej:
            1
            2 3
            4 5 6
            7 8 9 10
            */

            Console.WriteLine("Podaj liczbe całkowita dla piramidy liczb: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                int currentNumber = 1;
                for (int i = 1; currentNumber <= n; i++)
                {
                    for (int j = 1; j <= i && currentNumber <= n; j++) 
                    {
                        Console.Write(currentNumber + " ");
                        currentNumber++;
                    }
                    Console.WriteLine();
                }
            }

            //5. Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.
            int z3;

            for(int z = 1; z <= 20; z++)
            {
                z3 = (int)Math.Pow(z, 3);
                Console.WriteLine(z3);
            }

            //6. Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru:  1 + ½ +1 / 3 + ¼ itd.
            int sum;
            for(int i = 0; i <= 20; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                else
                {
                    sum =+ 1/i;
                }
            }

            //7. Napisz program, który dla liczby zadanej przez użytkownika narysuje diament o krótszej
            //   przekątnej o długości wprowadzonej przez użytkownika i wg wzoru:

            Console.WriteLine("Podaj przekątną diamentu: ");
            int diagonal = int.Parse(Console.ReadLine());
            char space = ' ';
            if (diagonal % 2 == 0)
            {
                for (int i = 2; i <= diagonal; i += 2)
                {

                    if (i == diagonal)
                    {
                        for (int j = diagonal; j >= 1; j -= 2)
                        {
                            Console.Write(string.Concat(Enumerable.Repeat(" ", (diagonal - j) / 2)));
                            Console.Write(string.Concat(Enumerable.Repeat("*", j)));
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.Write(string.Concat(Enumerable.Repeat(" ", (diagonal - i) / 2)));
                        Console.Write(string.Concat(Enumerable.Repeat("*", i)));
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 1; i <= diagonal; i+=2)
                {
                    
                    if (i == diagonal)
                    {
                        for (int j = diagonal; j >= 1; j-=2)
                        {
                            Console.Write(string.Concat(Enumerable.Repeat(" ", (diagonal - j) / 2)));
                            Console.Write(string.Concat(Enumerable.Repeat("*", j)));
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.Write(string.Concat(Enumerable.Repeat(" ", (diagonal - i) / 2)));
                        Console.Write(string.Concat(Enumerable.Repeat("*", i)));
                    }
                    Console.WriteLine();
                }
            }

            /*8.  Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków. Np.
                  Testowe dane:
                  Abcdefg
                  Rezultat
                  Gfedcba
            */
            Console.WriteLine("Wprowadź ciąg znaków: ");
            string chars = Console.ReadLine();
            StringBuilder chars2 = new StringBuilder();
            
            
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                chars2.Append(chars[i]);
            }
            Console.WriteLine(chars2.ToString());

            //9. Napisz program, który zamieni liczbę dziesiętną na liczbę binarną

            Console.WriteLine("Podaj liczbę dziesiętną: ");
            int decNum = int.Parse(Console.ReadLine());
            List<int> binNum = new List<int>();
            
            while (decNum != 0)
            {
                if (decNum % 2 == 0)
                {
                    decNum = decNum / 2;
                    binNum.Add(0);
                }
                else if (decNum % 2 == 1)
                {
                    decNum = (decNum - 1) / 2;
                    binNum.Add(1);
                }
            }
            Console.WriteLine("Liczba binarna to:");
            for (int i = binNum.Count()-1; i >= 0; i--)
            { 
                Console.Write(binNum[i]);
            }

            //10. Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb.

            Console.WriteLine("Podaj pierwszą liczbę: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            int num2 = int.Parse(Console.ReadLine());
            int num3 = num1>num2 ? num2:num1;
            int multiplicity = 1;
            for (int i = 1; i <= num3; i++)
            {
                if(num1 % i == 0 && num2 % i == 0)
                {
                    multiplicity = i;
                }
            }
            Console.WriteLine($"Najmniejsza wspólną wielokrotność obu liczb wynosi: {multiplicity}");
        }
    }
}
