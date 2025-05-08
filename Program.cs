// Display individual digits using recursion

using System;

class Program
{

    static void Digits(int n)
    {
            if (n < 10)
            {
                Console.WriteLine(n);
                return;
            }
             Digits(n / 10);
        Console.WriteLine(n % 10);

        }
        static void Main(string[] args)
        {
        int number = 1234;
            Console.WriteLine("The digits in the {number} are: ");
            Digits(number);

        }
    }

