using System;
namespace CODING
{
        class Program
    {
        public static void Main(string[] args)
        {
            int[] arr= new int[5];
            for(int i=0; i<5; i++)
            {
                Console.WriteLine("mata in tal "+(i+1));
                arr[i]=int.Parse(Console.ReadLine());
            }
            foreach(int e in arr)
            {
                Console.Write(arr[e]);
            }
        }
    }
}