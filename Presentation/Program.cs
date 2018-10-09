using AbstractFactory;
using BuilderPattern;
using FactoryMethod;
using Prototype;
using Singleton;
using System;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Display();
        }

        private static void Display()
        {
            int choice = 0;
            Console.WriteLine(@"-------------- Select pattern you want to run --------------");
            Console.Write(@"1. AbstractFactory");
            Console.Write("\t\t\t\t4. Prototype\n");
            Console.Write(@"2. BuilderPattern");
            Console.Write("\t\t\t\t5. Singleton\n");
            Console.Write(@"3. FactoryMethod");
            Console.Write("\t\t\t\t6. Quit\n");
            Console.WriteLine(@"----------------------- End of program ---------------------");
            Console.Write(@"Please, type your choice: ");
            choice = int.Parse(Console.ReadLine());
            if (choice > 0)
                RunMyChoice(choice);
            else
                Display();
        }

        private static void RunMyChoice(int choice)
        {
            switch (choice)
            {
                case (int)Choice.AbstractFactory:
                    Console.WriteLine();
                    AbstractFactory.Program.Main();
                    Console.WriteLine();
                    Display();
                    break;
                case (int)Choice.BuilderPattern:
                    Console.WriteLine();
                    BuilderPattern.Program.Main();
                    Console.WriteLine();
                    Display();
                    break;
                case (int)Choice.FactoryMethod:
                    Console.WriteLine();
                    FactoryMethod.Program.Main();
                    Console.WriteLine();
                    Display();
                    break;
                case (int)Choice.Prototype:
                    Console.WriteLine();
                    Prototype.Program.Main();
                    Console.WriteLine();
                    Display();
                    break;
                case (int)Choice.Singleton:
                    Console.WriteLine();
                    Singleton.Program.Main();
                    Console.WriteLine();
                    Display();
                    break;
                case (int)Choice.Quit:

                    break;
                default:
                    Display();
                    break;
            }
        }
    }

    enum Choice : int
    {
        AbstractFactory = 1,
        BuilderPattern = 2,
        FactoryMethod = 3,
        Prototype = 4,
        Singleton = 5,
        Quit = 6
    }
}
