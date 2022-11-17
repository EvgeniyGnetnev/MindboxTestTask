using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTestTask
{
    public class Circle : Shape
    {
        private double radius, circleArea;

        public Circle(double radius)
        {
            Radius = radius;
        }

        // Если значение радиуса отрицательное выбрасывает исключение (возможно стоило изменять на положительное)
        public double Radius
        {
            get { return radius; }
            set { radius = value < 0 ? throw new Exception("Введено отрицательные значение радиуса") : value; }
        }
        public override double GetArea()
        {
            circleArea = Math.PI * Math.Pow(radius, 2);
            return circleArea;
        }
        public override string ShapeType()
        {
            return "Круг";
        }
    }
}
