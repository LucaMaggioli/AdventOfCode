using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode
{
    public class Day1
    {
        public void Exercice()
        {
            Console.WriteLine("Hello World!");

            List<WindowOfThree> windowThreeList = new List<WindowOfThree>();

            // Read each line of the file into a string array. Each element of the array is one line of the file.
            List<string> fileLines = new List<string>(System.IO.File.ReadAllLines("C:/Users/mm/source/repos/AdventOfCode/AdventOfCode/src-files/data-day-1.txt"));

            Console.WriteLine(fileLines[fileLines.Count - 1]);
            Console.WriteLine(fileLines[fileLines.Count - 2]);
            Console.WriteLine(fileLines[fileLines.Count - 3]);


            fileLines.ForEach(line =>
            {
                WindowOfThree windowOf3 = new WindowOfThree();

                if (fileLines.IndexOf(line) <= fileLines.Count - 3)
                {
                    int actualLine = int.Parse(line);
                    int nextLine = int.Parse(fileLines[fileLines.IndexOf(line) + 1]);
                    int foreNextLine = int.Parse(fileLines[fileLines.IndexOf(line) + 2]);

                    windowOf3 = new WindowOfThree(actualLine, nextLine, foreNextLine);
                    windowThreeList.Add(windowOf3);
                    Console.WriteLine(line);
                    Console.WriteLine(windowOf3.Sum);
                }
            });

            int totalIncrements = 0;
            WindowOfThree prevWindOf3 = windowThreeList[0];
            windowThreeList.ForEach(actualWThree =>
            {
                if (actualWThree.HasBiggerSum(prevWindOf3))
                {
                    totalIncrements++;
                }
                prevWindOf3 = actualWThree;
            });

            Console.WriteLine(totalIncrements);

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

    //static void Main(string[] args)
    //{
    //    Console.WriteLine("Hello World!");

    //    List<WindowOfThree> windowThreeList = new List<WindowOfThree>();

    //    // Read each line of the file into a string array. Each element of the array is one line of the file.
    //    List<string> fileLines = new List<string>(System.IO.File.ReadAllLines("C:/Users/mm/source/repos/AdventOfCode/AdventOfCode/src-files/data-day-1.txt"));

    //    Console.WriteLine(fileLines[fileLines.Count - 1]);
    //    Console.WriteLine(fileLines[fileLines.Count - 2]);
    //    Console.WriteLine(fileLines[fileLines.Count - 3]);


    //    fileLines.ForEach(line =>
    //    {
    //        WindowOfThree windowOf3 = new WindowOfThree();

    //        if (fileLines.IndexOf(line) <= fileLines.Count - 3)
    //        {
    //            int actualLine = int.Parse(line);
    //            int nextLine = int.Parse(fileLines[fileLines.IndexOf(line) + 1]);
    //            int foreNextLine = int.Parse(fileLines[fileLines.IndexOf(line) + 2]);

    //            windowOf3 = new WindowOfThree(actualLine, nextLine, foreNextLine);
    //            windowThreeList.Add(windowOf3);
    //            Console.WriteLine(line);
    //            Console.WriteLine(windowOf3.Sum);
    //        }
    //    });

    //    int totalIncrements = 0;
    //    WindowOfThree prevWindOf3 = windowThreeList[0];
    //    windowThreeList.ForEach(actualWThree =>
    //    {
    //        if (actualWThree.HasBiggerSum(prevWindOf3))
    //        {
    //            totalIncrements++;
    //        }
    //        prevWindOf3 = actualWThree;
    //    });

    //    Console.WriteLine(totalIncrements);

    //    Console.Read();

    //}

}
