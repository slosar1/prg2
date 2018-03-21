using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace prg2._4_functional_programming
{
    public class LinqPractice
    {
        public void problem1()
        {
            Console.WriteLine("write something:");
            string TheSteam = Console.ReadLine();
            List<string> TheWord = new List<string>();
            List<string> BigWord = new List<string>();
            TheWord = TheSteam.Split(' ').ToList();
            BigWord = TheSteam.ToUpper().Split(' ').ToList();
            List<string> matching = TheWord.Intersect(BigWord).ToList();
            Console.WriteLine(" ", matching.ToArray());
        }
    }
}