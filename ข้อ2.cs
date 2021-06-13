using System;

namespace Final_EXAM
{
    class Program
    {
        static void Main(string[] args)
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
            int[] newValue = new int[Value.Length];
            for (int x = 0; x < Value.Length; x++)
            {
                newValue[x] = Value[x];
                newValue[x] = Math.Abs(newValue[x]);
                
                
            }
            



            Array.Sort(Value);
            Console.Write("Tar's Sort ");
            foreach (int u in Value)
            {


                Console.Write(u + " ");

            }
            Console.WriteLine();

            Array.Reverse(Value);
            Console.Write("Rocky's Sort ");
            foreach (int u in Value)
            {


                Console.Write(u + " ");

            }

            Array.Sort(newValue);
            Console.WriteLine();
            Console.Write("Peter's Sort ");
            foreach (int u in newValue)
            {


                Console.Write(u + " ");

            }
            Array.Reverse(newValue);
            Console.WriteLine();
            Console.Write("Fluke's Sort ");
            foreach (int u in newValue)
            {


                Console.Write(u + " ");

            }
        }
    }
}
