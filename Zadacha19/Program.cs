﻿Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine()!;

if (number.Length < 5 || number.Length > 5)
{
    Console.WriteLine("Введено неверное число");
}
    else 
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
    
}

