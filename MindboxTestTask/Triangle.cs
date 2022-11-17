using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTestTask
{
    public class Triangle : Shape
    {
        // Стороны треугольника
        double sideA, sideB, sideC, semiPerimeter, triangleArea;
        public Triangle(double triangleSideA, double triangleSideB, double triangleSideC)
        {
            SideA = triangleSideA;
            SideB = triangleSideB;
            SideC = triangleSideC;
        }

        // Если значение отрицательное выбрасывает исключение (возможно стоило изменять на положительное)
        public double SideA
        {
            get { return sideA; }
            set { sideA = value < 0 ? throw new Exception("Введено отрицательные значение для стороны") : value; }
        }

        public double SideB
        {
            get { return sideB; }
            set { sideB = value < 0 ? throw new Exception("Введено отрицательные значение для стороны") : value; }
        }

        public double SideC
        {
            get { return sideC; }
            set { sideC = value < 0 ? throw new Exception("Введено отрицательные значение для стороны") : value; }
        }
        public override double GetArea()
        {
            semiPerimeter = (sideA + sideB + sideC) / 2;

            triangleArea = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
            return triangleArea;
        }

        public override string ShapeType()
        {
            if (IsRight())
                return "Прямоугольный треугольник";
            else
                return "Треугольник";
        }

        // Проверка на то, является ли треугольник прямоугольным
        public bool IsRight()
        {
            if ((sideA * sideA + sideB * sideB == sideC * sideC) || (sideA * sideA + sideC * sideC == sideB * sideB) || (sideC * sideC + sideB * sideB == sideA * sideA))
                return true;
            else
                return false;
        }
    }
}
