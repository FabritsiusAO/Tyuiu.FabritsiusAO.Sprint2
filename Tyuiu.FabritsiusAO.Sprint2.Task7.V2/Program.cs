﻿using Tyuiu.FabritsiusAO.Sprint2.Task7.V2.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнил: Фабрициус А. О. | ИСТНб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #2                                                              *");
        Console.WriteLine("* Выполнил: Фабрициус Андрей Олегович | ИСТНб-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные           *");
        Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с координатами  *");
        Console.WriteLine("* X,Y в заштрихованной области.                                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите x:");
        Double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите y:");
        Double y = Convert.ToDouble(Console.ReadLine());
        bool res = ds.CheckDotInShadedArea(x, y);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        if (res)
        {
            Console.WriteLine("Точка находится в заштрихованной области");
        }
        else
        {
            Console.WriteLine("Точка находится в незаштрихованной области");
        }
    }
}