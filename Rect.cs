using System;
namespace Interfacetest
{
    public class Rect: Shape,IDesc
    {
        
         float _Width, _Height;
        public Rect(int X,int Y ,int Width, int Hieght):base(X,Y)
        {

            
            _Width = Width;
            _Height = Hieght;
        }
        public float Area { get{ return _Width * _Height; } }
        public override string Describe() { return CostunDesc(" 1'm "+ _Width + " units wide, " + _Height + " units high and my area is " + Area); }
    }
}
