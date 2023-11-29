using System;

namespace lab1_13
{
    public class OneDimensionArrayWorker
    {
        private int[] array;
        public uint size { get; private set; }

        public OneDimensionArrayWorker(uint arrayLength, string massiv)
        {
            size = arrayLength;
            array = new int[arrayLength];
            string[] separators = { ":"};
            string[] split = massiv.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < array.Length; i++)
            {
                try
                {
                    array[i] = int.Parse(split[i]);
                }
                catch
                {
                    throw new Exception("Data is not valid");
                }
            }
        }

        public int FindAbsoluteValueMultiplicationOfNotNegativeElementThatIsLeftFirstNotNegativeElement() // Нормальное же название, в задании так и написано, отражает суть класс 
        {
            var sum = 0;

            foreach (var element in array)
            {
                if (element > 0)
                {
                    break;
                   
                } 
                sum *= Math.Abs(element);
            }

            return sum;
        }
        
    }
}