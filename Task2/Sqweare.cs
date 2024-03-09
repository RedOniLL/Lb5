using System;

namespace Lb5.Task2
{
    public static class Sqweare
    {
        public static void Task()
        {
            int sideLength = 5; 
            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j < sideLength; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("*************");
            Console.WriteLine();
        }

    }
}
