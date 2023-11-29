using System;

namespace lab1_13
{
    internal class Program
    {
        public static void Main(string[] args)
        {
         //Вариант 13
         //Описать класс для работы с  одномерным массивом:
         //- конструктор, заполняющий элементы массива из строки string (числа в строке разделяются двоеточиями);
         //- конструктор, заполняющий заданное в его параметре количество элементов массива натуральным рядом чисел, знак числа задается случайным образом;
         //- свойство, доступное только для чтения, для получения количества элементов массива;
         //- метод, вычисляющий произведение модулей элементов, расположенных до (левее) первого положительного элемента.
         //    Вывод на экран выполнять только в методе Main класса-клиента. Программа должна адекватно реагировать на ошибки пользователя и различные варианты исходных данных. Все тестовые данные предъявить преподавателю.

            var classForWorkingWithAOneDimensionalArray = new OneDimensionArrayWorker(5, ":10:12:14");
            Console.Write(classForWorkingWithAOneDimensionalArray.FindAbsoluteValueMultiplicationOfNotNegativeElementThatIsLeftFirstNotNegativeElement());
            Console.WriteLine(classForWorkingWithAOneDimensionalArray.size);
        }
    }
}