// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] GetRandomArray(int length, int leftRange, int rightRange)
{
    int[] array = new int[length]; 
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }

    return array;
}

void FindDigit(int[] array, int digit)
{
    bool find = false;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] == digit)
        {
            find = true;
        }
    }
    if (find == true)
    {
      Console.WriteLine("yes");  
    } 
    else
    {
        Console.WriteLine("no");

    }
}

Console.Write("Введите число для поиска: ");
int number = Convert.ToInt32(Console.ReadLine());

const int LENGTH = 4;
const int LEFTRANGE = -4;
const int RIGHTRANGE = 7;

int[] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);

Console.WriteLine($"{string.Join(", ", massive)}");
FindDigit(massive, number);