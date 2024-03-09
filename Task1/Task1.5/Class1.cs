using System;

namespace Lb5.Task1.Task1._5
{
    public static class Class1
    {

        public static void  Task()
        {
            Console.WriteLine("Fibonacci sequence:");

            for (int count = 0; count < 10; count++)
            {
                int a = 0, b = 1;
                Console.Write(a + " " + b + " ");

                for (int i = 2; i < 10; i++)
                {
                    int c = a + b;
                    Console.Write(c + " ");
                    a = b;
                    b = c;
                }

                Console.WriteLine();
            }
        }
    }
}
