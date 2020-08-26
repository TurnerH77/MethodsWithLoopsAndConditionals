using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //NumsBetween1k();
            //NumsOf3();
            //AreTheyEqual(1,1);
            //IsItEvenOrOdd(3);
            //IsItNegativeOrPositive(-1234);
            //CanYouVote(22);
            //Range();
            //MultiplicationTable(4);

            int userNumber = Convert.ToInt32(Console.ReadLine());
            int[] randomNumbers = RandomArray(userNumber);

            foreach(var number in randomNumbers)
            {
                Console.WriteLine(number);
            }
        }

        public static void NumsBetween1k()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        public static void NumsOf3()
        {
            for (int j = 3; j <= 999; j+=3)
            {
                Console.WriteLine(j);
            }
        }
        public  static void AreTheyEqual(int x, int y)
        {
            bool equal;
            if(x == y)
            {
                equal = true;
            }
            else
            {
                equal = false;
            }

            if(equal == true)
            {
                Console.WriteLine($"{x} is equal to {y}.");
            }
            else
            {
                Console.WriteLine($"{x} is not equal to {y}.");
            }
        }
        public static void IsItEvenOrOdd(int x)
        {
            bool isEven = false;
            if(x % 2 != 0)
            {
                isEven = false;
            }
            else
            {
                isEven = true;
            }
            if(isEven == false)
            {
                Console.WriteLine($"{x} is odd");
            }
            else if(isEven == true)
            {
                Console.WriteLine($"{x} is even");
            }
        }
        public static void IsItNegativeOrPositive(int x)
        {
            if(x < 0)
            {
                Console.WriteLine($"{x} is a negative integer.");
            }
            else if(x >=0)
            {
                Console.WriteLine($"{x} is a positive integer.");
            }
        }
        public static void CanYouVote(int candidateAge)
        {
            if (candidateAge >= 18)
            {
                Console.WriteLine("You Can Vote!");
            }
            else
            {
                Console.WriteLine("I'm sorry, but you cannot vote.");
            }
        }

        //HEATIN UP -----------------------------------------------------------------------------------------------------------

        public static void Range()
        {
            Console.WriteLine("Please enter an integer to find out if it is within range:");
            int userInt = Convert.ToInt32(Console.ReadLine());

            if (userInt >= 10 && userInt <= -10)
            {
                Console.WriteLine($"{userInt} is within the range.");
            }
            else
            { 
                Console.WriteLine($"{userInt} is not within the range."); 
            }
        }

        public static void MultiplicationTable(int x)
        {
            for(int i = 1; i <= 12; i++)
            {
                Console.WriteLine((x * i));
            }
        }

        public static int[] RandomArray(int userNumber)
        {
            //userNumber = Convert.ToInt32(Console.ReadLine());
            int[] randos = new int[userNumber];

            Random rand = new Random();

            for(int i = 0; i < randos.Length; i++)
            {
                randos[i] = rand.Next(500);
            }

            return randos;
        }
    }
}
