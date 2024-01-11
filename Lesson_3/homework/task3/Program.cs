// double[] array = { 2.2, 0.4, 9.11, 7.2, 78.98 };

// double min = array[0];
// double max = array[0];

// foreach (double i in array)
// {
//     if (i > max)
//     {
//         max = i;
//     }
//     if (i < min)
//     {
//         min = i;
//     }
// }

// Console.Write($"Разница между минимальным {min} и максимальным {max} числом равна {max - min}");

using System;
using System.Linq;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
    // Разница между максимальным и минимальным элементами массива

    // Нахождение минимума массива
    public static double FindMin(double[] numbers)
    {
        //Напишите свое решение здесь
        double min = numbers[0];

        foreach (double i in numbers)
        {
            if (i < min)
            {
                min = i;
            }
        }
        return min;
    }

    // Нахождение максимума массива
    public static double FindMax(double[] numbers)
    {
        // Напишите свое решение здесь
        double max = numbers[0];

        foreach (double i in numbers)
        {
            if (i > max)
            {
                max = i;
            }
        }
        return max;
    }



    public static void PrintResult(double[] array)
    {
        //Напишите свое решение здесь
        Console.WriteLine(FindMax(array) - FindMin(array));
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        double[] array;


        if (args.Length >= 1)
        {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                                  .Select(double.Parse)
                                  .ToArray();

            // Теперь arr содержит преобразованные в целые числа из командной строки

        }
        else
        {
            // Если аргументов на входе нет
            array = new double[] { 0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01 }; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}