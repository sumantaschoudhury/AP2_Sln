using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpPractice
{
    class Program1
    {
        static void Main(string[] args)
        {
            var x = "Dormitory";
            var y = "dirty room";

            var x1 = x.ToLower().ToList();
            x1.Sort();

            var y1 = y.ToLower().Replace(" ", "").ToList();
            y1.Sort();

            var isAnagram = true;

            if (x1.Count != y1.Count)
            {
                isAnagram = false;
            }
            else
            {
                for(int i = 0; i < x1.Count; i++)
                {
                    if (x1[i] != y1[i]){
                        isAnagram = false;
                    }
                }
            }

            Console.WriteLine("Anagaram = " + isAnagram);

        }
    }

}
