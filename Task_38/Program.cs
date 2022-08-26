// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
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
    Console.Write("{0:0.0} ", array[i]);
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

Console.WriteLine($"\nРазница между между максимальным и минимальным элементами:");
Console.Write("{0:0.0} ", result);