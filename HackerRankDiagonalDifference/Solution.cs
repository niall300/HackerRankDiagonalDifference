using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Print the absolute difference between the two sums of the matrix's
//    diagonals as a single integer.

//The first line contains a single integer, n. 
//    The next n lines denote the matrix's rows, 
//with each line containing space-separated integers describing the columns.

//we want the Absolute difference (ignore minus figures)


namespace HackerRankDiagonalDifference
{
    class Solution
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];

            
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);

            }

            FindDiagonalDifference(a,n);
        }

        static int FindDiagonalDifference(int [][] arr, int size)
        {
            int result = 0;
            //first measure primary diagonal
            int primaryDiag = 0;
            for (int i = 0; i < size; i++)
            {
                primaryDiag = primaryDiag + arr[i][i];
            }

            //then measure secondary diagonal
            int secondaryDiag = 0;
            for (int i = 0; i < size; )
            {
                for (int j = size-1; j >= 0; j--)
                {
                    secondaryDiag = secondaryDiag + arr[i][j];
                    i++;
                }
                
            }

            int DiagDifference = primaryDiag - secondaryDiag;
            DiagDifference = Math.Abs(DiagDifference);

            Console.WriteLine("Primary Diagonal = {0} ", primaryDiag);
            Console.WriteLine("Secondary Diagonal = {0} ", secondaryDiag);

            Console.WriteLine("The absolute diagonal difference is {0}", DiagDifference);
            Console.ReadLine();

            return result;
        }
    }
}
