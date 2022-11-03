using System;

namespace MultipleArrayRotationMethod2
{
    class Program
    {
        public void leftRotate(int[] arr, int k)
        {
            int len = arr.Length;

            if (k == 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + ", ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = k; i < k + len; i++)
                {
                    Console.Write(arr[i % len] + ", ");
                }
                Console.WriteLine();
            }
            
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            int[] arr = { 1, 3, 5, 7, 9 };
            int k = 0;

            program.leftRotate(arr, k);

            k = 3;

            program.leftRotate(arr, k);

            k = 4;

            program.leftRotate(arr, k);
        }
    }
}
