using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Runtime.InteropServices;

namespace OOP_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle myCircle = new Circle(5);
            double myResult = myCircle.getArea();

            Circle myNewCircle = new (6); //funkar så också
            double myNewResult = myNewCircle.getArea();

            Sphere mySphere = new Sphere(5);
            double mySphereResult = mySphere.getArea();

            Console.WriteLine("the areas of the circle are: {0} {1}", myResult, myNewResult);
            Console.WriteLine("the area of the sphere is: " + mySphereResult);

        }      

        class Sphere
        {
            private double _radius;

            public Sphere(double newRadius)
            {
                _radius = newRadius;
                Console.WriteLine("Contructor of the sphere has run with: " + _radius);
            }

            public double getArea()
            {
                return 4.0/3 * Math.PI * Math.Pow(_radius, 3);
            }
        }

        class Circle
        {
            private double _radius;

            public Circle(double newRadius)
            {
                _radius = newRadius;
                Console.WriteLine("Constructor has run with: {0}", _radius);
            }

            public double getArea()
            {
                return Math.Pow(_radius, 2) * Math.PI;
            }
        }
    }
}