// Задача 29: Напишите программу, которая
// задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int arrayLen = 8;
int[] array = new int[arrayLen];
ArrayFill(array);
ArrayPrint(array);

void ArrayFill(int[] collection)
{
    int length = collection.Length;
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        collection[i] = rnd.Next(0, 51);
    }
}

void ArrayPrint(int[] collection)
{
    int length = collection.Length;
    Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{collection[i]}");
        Console.Write(i < collection.Length - 1 ? "," : "");
    }
    Console.WriteLine("]");
}
