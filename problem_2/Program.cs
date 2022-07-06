// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов;
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

int sum = int.MaxValue;
int index = 0;
for (int i = 0; i < numbers.GetLength(0); i++)
{
    int temp = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        temp += numbers[i, j];
    }
    if (temp < sum)
    {
        sum = temp;
        index = i + 1;
    }
}
Console.WriteLine("Строка с наименьшей суммой элементов : "+index+ "," + " её сумма - "+sum);