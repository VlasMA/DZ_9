// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента;

int dimension1 = InputInt("Введите размерность 1: ");
int dimension2 = InputInt("Введите размерность 2: ");
int dimension3 = InputInt("Введите размерность 3: ");
int countNumbers = 89;

if(dimension1 * dimension2 * dimension3 > countNumbers)
{
    Console.WriteLine("Массив слишком большой!");
    return;
}

int[,,] numbers = CreateArray(dimension1, dimension2, dimension3);

for(int i = 0; i < numbers.GetLength(0); i++)
{
    for(int j = 0; j < numbers.GetLength(1); j++)
    {
        for(int k = 0; k < numbers.GetLength(2); k++)
        {
            Console.Write($"[{i},{j},{k}] {numbers[i, j, k]}");
        }
Console.WriteLine();
}
    Console.WriteLine();
}

int[,,] CreateArray(int size1, int size2, int size3)
{
int[,,] array = new int[size1, size2, size3];
int[] digitValues = new int[countNumbers];
int value = 10;
for(int i = 0; i < digitValues.Length; i++)
digitValues[i] = value++;

for(int i = 0; i < digitValues.Length; i++)
{
int randomIndex = new Random().Next(0, digitValues.Length);
int temp = digitValues[i];
digitValues[i] = digitValues[randomIndex];
digitValues[randomIndex] = temp;
}

int valueIndex = 0;
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {   
        for(int k = 0; k < array.GetLength(2); k++)
        {
            array[i, j, k] = digitValues[valueIndex++];
        }
    }       
}
return array;
}


int InputInt(string output)
{
Console.Write(output);
return int.Parse(Console.ReadLine());
}
