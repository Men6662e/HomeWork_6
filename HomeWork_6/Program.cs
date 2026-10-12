int[] originalArray = { 10, 20, 30, 40, 50 };

Console.Write("Исходный массив: ");
for (int i = 0; i < 5; i++)
{
    Console.Write(originalArray[i] + " ");
}
Console.WriteLine();

int[] reversedArray = new int[5];

int j = 4;
for (int i = 0; i < 5; i++)
{
    reversedArray[j] = originalArray[i];
    j--;
}

Console.Write("Перевернутый массив: ");
for (int i = 0; i < 5; i++)
{
    Console.Write(reversedArray[i] + " ");
}
Console.WriteLine();

Console.ReadLine();
