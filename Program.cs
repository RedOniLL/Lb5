
using MyTask11 =  Lb5.Task1.Task1._1;
using MyTask12 =  Lb5.Task1.Task1._2;
using MyTask13 =  Lb5.Task1.Task1._3;
using MyTask14 =  Lb5.Task1.Task1._4;
using MyTask15 =  Lb5.Task1.Task1._5;
using MyTask2 = Lb5.Task2;
using MyTask3 = Lb5.Task3;
using MyTask4 = Lb5.Task4;
namespace Lb5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a number from 1 to 4:");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 4.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        MyTask11.Class1.Task();
                        MyTask12.Class1.Task();
                        MyTask13.Class1.Task();
                        MyTask14.Class1.Task();
                        MyTask15.Class1.Task();
                        break;
                    case 2:
                        MyTask2.Rectangle.Task();
                        MyTask2.Sqweare.Task();
                        MyTask2.Treangle.Task();
                        break;
                    case 3:
                        MyTask3.Class1.Task();
                        break;
                    case 4:
                       MyTask4.Class1.Task();
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter a number from 1 to 4.");
                        break;
                }
            }
        }
    }
}
