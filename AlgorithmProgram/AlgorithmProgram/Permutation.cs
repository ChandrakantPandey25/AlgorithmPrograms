using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProgram
{
    class Permutation
    {
        public static string SwapChar(string array, int startChar, int endChar)
        {
            char temp;
            char[] charArray = array.ToCharArray();
            temp = charArray[startChar];
            charArray[startChar] = charArray[endChar];
            charArray[endChar] = temp;
            string newStringForm = new string(charArray);
            return newStringForm;            
        }

        public static void PerformPermutation(string str, int start, int end)
        {
            if (start == end)
                Console.WriteLine(str);

            else
            {
                for (int i = start; i <= end; i++)
                {
                    str = SwapChar(str, start, i);
                    PerformPermutation(str, start + 1, end);
                    str = SwapChar(str, start, i);
                }
            }
        }

    }
    internal class CheckArrayString
    {
        public static bool CheckingGenString<T>(T[] strOne, T[] strTwo) where T : IComparable
        {
            int res = strOne.Length.CompareTo(strTwo.Length);            
            if (res == -1)
                return false;
            else if (res == 1)
                return false;
            else if (res == 0)
            {
                for (int i = 0; i < strOne.Length; i++)
                {
                    if (strOne[i].Equals(strTwo[i]) == false)
                        return false;

                }              

            }
            return true;
        }
        public static bool CheckString(string strOne, string strTwo)
        {
            char[] arrCharOne = strOne.ToCharArray();
            char[] arrCharTwo = strTwo.ToCharArray();

            if (arrCharOne.Length != arrCharTwo.Length)
                return false;            

            if (arrCharOne.Length == arrCharTwo.Length)
            {
                Array.Sort(arrCharOne);
                Array.Sort(arrCharTwo);
                for (int i = 0; i < arrCharOne.Length; i++)
                {
                    if (arrCharOne[i] != arrCharTwo[i])
                    {                        
                        return false;
                    }
                }                
                return true;
            }
            return false;

        }
    }
}

