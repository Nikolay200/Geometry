using FigureClassLibrary;
using System;
using System.Collections.Generic;

namespace GeometryConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var figures = new List<Figure>();
            Console.WriteLine("Эта программа вычисляет площадь и периметр фигуры. Необходимо выбрать фигуру.");

            Console.WriteLine("Например - Круг");
            Console.WriteLine("Введите значение радиуса: ");

            var radius = Convert.ToInt32(Console.ReadLine());
            var circle = new Figure("Круг", radius);
            figures.Add(circle);
            Console.WriteLine($"Площадь = {circle.CalculateSquare(radius)}");
            Console.WriteLine($"Периметр = {circle.CalculatePerimeter(radius)}");
        Start:
            Console.WriteLine("Хотите добавить фигуру? Введите Да или Нет.");
            var answer = Console.ReadLine();
            if (answer.ToLower() == "да")
            {
                Console.WriteLine("Введите название фигуры: ");
                var input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "треугольник":

                        Console.WriteLine("Вы выбрали Треугольник");
                        Console.WriteLine("Введите значения всех сторон треугольника через пробел: ");
                        string[] array3 = SplitValues();

                        var triangle = new Figure("Треугольник", double.Parse(array3[0]), double.Parse(array3[1]), double.Parse(array3[2]));
                        figures.Add(triangle);
                        Console.WriteLine($"Площадь = {triangle.CalculateSquare(double.Parse(array3[0]), double.Parse(array3[1]), double.Parse(array3[2]))}");
                        Console.WriteLine($"Периметр = {triangle.CalculatePerimeter(double.Parse(array3[0]), double.Parse(array3[1]), double.Parse(array3[2]))}");
                        Console.WriteLine("Хотите узнать является ли данный треугольник прямоугольным? Введите Да или Нет.");
                        var accept = Console.ReadLine();

                        if (accept.ToLower() == "да")
                        {

                            if (triangle.IsPerpendicular(double.Parse(array3[0]), double.Parse(array3[1]), double.Parse(array3[2])))
                            {
                                Console.WriteLine($"Треугольник со сторонами {double.Parse(array3[0])}, {double.Parse(array3[1])}, {double.Parse(array3[2])} является перпендикулярным.");
                            }
                            else
                            {
                                Console.WriteLine($"Треугольник со сторонами {double.Parse(array3[0])}, {double.Parse(array3[1])}, {double.Parse(array3[2])} не является перпендикулярным.");
                            }

                        }

                        if (accept.ToLower() == "нет")
                        {
                            Console.WriteLine("Выйти в главное меню? Введите Да или Нет.");
                            var mainMenu = Console.ReadLine();

                            if (mainMenu.ToLower() == "да")
                            {
                                goto Start;
                            }
                            else
                            {
                                Console.WriteLine("Вы покинули проект.");
                                break;
                            }
                        }
                        break;

                    case "прямоугольник":

                        Console.WriteLine("Вы выбрали Прямоугольник");
                        Console.WriteLine("Введите значения 2 сторон прямоугольника через пробел: ");
                        string[] array2 = SplitValues();

                        var rectangle = new Figure("Прямоугольник", double.Parse(array2[0]), double.Parse(array2[1]));
                        figures.Add(rectangle);
                        Console.WriteLine($"Площадь = {rectangle.CalculateSquare(double.Parse(array2[0]), double.Parse(array2[1]))}");
                        Console.WriteLine($"Периметр = {rectangle.CalculatePerimeter(double.Parse(array2[0]), double.Parse(array2[1]))}");

                        Console.WriteLine("Хотите посмотреть, какие фигуры есть в наличии? Введите Да или Нет.");

                        var inputData = Console.ReadLine();
                        {
                            if (inputData.ToLower() == "да")
                            {
                                foreach (var item in figures)
                                {
                                    Console.WriteLine(item.name);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Выйти в главное меню? Введите Да или Нет.");
                                var exit = Console.ReadLine();

                                if (exit.ToLower() == "да")
                                {
                                    goto Start;
                                }
                                else
                                {
                                    Console.WriteLine("Вы покинули проект.");
                                    break;
                                }
                            }
                        }
                        Console.WriteLine("Выйти в главное меню? Введите Да или Нет.");
                        var main = Console.ReadLine();

                        if (main.ToLower() == "да")
                        {
                            goto Start;
                        }
                        else
                        {
                            Console.WriteLine("Вы покинули проект.");
                            break;
                        }
                }
            }
        }

        private static string[] SplitValues()
        {
            var sidesInput = Console.ReadLine();
            var sidesArray = sidesInput.Split(' ');
            return sidesArray;
        }
    }
}
