using System;

namespace Lb5.Task1.Task1._4
{
    public static class Class1
    {
        public static void Task()
        {
            Console.WriteLine("Prime numbers in the range from 1 to 100:");

            for (int number = 2; number <= 100; number++)
            {
                bool isPrime = true;

                for (int i = 2; i * i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
