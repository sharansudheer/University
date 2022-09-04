using System;
namespace exp_4main
{
    class dele
    {
        public delegate void matrix(int[,] arr1, int[,] arr2, int n);
        public void sum(int[,] arr1, int[,] arr2, int n)
        {
            /* calculate the sum of the matrix */
            int i, j;
            int[,] crr1 = new int[50, 50];
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    crr1[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            Console.WriteLine("\nThe Addition of two matrix is : \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", crr1[i, j]);
                }
            }
            Console.Write("\n\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            dele d = new dele(); //instance creation
            int[,] arr1 = new int[50, 50];
            int[,] arr2 = new int[50, 50];

            int i, j, n;
            Console.Write("\n\naddition of two Matrices :\n");
            Console.Write("-----------------------------------------\n");
            Console.Write("Input the size of the square matrix (less than 5): ");
            n = Convert.ToInt32(Console.ReadLine());

            //Stored values into the array 
            Console.Write("Input elements in the first matrix :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("Input elements in the second matrix :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            d.sum(arr1, arr2, n);
            Console.ReadKey();
            
        }
    }
}

