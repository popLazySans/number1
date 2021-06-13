using System;

namespace Last1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[,] table = new int[3,3];
            for(int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write(table[i,j]+" ");
                }
                Console.WriteLine("");
            }
            int numB = int.Parse(Console.ReadLine());
            bool checkB = true;
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    if (table[i,j] == 0)
                    {
                        table[i, j] = numB;
                        for (int k = 0; k < table.GetLength(0); k++) 
                        {
                            for(int s = 0;s<table.GetLength(1);s++)
                            if ((table[i, j] == table[i,s]&&j!=s)||(table[i,j]==table[k,j]&&i!=k))
                            {
                                    checkB = false;
                            }
                        }
                }
            }
                
            }
            if(checkB == true)
            {
                for (int i = 0; i < table.GetLength(0); i++)
                {
                    for (int j = 0; j < table.GetLength(1); j++)
                    {
                        Console.Write(table[i, j] + " ");
                    }
                    Console.WriteLine("");
                }
            }
            else if (checkB == false)
            {
                Console.WriteLine("The number is available");
            }







        }
    }
}
