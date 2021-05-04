using System;
using System.Collections.Generic;
using System.Text;


namespace ByCSharp.Input_Processing
{
    class TakeUserInput
    {
        public static int[,] Input2dArray()
        {
            Console.Write("Enter the Number of Rows : ");
            int Rows = int.Parse(Console.ReadLine());
            Console.Write("Enter the Number of Columns : ");
            int Columns = int.Parse(Console.ReadLine());
            //Creating a 1d Array 
            Console.WriteLine("Enter the 1D Array Elements : ");
            int[] oneDimensionalArray = new int[Rows * Columns];
            for (int i = 0; i < oneDimensionalArray.Length; i++)
            {
                oneDimensionalArray[i] = int.Parse(Console.ReadLine());
            }

            //Creating 2d Array
            int index = 0;
            int[,] twoDimensionalArray = new int[Rows, Columns];

            for (int x = 0; x < Rows; x++)
            {
                for (int y = 0; y < Columns; y++)
                {
                    twoDimensionalArray[x, y] = oneDimensionalArray[index];
                    index++;
                }
            }

            //Console.WriteLine("2D Array Elements : ");
            //foreach (int item in twoDimensionalArray)
            //{
            //    Console.Write(item + " ");
            //}

            return twoDimensionalArray;
        }
    }
}
