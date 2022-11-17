using System;

namespace MindboxTestTask
{
    public abstract class Shape
    {
        public abstract double GetArea();
        public abstract string ShapeType();
        public void ShowInfo()
        {
            Console.WriteLine($"Тип фигуры: {ShapeType()}\nПлощадь: {GetArea()}");
        }
    }
}
