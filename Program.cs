// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Write("Введите число A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int B = Convert.ToInt32(Console.ReadLine());
// var result = Math.Pow(A, B);
// Console.Write($"Число {A} в степени {B}: {result}.");



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
// 82 -> 10
// 9012 -> 12

//УСЛОВИЕ
// Console.Write("Введите число: ");
// int imputNamber = int.Parse(Console.ReadLine());

//МЕТОД
// int SumNumber(int inputN)
// {
//     int result = 0;
//     while (inputN >0)
//     {
//         result += inputN % 10;
//         inputN = inputN / 10;
//     }
//     return result;
// }

// //ВЫВОД
// Console.WriteLine($"Сумма цифр числа {imputNamber}: {SumNumber(imputNamber)}");


// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите число элементов массива: ");
int size = int.Parse(Console.ReadLine());
Console.Write("Введите нижнюю границу диапазона чисел для генерации массива: ");
int minN = int.Parse(Console.ReadLine());
Console.Write("Введите верхнюю границу диапазона чисел для генерации массива: ");
int maxN = int.Parse(Console.ReadLine());

int[] array = GetArray(size, minN, maxN);

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size]; 
    for (int i = 0; i < result.Length; i++) // result.Length = size
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
Console.WriteLine($"Массив: [{String.Join(";", array)}]");