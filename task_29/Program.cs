Console.Write("Введи количество элементов массива:\t");
int elements = int.Parse(Console.ReadLine());
int[] array = new int[elements];
Console.WriteLine("Вывод массива:");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
