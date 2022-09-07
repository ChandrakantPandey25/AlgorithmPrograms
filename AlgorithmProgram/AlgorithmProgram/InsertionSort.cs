using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProgram
{
    
        public class InsertionSort
        {
            public static void DisplayArrayUsingSort()
            {                
                Console.WriteLine("Enter Eight words");

                string[] arrString = new string[8];
                for (int i = 0; i < arrString.Length; i++)
                {
                    arrString[i] = Console.ReadLine();
                }
                Array.Sort(arrString);
            Console.WriteLine("Printing Sorted Array List");
            foreach (string str in arrString)
                {                   
                    Console.WriteLine(str);
                }
            }
        }
    
}
