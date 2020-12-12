/*
 * This chunk of code computes the determinant of a
 * matrix defined by a 4-dimensional array configuration:
 * int[,,,] = new[3,4,2,3]
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeterminantOfMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Default Array
             int[,,,] arr;
             arr = new int[1, 1, 4, 4]
             {
                 {{{1,2,3,4},{5,6,7,8},{2,4,6,8},{1,3,5,7}}}
             };*/

            Console.WriteLine("Calculate the Determinant and Square of a 4 by 4 Square-Matrix");
            Console.WriteLine("Here's a sample of the matrix:\n");
            string[] sampleMatrix = new string[]
            {   "a1", "b1", "c1", "d1",
                "a2", "b2", "c2", "d2",
                "a3", "b3", "c3", "d3",
                "a4", "b4", "c4", "d4"
            };

            DisplaySampleMatrix(sampleMatrix);
            int determinant = 0;
            List<int> SquaredMatrix = new List<int>(ComputeDeterminantAndSquare(sampleMatrix, ref determinant));

                       
            Console.WriteLine($"\n Determinant of the matrix is: {determinant} ");
            Console.WriteLine(" And the Squared Matrix is:\n");

            DisplaySquareMatrix(SquaredMatrix);

           // var elementList = new List<KeyValuePair<string, int>>();
             
            Console.ReadLine();
        }

        static void DisplaySampleMatrix(string[] sampleMatrix)
        {
            int count = 0;
            for (var i = 0; i < sampleMatrix.Length; i++)
            {
                Console.Write($"{sampleMatrix[i]} ");
                count++;
                if (count == 4)
                {
                    Console.WriteLine();
                    count = 0;
                }
            }
        }

        static int GetValue(string[] arr, ref int i)
        {
            int val = 0;
            try
            {
                Console.Write($"{arr[i]}: ");
                val = int.Parse(Console.ReadLine());
                
            }
            catch (FormatException formatException)
            {
                Console.WriteLine($"\n Exception Caught: {formatException.Message}");
                Console.WriteLine($" Setting {arr[i]} = 0");
                val = 0;
            }

            i++;
            
            return val;
        }

         static List<int> ComputeDeterminantAndSquare(string[] sampleMatrix, ref int det)
        {
            Console.WriteLine("----------------------------\n Enter Values for matrix");
            int sampleIndex = 0;

            int a1 = GetValue(sampleMatrix, ref sampleIndex);
            int b1 = GetValue(sampleMatrix, ref sampleIndex);
            int c1 = GetValue(sampleMatrix, ref sampleIndex);
            int d1 = GetValue(sampleMatrix, ref sampleIndex);

            int a2 = GetValue(sampleMatrix, ref sampleIndex);
            int b2 = GetValue(sampleMatrix, ref sampleIndex);
            int c2 = GetValue(sampleMatrix, ref sampleIndex);
            int d2 = GetValue(sampleMatrix, ref sampleIndex);

            int a3 = GetValue(sampleMatrix, ref sampleIndex);
            int b3 = GetValue(sampleMatrix, ref sampleIndex);
            int c3 = GetValue(sampleMatrix, ref sampleIndex);
            int d3 = GetValue(sampleMatrix, ref sampleIndex);

            int a4 = GetValue(sampleMatrix, ref sampleIndex);
            int b4 = GetValue(sampleMatrix, ref sampleIndex);
            int c4 = GetValue(sampleMatrix, ref sampleIndex);
            int d4 = GetValue(sampleMatrix, ref sampleIndex);

            //Compute determinant of the 3 by 3 sub-matrix 
            int detA = (b2 * (c3 * d4 - c4 * d3)) - (c2 * (b3 * d4 - b4 * d3)) + (d2 * (b3 * c4 - b4 * c3));
            int detB = (a2 * (c3 * d4 - c4 * d3)) - (c2 * (a3 * d4 - a4 * d3)) + (d2 * (a3 * c4 - a4 * c3));
            int detC = (a2 * (b3 * d4 - b4 * d3)) - (b2 * (a3 * d4 - a4 * d3)) + (d2 * (a3 * b4 - a4 * b3));
            int detD = (a2 * (b3 * c4 - b4 * c3)) - (b2 * (a3 * c4 - a4 * c3)) + (c2 * (a3 * b4 - a4 * b3));

            det = (a1 * detA) - (b1 * detB) + (c1 * detC) - (d1 * detD); //Compute determinant of entire 4 by 4 matrix


            //******************** Compute Square of the matrix************************///

            //define variables for square of Matrix store values in a List
            List<int> Square = new List<int>();

            //Row 1 Elements
            Square.Add((a1 * a1) + (b1 * a2) + (c1 * a3) + (d1 * a4));
            Square.Add((a1 * b1) + (b1 * b2) + (c1 * b3) + (d1 * b4));
            Square.Add((a1 * c1) + (b1 * c2) + (c1 * c3) + (d1 * c4));
            Square.Add((a1 * d1) + (b1 * d2) + (c1 * d3) + (d1 * d4));

            //Row ents
            Square.Add((a2 * a1) + (b2 * a2) + (c2 * a3) + (d2 * a4));
            Square.Add((a2 * b1) + (b2 * b2) + (c2 * b3) + (d2 * b4));
            Square.Add((a2 * c1) + (b2 * c2) + (c2 * c3) + (d2 * c4));
            Square.Add((a2 * d1) + (b2 * d2) + (c2 * d3) + (d2 * d4));

            //Row ents
            Square.Add((a3 * a1) + (b3 * a2) + (c3 * a3) + (d3 * a4));
            Square.Add((a3 * b1) + (b3 * b2) + (c3 * b3) + (d3 * b4));
            Square.Add((a3 * c1) + (b3 * c2) + (c3 * c3) + (d3 * c4));
            Square.Add((a3 * d1) + (b3 * d2) + (c3 * d3) + (d3 * d4));

            //Row 4 elements
            Square.Add((a4 * a1) + (b4 * a2) + (c4 * a3) + (d4 * a4));            
            Square.Add((a4 * b1) + (b4 * b2) + (c4 * b3) + (d4 * b4));            
            Square.Add((a4 * c1) + (b4 * c2) + (c4 * c3) + (d4 * c4));
            Square.Add((a4 * d1) + (b4 * d2) + (c4 * d3) + (d4 * d4));

            return Square;

        }

        static void DisplaySquareMatrix (List<int> MyList)
        {
            int nextLine = 0;
            foreach (int element in MyList)
            {
                Console.Write(String.Format("{0,-6}", element));
                nextLine++;
                if (nextLine == 4)
                {
                    Console.Write("\n");
                    nextLine = 0;
                }
            }
        }

     /*   void DisplayArray()
        {
            int index = 0;
            for (var i = 0; i < arr.GetLength(0); i++)
            {
                for (var j = 0; j < arr.GetLength(1); j++)
                {
                    for (var k = 0; k < arr.GetLength(2); k++)
                    {
                        for (int l = 0; l < arr.GetLength(3); l++)
                        {
                            //Console.Write($"{arr[i, j, k, l]}");
                            elementList.Add(new KeyValuePair<string, int>(sampleMatrix[index], arr[i, j, k, l])); //map array element against position
                            index++;
                        }
                        Console.WriteLine();
                    }
                }
                Console.WriteLine();
            }
        }*/
    }

}
