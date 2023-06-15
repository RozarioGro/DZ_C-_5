/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
Console.Clear();
int[] array = GetArray(10, 100, 1000);
Console.WriteLine($"[{String.Join(", ", array)}]");
int qen = GetPos(array);
Console.WriteLine($"Quantity of even number -> {qen}");



int[] GetArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for(int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue);
    }
    return arr;
    
}

int GetPos(int[] array)
{
    int count = 0;
    foreach(int el in array)
    {
        if(el % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
