using System;

namespace MindboxTestTask.ConsoleApp
{
    // Не совсем понял что имеется в виду под вычислением площади фигуры без знания её типа
    class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(1);
            circle.ShowInfo();

            Triangle triangle = new Triangle(6, 10, 8);
            triangle.ShowInfo();
        }
    }
}
