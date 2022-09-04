//Sic Mundus Creatus Est
using System;
namespace exp_4main
{
    class dele
    {
        public delegate void matrix(int[,] arr1, int[,] arr2, int n);
        public void sum(int[,] arr1, int[,] arr2, int n)
        {
            /* calculate the Sum of the matrix */
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
            Console.Write("\n");
        }
        public void sub(int[,] arr1, int[,] arr2, int n)
        {
            /* calculate the Difference of the matrix */
            int i, j;
            int[,] crr1 = new int[50, 50];
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    crr1[i, j] = arr1[i, j] - arr2[i, j];
                }
            }
            Console.WriteLine("\nThe Difference of two matrix is : \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", crr1[i, j]);
                }
            }
            Console.Write("\n");
        }
        public void mul(int[,] arr1, int[,] arr2, int n)
        {
            /* calculate the Product of the matrix */
            //"Product is undefined. n columns of first matrix must equal to n rows of second matrix"
            int i, j, k;
            int[,] crr1 = new int[50, 50];
            // looping through matrix 1 rows 
            for (i = 0; i < n; i++)
            {
                // for each matrix 1 row, loop through matrix 2 columns
                for (j = 0; j < n; j++)
                {
                    // loop through matrix 1 columns to calculate the dot product
                    for (k = 0; k < n; k++)
                    {
                        crr1[i, j] += arr1[i, k] * arr2[k, j];
                    }
                }
            }
            Console.WriteLine("\nThe Product of two matrix is : \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", crr1[i, j]);
                }
            }
            Console.Write("\n");
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
            d.sub(arr1, arr2, n);
            d.mul(arr1, arr2, n);

            Console.ReadKey();
            
        }
    }
}




/*
 
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2) {  
      // cahing matrix lengths for better performance  
      var matrix1Rows = matrix1.GetLength(0);  
      var matrix1Cols = matrix1.GetLength(1);  
      var matrix2Rows = matrix2.GetLength(0);  
      var matrix2Cols = matrix2.GetLength(1);  
      
      // checking if product is defined  
      if (matrix1Cols != matrix2Rows)  
        throw new InvalidOperationException  
          ("Product is undefined. n columns of first matrix must equal to n rows of second matrix");  
      
      // creating the final product matrix  
      double[,] product = new double[matrix1Rows, matrix2Cols];  
      
      // looping through matrix 1 rows  
      for (int matrix1_row = 0; matrix1_row < matrix1Rows; matrix1_row++) {  
        // for each matrix 1 row, loop through matrix 2 columns  
        for (int matrix2_col = 0; matrix2_col < matrix2Cols; matrix2_col++) {  
          // loop through matrix 1 columns to calculate the dot product  
          for (int matrix1_col = 0; matrix1_col < matrix1Cols; matrix1_col++) {  
            product[matrix1_row, matrix2_col] +=   
              matrix1[matrix1_row, matrix1_col] *   
              matrix2[matrix1_col, matrix2_col];  
          }  
        }  
      }  
      
      return product;  
    }  
https://www.c-sharpcorner.com/article/matrix-multiplication-in-c-sharp-applying-transformations-to-images/
*/
