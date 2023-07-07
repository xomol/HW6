// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4


/*Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

int[] array = GetArray(size, -1000, 1000);
Console.WriteLine($"[{String.Join(", ", array)}]");

int sum = 0;

foreach(int el in array)
{
    sum += el > 0 ? 1: 0;
}

Console.WriteLine($"Положительных элементов {sum}");

// Функция заполнения массива
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}*/


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


/*Console.Write("введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");*/