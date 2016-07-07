using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesFramework
{
    abstract class Shape
    {
        public abstract string Discription();
        public string Discription2()
        {
            return "This is a shape yo.";
        }
    }

    class Circle : Shape
    {
        private double radius;
        private double x;
        private double y;

        public Circle(double radius)
        {
            this.radius = radius;
            x = 0.0;
            y = 0.0;
        }

        public Circle(double radius, double x, double y) 
        {
            this.radius = radius;
            this.x = x;
            this.y = y;
        }

        override public string Discription()
        {
            return string.Format("Circle: \n Origin = ({0},{1}), Radius = {2}", x, y, radius);
        }
    }


    class Triangle : Shape
    {
        override public string Discription()
        {
            return "Triangle";
        }
    }
}
