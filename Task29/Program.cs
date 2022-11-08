// SНапишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();

int[] FillArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(3, 87);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[^1]}]");
}
int[] massive = FillArray(8); //можно сделать универсальный вариант и запрашивать число у пользователя, но в задаче четко обозначен массив из восьми элементов
PrintArray(massive);
