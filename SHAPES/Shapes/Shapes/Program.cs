using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double circleRadius;
            double rectangleWidth;
            double rectangleLength;
            double triangleBase;
            double triangleHeight;

            double perimeter;
            double rectangleArea;
            double triangleArea;
            double circleArea;

            Console.WriteLine("For CIRCLE type 1, for RECTANGLE type 2, for TRIANGLE type 3.");
            string shapeSelectionInput = Console.ReadLine();

            if(shapeSelectionInput == null)
            {
                shapeSelectionInput = "";
            }
            switch (shapeSelectionInput) 
            {
                case "1":
                    GetCircleArea();
                    break;
                case "2":
                    GetRectanglePerimeterAndArea();
                    break;
                case "3":
                    GetTriangleArea();
                    break;
                default:
                    Console.WriteLine("Invalid selection");
                    break;
            }

            void GetCircleArea()
            {
                Console.WriteLine("You chose CIRCLE. Enter a radius of your cirlce.");
                circleRadius = Convert.ToDouble(Console.ReadLine());

                if(circleRadius <= 0)
                {
                    throw new InvalidOperationException("Circle radius cannot be less or equal to 0.");
                }
                Circle circle = new Circle();
                circleArea = circle.CalculateArea(circleRadius);
                Console.WriteLine($"The area of your circle is {circleArea}.");
            }

            void GetRectanglePerimeterAndArea()
            {
                Console.WriteLine("You chose RECTANGLE. Enter a width of your rectangle.");
                rectangleWidth = Convert.ToDouble(Console.ReadLine());

                if (rectangleWidth <= 0)
                {
                    throw new InvalidOperationException("Value should be positive.");
                }

                Console.WriteLine("Enter a length of your rectangle.");
                rectangleLength = Convert.ToDouble(Console.ReadLine());

                if (rectangleLength <= 0)
                {
                    throw new InvalidOperationException("Value should be positive.");
                }

                Rectangle rectangle = new Rectangle();
                perimeter = rectangle.CalculatePerimeter(rectangleWidth, rectangleLength);
                Console.WriteLine($"The perimter of your rectangle is {perimeter}.");

                rectangleArea = rectangle.CalculateArea(rectangleWidth, rectangleLength);
                Console.WriteLine($"The area of your rectangle is {rectangleArea}.");
            }

            void GetTriangleArea()
            {
                Console.WriteLine("You chose TRIANGLE. Enter a base of your triangle.");
                triangleBase = Convert.ToDouble(Console.ReadLine());

                if (triangleBase <= 0)
                {
                    throw new InvalidOperationException("Value should be positive.");
                }

                Console.WriteLine("Enter a height of your triangle.");
                triangleHeight = Convert.ToDouble(Console.ReadLine());

                if (triangleHeight <= 0)
                {
                    throw new InvalidOperationException("Value should be positive.");
                }

                Triangle triangle = new Triangle();
                triangleArea = triangle.CalculateArea(triangleBase, triangleHeight);
                Console.WriteLine($"The area of your triangle is {triangleArea}.");
            }
        }
    }
}