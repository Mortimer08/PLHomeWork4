// Задача 29: Напишите программу, которая
// задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int arrayLen = 8;
int[] array = ArrayCreate(arrayLen);
ArrayPrint(array);

int[] ArrayCreate(int num)
// Выбран диапазон случайных чисел от 0 до 50
{
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = rnd.Next(0, 51);
    }
    return arr;
}

void ArrayPrint(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        Console.Write(i < array.Length - 1 ? "," : "");
    }
    Console.WriteLine("]");
}
