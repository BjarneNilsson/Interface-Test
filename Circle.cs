using System;
namespace Interfacetest
{
    public class Circle:Shape, IDesc
    {
        
        double _Radius;
        Double _Area = 0;
        public Circle(int X, int Y, double Radius):base(X,Y)
        {
            UpdateRadius(Radius);   

            
        }
        public void UpdateRadius(double Radius) {
            _Radius = Radius;
           _Area = Math.PI * Math.Pow(Radius, 2); }
        public double Area()
        {
            return _Area;
        }
        public override string Describe()
        {
            return CostunDesc( "  my raduis is "+ _Radius +" and my area is : " + Area().ToString()) ;
        }
    }
}
