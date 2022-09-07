using System;

namespace AlgorithmProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string for permutation: ");
            string arr = Console.ReadLine();
            Console.WriteLine("Permutation of string is: ");            
            Permutation.PerformPermutation(arr, 0, arr.Length - 1);
            
            Console.WriteLine("Enter first string:");
            string arrOne = Console.ReadLine();
            Console.WriteLine("Enter second string:");
            string arrTwo = Console.ReadLine();
            CheckArrayString.CheckString(arrOne, arrTwo);
            Console.WriteLine("string is" + CheckArrayString.CheckString(arrOne, arrTwo));
        }
    }
}
