/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/
Console.Clear();
double[] array = GetRandomArray(10, -10, 10);
Console.WriteLine($"[{String.Join(", ", array)}]");
double max = GetMax(array);
double min = GetMin(array);
double difference = GetDifference(max, min);
Console.WriteLine($"{max}-{min} -> {difference}");


double[] GetRandomArray(int size, double minValue, double maxValue){
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble()* minValue - maxValue;
    }
    return array;
}

double GetMax(double[] array)
{
    double max = array[0];
      for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double GetMin(double[] array)
{
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
       if(array[i]< min)
        {
            min = array[i];
        }
    }
    return min;
}
double GetDifference(double min, double max)
{
    double dif = max - min;
    return dif;
}
