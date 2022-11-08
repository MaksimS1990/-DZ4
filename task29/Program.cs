// Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.
Console.WriteLine("Программа задает массив из чисел и выводит его на экран в одну строку");
Console.WriteLine("Введите количество: ");
int length = int.Parse(Console.ReadLine()!);
int[] array = new int[length];
Console.WriteLine("Введите числа массива по очереди через 'enter' ");

void readArrayGigits(int[] array){     //функция ввода
    int index = 0;
    while(index < length){
        array[index] = int.Parse(Console.ReadLine()!);
        index++;
    }
}

void printArrayDigits(int[] array){     //функция вывода
    int index = 0;
    while(index < length){
        Console.Write(array[index] + " ");
        index++;
    }
}

readArrayGigits(array);
Console.Write("Ваш массив в строку: ");
printArrayDigits(array);
