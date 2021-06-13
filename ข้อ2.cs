using System;

namespace FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Newvalue();
        }
        static void Newvalue()
        {
            Console.WriteLine("Input the amount of number: ");
            int size = Convert.ToInt32(Console.In.ReadLine());
            int[] Value = new int[size];

            for (int i = 0; i < Value.Length; i++)
            {

                Value[i] = int.Parse(Console.ReadLine());

                if (i == Value.Length)
                {
                    
                    break;                   
                }
                
               
            }
            Array.Sort(Value);
            Console.Write("Tar's Sort ");            
            foreach (int u in Value)
            {

                
                Console.Write(u + " ");
                
            }
            Console.WriteLine();
            Console.Write("Rocky's Sort ");
            foreach (int u in Value)
            {


                Console.Write(u + " ");

            }
            Console.WriteLine();
            Console.Write("Peter's Sort ");
            foreach (int u in Value)
            {


                Console.Write(u + " ");

            }
            Console.WriteLine();
            Console.Write("Fluke's Sort ");
            foreach (int u in Value)
            {


                Console.Write(u + " ");

            }

        }
        
    }
}

