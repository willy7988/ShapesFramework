using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesFramework
{
    class ShapeManager
    {
        private int counter;

        private static ShapeManager _instance;
        public static ShapeManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ShapeManager();
                return _instance;
            }
        }

        private ShapeManager()
        {
            counter = 0;
        }

        public void DoWork()
        {
            System.Console.WriteLine("You've done it " + (++counter) + " times.");
        }
    }
}
