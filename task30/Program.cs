// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.. 
//Далее надо посчитать количество нулей и единиц, если единиц больше чем нулей то вывести TRUE на экран, иначе вывести False.

Console.WriteLine("Напишите число: ");
int number = int.Parse(Console.ReadLine()!);
int [] array = new int [number];
Random random = new Random();

void RandomArray(int []array)                 //функция заполнения массивая 0 и 1 в случайном порядке
{
    int index = 0;
    while (index < number){
        array[index] = random.Next(0, 2);
        index++;
    }
}

void PrintArray(int[] array)                  //функция вывода массивва в консоль
{
    int index = 0;
    while (index < number){
        Console.Write(array[index] + " ");
        index++;
    }
}

void TrueFalseArray(int[] array)              //функция определения True или False
{
    int maxcount = 0;
    int mincount = 0;
    int index = 0;
    while (index < number){
        if(array[index] > 0){
            maxcount++;
            index++;
        }
        else{
            mincount++;
            index++;
        }
    }
    if (maxcount > mincount){
        Console.WriteLine("True");
    }
    else{
        Console.WriteLine("False");
    }
}

RandomArray(array);
Console.Write("Массив в строку ");
PrintArray(array);
TrueFalseArray(array);