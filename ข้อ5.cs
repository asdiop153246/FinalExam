using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input item size: ");
            int size = Convert.ToInt32(Console.In.ReadLine());
            string[] item = new string[size];
            string[] type = new string[size];

            for (int i = 0;i < size; i++)
            {
                Console.Write("Input Item name: ");
                item[i] = Console.ReadLine();

                Console.Write("Input type: ");
                type[i] = Console.ReadLine();

                Console.WriteLine();
            }
            for (int p = 0; ;p++)
            {
                Console.Write("Search mode : ");
                string command = Console.ReadLine();

                string exit = command;

                for (int k = 0; k < size; k++)
                {
                    if (type[k] == command)
                    {
                        exit = "1";
                    }

                }

                if (exit == command && exit != "showall")
                {
                    break;
                }


                if (command == "showall")
                {
                    for (int e = 0; e < size; e++)
                    {
                        Console.WriteLine(item[e]);
                        Console.WriteLine(type[e]);
                        Console.WriteLine();                        
                    }
                }

                for (int k = 0; k < size; k++)
                {
                    if (type[k] == command)
                    {
                        Console.WriteLine(item[k]);

                        
                    }

                }



            }

        }
    }
}
