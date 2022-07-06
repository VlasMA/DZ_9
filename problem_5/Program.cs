// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц;

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,] array)// метод на вывод массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int m = Input("Введите m: ");
int n = Input("Введите n: ");
Console.WriteLine();

int[,] numbers = new int[m, n];// заполнение массива рандомными числами

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for(int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i, j] = new Random().Next(1, 10);
    }
}

PrintArray(numbers);

Console.WriteLine();



int a = Input("Введите a: ");
int b = Input("Введите b: ");
Console.WriteLine();

int[,] numbersTwo = new int[a, b];// заполнение массива рандомными числами

for (int i = 0; i < numbersTwo.GetLength(0); i++)
{
    for(int j = 0; j < numbersTwo.GetLength(1); j++)
    {
        numbersTwo[i, j] = new Random().Next(1, 10);
    }
}

PrintArray(numbersTwo);

Console.WriteLine();

int[,] numbersTree = new int[numbers.GetLength(0), numbersTwo.GetLength(1)];

if (m != b)
{
    Console.WriteLine("Умножение не возможно");
    return;
}
else
{
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbersTwo.GetLength(1); j++)
    {
        for (int k = 0; k < numbersTwo.GetLength(0); k++)
        {
            numbersTree[i,j] += numbers[i,k] * numbersTwo[k,j];
        }
    }
}
Console.WriteLine(numbersTree);
}

