﻿void TabCube(int num)
{
    int count = 1;
    while(count <= num)
    {
        Console.WriteLine($"{count, 3} -> {count*count*count, 5}");
        count++;
    }
}

Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());

TabCube(number);