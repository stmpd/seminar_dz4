// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, заполненный
// псевдослучайными числами и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = RandomArray(8);
int[] RandomArray( int arrayLength)  
{
    Random random = new Random();
    int[] arrayNew = new int[arrayLength];

    for (int i = 0; i < arrayNew.Length; i++)
    {
    arrayNew[i] = random.Next(0, 100);
    }
    return arrayNew;
}

void PrintArray( int[] array) 
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
        Console.Write(", ");
    }
    Console.Write("]");
}

PrintArray(array);