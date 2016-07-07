using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jake");
            List<Shape> shapes = new List<Shape>();

            shapes.Add(new Circle(5.5));
            shapes.Add(new Circle(5.5, 1, 2));
            shapes.Add(new Triangle());

            foreach (Shape s in shapes)
            {
                System.Console.WriteLine(s.Discription());
                System.Console.WriteLine(s.Discription2());
                ShapeManager.Instance.DoWork();
            }
            Yo();
            Program2.Yo();
            System.Console.ReadLine();
        }

        static void Yo()
        {
            for (int i = 0; i < 5; ++i)
                ShapeManager.Instance.DoWork();
        }
    }

    class Program2
    {

        public static void Yo()
        {
            for (int i = 0; i < 5; ++i)
                ShapeManager.Instance.DoWork();
        }

    }
}
