using System;

namespace oopLaba2_4
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n=");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("m=");
            int m = int.Parse(Console.ReadLine());

            int[,] arr = new int[n,m];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int s = 0;
            for (int i = 0;i<arr.GetLength(0);i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]+ " \t ");
                }
                Console.WriteLine();
            }

      
            for (int i = 0; i < arr.GetLength(0); i++)
            {
               
                int min = arr[i, 0];
                for (int j = 1; j < arr.GetLength(1); j++)
                {
                   
                    if (arr[i, j] < min)
                    {
                       
                        min = arr[i,j];
                       
                    }
                    s += min;
                }
                Console.WriteLine("min= "+min);

               

            }
            Console.WriteLine(s);

        }

    }
}
