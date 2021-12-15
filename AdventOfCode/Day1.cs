using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode
{
    public class Day1
    {
        public void Exercice()
        {
            Console.WriteLine("Hello World!");

            List<int> fileLines = System.IO.File.ReadAllLines("C:/Users/maggioli/Desktop/Apprentissage/EPSIC-3/AdventOfCode/AdventOfCode/src-files/data-day-1.txt").Select(int.Parse).ToList();

            var count = -1;
            var prevElement = 0;
            for (var i=2; i < fileLines.Count; i++)
            {
                var actual = fileLines[i] + fileLines[i-1] + fileLines[i-2];

                count = actual > prevElement ? count + 1 : count;
                
                prevElement = actual;

            }
            Console.WriteLine(count);

            Console.Read();
        }
    }



    public class WindowOfThree
    {
        public int Sum { get; set; }

        public WindowOfThree() { }

        public WindowOfThree(int number1, int number2, int number3)
        {
            this.Sum = number1 + number2 + number3;
        }

        public bool HasBiggerSum(WindowOfThree otherW)
        {
            return this.Sum > otherW.Sum;
        }
    }
}
