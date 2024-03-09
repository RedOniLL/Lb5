using System;

namespace Lb5.Task1.Task1._1
{
    public static class Class1
    {
        public static void Task()
        {
            Console.WriteLine("Even numbers in the range from 1 to 100:");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

