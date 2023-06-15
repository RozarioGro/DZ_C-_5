/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
Console.Clear();
int[] array = GetRandomArray(10, -100, 100);
Console.WriteLine($"[{String.Join(", ", array)}]");
int sum = GetSumNeg(array);
Console.WriteLine($"Quantity of even number -> {sum}");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int [] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array; 
}

int GetSumNeg(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i++){
       int el = array[i];
       if(i % 2 != 0){
        sum = sum + el;
       }
    }
    return sum;
}
