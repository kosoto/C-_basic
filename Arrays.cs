using System;
namespace ArrayApp
{
    class ArrayApp
    {
        void one_dim()
        {   //배열 초기화의 여러가지 방법
            int[] arr = new int[5];
            double[] balance = { 2340.0, 4523.69, 3421.0 };
            int[] marks = new int[5] { 99, 98, 92, 97, 95 };
            int[] marks2 = new int[] { 99, 98, 92, 97, 95 };

            //배열의 각 원소에 접근하기
            int[] n = new int[10]; /* n is an array of 10 integers */

            /* initialize elements of array n */
            for (int i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            /* output each array element's value */
            foreach (int j in n)
            {
                int i = j - 100;
                Console.WriteLine("Element[{0}] = {1}", i, j);
            }
        }
        void n_dim()
        {
            /* an array with 5 rows and 2 columns*/
            int[,] a = new int[5, 2] { { 0, 0 }, { 1, 2 }, { 2, 4 }, { 3, 6 }, { 4, 8 } };
            int i, j;

            /* output each array element's value */
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0},{1}] = {2}", i, j, a[i, j]);
                }
            }
        }
        void jagged()
        {   //배열들의 배열
            int[][] scores = new int[5][];
            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = new int[4];
            }
            //다른 초기화 방법, 사이즈가 같지 않아도 된다.
            int[][] scores2 = new int[2][] { new int[] { 92, 93, 94 }, new int[] { 85, 66, 87, 88 } };
            int[][] a = new int[][]{new int[]{0,0},new int[]{1,2},
            new int[]{2,4},new int[]{ 3, 6 }, new int[]{ 4, 8 } };
            
        }
        void arrayClass()
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            
            //properties
            bool isFixedSize = arr.IsFixedSize;
            bool isReadOnly = arr.IsReadOnly;
            int length = arr.Length;
            int rank = arr.Rank;

            //methods
            //배열, 시작인덱스, 갯수
            //default값으로 초기화
            Array.Clear(arr,1,4);
            //1차원 배열의 정렬,오름차순
            Array.Sort(arr);
            //1차원 배열의 역순
            Array.Reverse(arr);

        }
    }
}