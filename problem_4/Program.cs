// Задача 62: Заполните спирально массив 4 на 4.
Console.Write("Введите размерность массива: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[n, n];

int value = 1;
int i = 0;
int j = 0;

while(value <= n * n)
{
    array[i, j] = value;
    if(i <= j + 1 && i + j < n - 1)
        ++j;
    else if (i < j && i + j >= n - 1)
        ++i;
    else if (i >= j && i + j > n - 1)
        --j;
    else
        --i;
    ++value;
}

for(int x = 0; x < array.GetLength(0); x++)
{
    for(int y = 0; y < array.GetLength(1); y++)
    {
        Console.Write(array[x, y] + " ");
    }   
        Console.WriteLine();
}
