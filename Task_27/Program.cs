// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите Ваше число: ");
int num = Convert.ToInt32(Console.ReadLine());

int DigitLength(int number) 
{
    int result = 1;
    int count = 0;
    while (result <= number)
    {
        result = result * 10;
        count++;
    }
    return count;
}
int digitlength = DigitLength(num);

int GetSum(int number) 
{
    int count = 0;
    int result = 0;
    while (count < digitlength)
    {
        int numberA = number % 10;
        result = result + numberA;
        number = number / 10;
        count++;
    }
    return result;
}

int getsum = GetSum(num);
Console.WriteLine(getsum);