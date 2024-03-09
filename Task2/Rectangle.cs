using System;


namespace Lb5.Task2
{
    public static class Rectangle
    {
        public static void Task()
        {
            int width = 7; 
            int height = 5; 

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
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
