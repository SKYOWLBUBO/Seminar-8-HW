// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array ={
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4},
    {5,2,6,7}
};
System.Console.WriteLine($"Номер строки с минимальной суммой элементов = {MinRow(array)}");

int MinRow(int[,] array)
{
    int result = 0; // номер строки с мин суммой
    int min_sum = 0;
    for(int j = 0; j < array.GetLength(0); j++)
    {
        System.Console.Write(array[0,j] + " ");
        min_sum += array[0,j];
    }
    System.Console.Write("\t Сумма 0-ой строки =" + min_sum);

    for(int i = 1; i < array.GetLength(0); i++)
    {
        int temp = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] + " ");
            temp +=array[i,j];
        }
        System.Console.WriteLine($"\t Сумма {i} строки = {temp}");

        if(temp < min_sum)
        {
            min_sum = temp;
            result = i;
        }
    }
    return result;
}
