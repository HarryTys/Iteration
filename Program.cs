using System;
using System.Text;

namespace C_Sharp_Strings
{
    class C_Sharp_Strings
    {
        static void TimesTables()
        {
            Console.WriteLine("please enter the number you wish to find the times tables for...");
            float number = float.Parse(Console.ReadLine());
            for (int i = 1; i < 13; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }

        static void factorial()
        {
            Console.WriteLine("Please enter the number you wish to know the factoial of...");
            double x = double.Parse(Console.ReadLine());
            double total = 0;
            double n = x;
            for (double i = n - 1; i > 0; i--)
            {
                n *= i;
            }
            Console.WriteLine("Factorial of !{0} = {1}\n", x, n);
            x--;
        }

        static void bottlesOnWall()
        {
            Console.WriteLine("how many bottles are on the wall?");
            int bottles = int.Parse(Console.ReadLine());
            for (int x = bottles;  x > 0; x--)
            {
                Console.WriteLine($"{bottles} green bottles hanging on the wall,​\n\n{bottles} green bottles hanging on the wall,​\n\nAnd if one green bottle should accidentally fall,​\n\nThere'll be {bottles-1} green bottles hanging on the wall.\n");
                bottles = bottles - 1;
            }
        }

        static void asciiArt()
        {
            Console.WriteLine("Type in a phrase of any sorts");
            string phrase = Console.ReadLine().ToUpper();
            string plusMinus = "";
            string finalPhrase = "";
            for (int x = 0; x < phrase.Length; x++)
            {
                plusMinus = plusMinus + "+-/";
                finalPhrase = finalPhrase + "|" + phrase[x] + "|";
            }
            Console.WriteLine(plusMinus + "\n" + finalPhrase + "\n" + plusMinus);
        }

        static void fizzBuzz()
        {
            Console.WriteLine("Enter a whole number...");
            int x = int.Parse(Console.ReadLine());
            for (int i = x; i > 0; i--)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"{i} fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine($"{i} fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"{i} buzz");
                }
            }
        }

        static void scrabble()
        {
            Console.WriteLine("Please enter a word...");
            string word = Console.ReadLine().ToLower();
            int n = 0;
            int total = 0;
            char[] point1 = { 'a', 'e', 'i', 'o', 'n', 'r', 't', 'l', 's', 'u' };
            char[] point2 = { 'd', 'g' };
            char[] point3 = { 'b', 'c', 'm', 'p' };
            char[] point4 = { 'f', 'h', 'v', 'w', 'y' };
            char[] point5 = { 'k' };
            char[] point8 = { 'j', 'x' };
            char[] point10 = { 'q', 'z' };
            for (int x = word.Length; x > 0; x--)
            {
                if (point1.Contains(word[n]))
                {
                    total = total + 1;
                }
                else if (point2.Contains(word[n]))
                {
                    total = total + 2;
                }
                else if (point3.Contains(word[n]))
                {
                    total = total + 3;
                }
                else if (point4.Contains(word[n]))
                {
                    total = total + 4;
                }
                else if (point5.Contains(word[n]))
                {
                    total = total + 5;
                }
                else if (point8.Contains(word[n]))
                {
                    total = total + 8;
                }
                else if (point10.Contains(word[n]))
                {
                    total = total + 10;
                }
                n++;
            }
            Console.WriteLine(total);
        }

        static void PasswordMaker()
        {
            Console.WriteLine("Enter a word and a password will be made out of it (try to make sure there are atleast 4 vowels)...");
            string passwordWord = Console.ReadLine().ToLower();
            string positionOfElements = "";
            List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            for (int i = 0; i < passwordWord.Length; i++)
            {
                if (vowels.Contains(passwordWord[i]))
                {
                    positionOfElements = positionOfElements + Convert.ToString(vowels.IndexOf(passwordWord[i]));
                    Console.WriteLine(positionOfElements);
                }
                else if (vowels.Contains(passwordWord[i]) == false)
                {   }
            }
        }
        static void OddParity()
        {
            Console.WriteLine("Please enter your sequence of bits...");
            int evenOrOdd = 0;
            string sequenceBits = Console.ReadLine();
            for (int x = 0; x < sequenceBits.Length; x++)
            {
                if (sequenceBits[x] == '1')
                {
                    evenOrOdd = evenOrOdd + 1;
                }
                else if (sequenceBits[x] == '0')
                { }
            }
            if ((evenOrOdd % 2) == 0)
            {
                Console.WriteLine($"Your sequence of bits adds up to equal {evenOrOdd} meaning your sequence is valid as it is an even number");
            }
            else
            {
                Console.WriteLine($"Your sequence of bits adds up to equal {evenOrOdd} meaning your sequence is invalid as it is an odd number");
            }
        }

        static void IsPrime()
        {
            Console.WriteLine("Please enter a number...");
            float primeOrNot = float.Parse(Console.ReadLine());
            if (primeOrNot > 1)
            {
                for (int x = 2; x < (int)Math.Ceiling(primeOrNot / 2); x++)
                {
                    if (((int)Math.Ceiling(primeOrNot / 2) % x) == 0)
                    {
                        Console.WriteLine("Your number " + primeOrNot + " is a prime number");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Your number " + primeOrNot + " is not a prime number");
                        break;
                    }
                }
            }
        }

        static void Main()
        {
            Console.WriteLine("Enter 1 for Timestables, enter 2 for factorials, enter 3 for Bottles on the wall, enter 4 for ascii art, enter 5 for fizzbuzz, enter 6 for scrabble, enter 7 for password creator, enter 8 for oddparity enter 9 for prime number, ");

            int Decision = int.Parse(Console.ReadLine());
            if (Decision == 1)
            {
                TimesTables();
                Console.ReadLine();
            }
            if (Decision == 2)
            {
                factorial();
                Console.ReadLine();
            }
            if (Decision == 3)
            {
                bottlesOnWall();
                Console.ReadLine();
            }
            if (Decision == 4)
            {
                asciiArt();
                Console.ReadLine();
            }
            if (Decision == 5)
            {
                fizzBuzz();
                Console.ReadLine();
            }
            if (Decision == 6)
            {
                scrabble();
                Console.ReadLine();
            }
            if (Decision == 7)
            {
                PasswordMaker();
                Console.ReadLine();
            }
            if (Decision == 8)
            {
                OddParity();
                Console.ReadLine();
            }
            if (Decision == 9)
            {
                IsPrime();
                Console.ReadLine();
            }
        }
    }
}
