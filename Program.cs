using System;
using System.Collections.Generic;

namespace Interfacetest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n\n\n");
            var r = new Rect(10, 10,1,3);
            var C = new Circle(10, 10,2);
            
            
           

            ShapeCollection Shapes = new ShapeCollection();
            Shapes.Add(r);
            Shapes.Add(C);
            Shapes.Add(new Circle(3,5,8));
            Shapes.Add(new TestShape(1, 12));
            Shapes.GetCircle(1).UpdateRadius(5);
            Console.WriteLine(Shapes[1].Describe());
            Console.WriteLine("\nTest ShapeColection");
            for (int i = 0; i < Shapes.Length; i++)
            {
                Console.WriteLine(Shapes[i].Describe());
            }
            //

        }
    }
}
