// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}



void Evennumber(int[] arr)
{
    int odd = 0;
    for (int j = 1; j < arr.Length; j = j + 2)
    {
        odd = odd + arr[j];
    }
    Console.WriteLine($"Сумма чисел на нечётных позициях {odd}");
}

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение массива: ");
int minValue = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение массива: ");
int maxValue = int.Parse(Console.ReadLine()!);
int[] Array = CreateArrayRndInt(size, minValue, maxValue);
Console.WriteLine($"[{string.Join(", ", Array)}]");
Evennumber(Array);