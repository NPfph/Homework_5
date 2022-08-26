// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine($"Задача 36. Cумма элементов, стоящих на нечётных позициях.\n");

Random rand = new Random();
int[] arr = new int[4];
for(int i = 0; i < 4; i++)
{
    if(i % 2 == 0) 
    arr[i] = rand.Next(1,100);
    else 
    arr[i] = (rand.Next(1,100)) * -1;
}

void WriteArray(int[] arr){
    for (int i = 0; i<arr.Length; i++ )
    {
        Console.Write(arr[i] + " ");
    }
  Console.WriteLine();
}

int Amount(int[] arr)
{
    int sum = 0;
    for (int i = 0; i<arr.Length; i++ )
    {
    if (i % 2 != 0)
    {
      sum = sum + arr[i];
    }
    }
    return sum;
}
Console.Write("Получившийся массив: ");
WriteArray(arr);
Console.WriteLine();
int result = Amount(arr);
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях [1, 3]: {result}");