using System;

namespace Lab_3_Decision_Making
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyToCheck = "Y";
            ConsoleKeyInfo cki;

            do
            {
                Console.WriteLine();
                Main2(args);
                Console.Write("Continue? (y/n)");
                cki = Console.ReadKey();
            } while (keyToCheck.Equals(cki.Key.ToString()));

            Console.Write("\nBye!");
        }

        static void Main2(string[] args)
        {
            Console.Write("\nPlease enter your name: ");
            string UserName = Console.ReadLine();

            int UserNumber = 0;
            string StringNumber;

            while (UserNumber < 1 || UserNumber > 100 )
            {
                Console.Write($"{UserName}, please enter a number between 1 and 100: ");
                StringNumber = Console.ReadLine();
                try
                {
                    UserNumber = int.Parse(StringNumber);
                } catch (Exception anyEx)
                {
                    //UserNumber=0 so we go again
                    Console.WriteLine("Oh, you are making my head hurt :(");
                    Console.WriteLine($"{anyEx}");
                }
            }

            bool isEven = (UserNumber % 2 == 0);
            //bool isOdd = !isEven;
            bool isLessThan25 = (UserNumber < 25);
            bool isGreaterThan60 = (UserNumber > 60);

            if (isEven)
            {
                if (isLessThan25)
                {
                    Console.WriteLine("Output: Even and less than 25.");
                }
                else if (!isGreaterThan60)
                {
                    Console.WriteLine("Output: Even.");
                }
                else    // UserNumber is between 25-60
                {
                    Console.WriteLine($"Output: {UserNumber} Even.");
                }
            }
            else
            { // isOdd
                Console.WriteLine($"Output: {UserNumber} Odd.");
            }
        }
    }
}
