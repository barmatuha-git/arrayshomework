//Создайте консольное приложение, которое выполняет следующие операции с массивами:

//- Создайте одномерный массив из 10 случайных целых чисел в диапазоне от 1 до 100.
//- Напечатайте содержимое массива на консоль. Это должно быть выполнено с помощью цикла for.
//- Вычислите и выводите на консоль среднее арифметическое чисел в массиве.
//- Посчитайте и выведите на консоль количество чисел больше среднего арифметического. Это должно быть выполнено с помощью цикла for и условного оператора if.
//- Создайте новый массив, содержащий только числа из исходного массива, которые больше среднего арифметического. Для этого можно использовать цикл for для прохода по исходному массиву и условный оператор if для проверки каждого элемента.
//- Выведите новый массив на консоль.

using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int[] numbers = new int[10];
        
        for (int i = 0; i < numbers.Length; i++) // рандомные числа в массиве
        {
            numbers[i] = random.Next(1, 100);

        }

        Console.WriteLine("Standart Array:");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " "); // выводим циклом в строку

        }

        Console.WriteLine();

        int sum = 0; // суммирууем

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        double average = (double)sum / numbers.Length; // среднее

        Console.WriteLine("Average: " + average);

        int count = 0; 

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i ] > average)
            {
                count++; // увеличить колво чисел найденных чисел на один
            }

        }

        Console.WriteLine("count above average: " + count);

        int[] aboveAverage = new int[count]; // считаем меньше среднего
        int index = 0; // индекс для заполнения массива

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > average)
            {
                aboveAverage[index] = numbers[i];
                index++;
            }
        }

        Console.WriteLine("nubmers above average: "); 

        for (int i = 0; i < aboveAverage.Length; i++)
        {
            Console.Write(aboveAverage[i] + " ");
        }

        Console.WriteLine() ;
    }
}