using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlgorithmProgram
{
    class BinarySearch
    {
        public static void SearchWord()
        {

            FileStream fileStream = new FileStream(@"C:\review.txt", FileMode.Open, FileAccess.Read);
            Console.WriteLine("Searching word in the filepath C:/review.txt");
            StreamReader reader = new StreamReader(fileStream);
            string record;
            string input;
            Console.WriteLine("Enter word to search");
            input = Console.ReadLine();
            try
            {
                record = reader.ReadLine();
                while (record != null)
                {
                    if (record.Contains(input))
                    {
                        Console.WriteLine("word present in the file");
                        SearchWord();
                    }
                    else
                    {
                        Console.WriteLine("word not present");
                        break;
                    }

                    record = reader.ReadLine();
                }
            }
            finally
            {
                reader.Close();
                fileStream.Close();
            }
        }

        
    }
}
