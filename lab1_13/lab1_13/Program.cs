using System;

namespace lab1_13
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var classForWorkingWithAOneDimensionalArray = new OneDimensionArrayWorker(5, ":10:12:14");
            Console.Write(classForWorkingWithAOneDimensionalArray.FindAbsoluteValueMultiplicationOfNotNegativeElementThatIsLeftFirstNotNegativeElement());
            Console.WriteLine(classForWorkingWithAOneDimensionalArray.size);
        }
    }
}