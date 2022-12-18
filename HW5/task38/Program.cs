﻿// Задача 38: Задайте с клавиатуры массив вещественных (double) чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// Задать размер (int) массива с клавиатуры
// [3 7 22 2 78] => 76


double[] CreateArray()
 {
    double[] array = new double[5];
    Console.Write("Массив {");
    for (int i = 0; i < 5; i++)
    {
    
        array [i]= 100*Math.Round(new Random().NextDouble(),4);
        Console.Write($"{array [i]}");
    }
    Console.WriteLine("}\n");
    return array;
 }

 void Diff(double[] myArray)
 {
    int Max = 0;
    int Min = 0;
    for (int i = 1; i < myArray.Length; i++)
    {
        if (myArray[i] > myArray[Max]) Max = i;
        if(myArray[i] < myArray[Max]) Min = i;
    }
    Console.WriteLine($"разница max-min = {Math.Round(myArray[Max]-myArray[Min],2)}");

 }

Diff(CreateArray());