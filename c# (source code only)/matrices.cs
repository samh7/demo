using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Text;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5,5];
            Console.WriteLine("Enter values for column a1: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int input1 = Convert.ToInt32(Console.ReadLine());
                matrix[0, i] = input1;
            }

            Console.WriteLine("Enter values for column b1: ");
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                int input2 = Convert.ToInt32(Console.ReadLine());
                matrix[1, j] = input2;
            }

            Console.WriteLine("\nMatrix A");
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                Console.Write(matrix[0, i] + "  ");
                Console.WriteLine(matrix[1, i]);
            }

            int[,] matrix1 = new int[5, 5];
            Console.WriteLine("Enter values for column a2: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int input1 = Convert.ToInt32(Console.ReadLine());
                matrix1[0, i] = input1;
            }

            Console.WriteLine("Enter values for column b2: ");
            for (int j = 0; j < matrix1.GetLength(0); j++)
            {
                int input2 = Convert.ToInt32(Console.ReadLine());
                matrix1[1, j] = input2;
            }

            Console.WriteLine("\nMatrix B");
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                Console.Write(matrix1[0, i] + "  ");
                Console.WriteLine(matrix1[1, i]);
            }
            Console.WriteLine("\nSum of the Matrices");
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                Console.Write(matrix1[0, i] - matrix[0, i] + "  ");
                Console.WriteLine(matrix1[1, i] - matrix[1,i]);
            }

        }
    }
}