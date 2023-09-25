// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
    int sum = 0;
    for (int l = 0; l < arr.Length; l++)
    {
        if (arr[l] % 2 == 0) sum++;

    }
    Console.WriteLine($"Чётных чисел {sum}");
}

Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine()!);
int[] Array = CreateArrayRndInt(length, 1, 999);
Console.WriteLine($"[{string.Join(", ", Array)}]");
Evennumber(Array);