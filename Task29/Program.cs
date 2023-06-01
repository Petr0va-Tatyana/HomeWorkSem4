// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();
Console.WriteLine("Введите количество элементов массива:\t");
int elementsCount = int.Parse(Console.ReadLine());
int[] myArray = new int[elementsCount];
for(int i = 0; i < elementsCount; i++)
{
    Console.WriteLine("Введите {0}-й элемент", i + 1);
    myArray[i] = int.Parse(Console.ReadLine());
}
          
Console.WriteLine("Вывод массива: ");

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i]);
}
Console.ReadLine();    