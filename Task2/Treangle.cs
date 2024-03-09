using System;

namespace Lb5.Task2
{
    public static class Treangle
    {

        public static void Task()
        {
            int height = 5; 
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
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
