//Задача 29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
void newArray (int[] array)
{
    int length = array.Length;
    int i = 0;
    while (i < length)
    {
        Console.WriteLine($"Введите элемент массива [{i}]:");
        int n = Convert.ToInt32(Console.ReadLine());
        array[i] = n;
        i++;
    }
}
void PrintArray(int[] arr)
{
    int count = arr.Length;
    int i = 0;
    while (i < count)
    {
        Console.Write(arr[i] + " ");
        i++;
    }
}
int[] array = new int[8];
int count = array.Length;
newArray(array);
PrintArray(array);
