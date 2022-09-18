/* Напишите программу, которая спирально заполнит числами от 1 до 16 двумерный массив 4 на 4. */


int m = 4;
int value = 1;
int[,] array = new int[m, m];


for (int i = 0; i < array.GetLength(1); i++)
{
    array[0, i] = value;
    value++;
}

for (int j = 1; j < array.GetLength(0); j++)
{
    array[j, array.GetLength(1) - 1] = value;
    value++;
}

for (int i = array.GetLength(1) - 2; i >= 0; i--)
{
    array[array.GetLength(0) - 1, i] = value;
    value++;
}

for (int j = array.GetLength(0) - 2; j >= 1; j--)
{
    array[j, 0] = value;
    value++;
}

int Ti = 1;
int Tj = 1;

while (value < array.GetLength(0) * array.GetLength(1))
{
    while (array[Ti, Tj + 1] == 0)
    {
        array[Ti, Tj] = value;
        value++;
        Tj++;
    }
    while (array[Ti + 1, Tj] == 0)
    {
        array[Ti, Tj] = value;
        value++;
        Ti++;
    }
    while (array[Ti, Tj - 1] == 0)
    {
        array[Ti, Tj] = value;
        value++;
        Tj--;
    }
    while (array[Ti - 1, Tj] == 0)
    {
        array[Ti, Tj] = value;
        value++;
        Ti--;
    }
}

for (int j = 0; j < array.GetLength(0); j++)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        if (array[j, i] == 0)
        {
            array[j, i] = value;
        }
    }
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

ShowArray(array);

