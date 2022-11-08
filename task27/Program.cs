// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Программа принимает на вход целое число и выдаёт сумму цифо в числе!");
Console.WriteLine("Введите любое целое число: ");
int number = int.Parse(Console.ReadLine()!);

int SumDigitsInNumber(int number)
{
    int count = Convert.ToString(number).Length;
    int N = 0;
    int result = 0;

    for(int i = 0; i < count; i++){
        N = number - number % 10;
        result = result + (number - N);
        number = number / 10;
    }
    return result;
}
int sumDigit = SumDigitsInNumber(number);
Console.WriteLine("Результат вычисления: " + sumDigit);