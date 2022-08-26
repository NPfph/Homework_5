// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

int n = 5;
double [] array = new double[n];
Random rand = new Random();
for (int i = 0; i < n; i++)
{
    if(i % 2 == 0) 
    array[i] = rand.Next(1,100);
    else 
    array[i] = (rand.Next(1,100)) * -1;
}

void WriteArray(double[] array)
{
    for (int i = 0; i<array.Length; i++ )
    {
    Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double maxNumber = array[0];
double minNumber = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (maxNumber < array[i])
    {
      maxNumber = array[i];
    }
        if (minNumber > array[i])
    {
      minNumber = array[i];
    }
}

double result = maxNumber + minNumber;

WriteArray(array);

Console.WriteLine($"\nРазница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {result}");