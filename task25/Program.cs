// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Программа принимает числа (A и B) и возводит A в B!");
Console.Write("Введите число A: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine()!);

int GetExponDigit(int numberA, int numberB){
    int result = 1;
    for(int count = 1; count <= numberB; count++)
    {
        result = result * numberA;
    }
    return result;
}

int result = GetExponDigit(numberA, numberB);

Console.WriteLine("Результат вычисления равен: " + result);