// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int GetMultiplication(int numA, int numB)
{
    int multiplication = numA;
    for (int i = 1; i < numB; i++)
    {
        multiplication *= numA;
    }
    return multiplication;
}

int result = GetMultiplication(A, B);
Console.WriteLine($"{A}, {B} | {result}");
