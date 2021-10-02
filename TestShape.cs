using System;
namespace Interfacetest
{
    public class TestShape:Shape, IDesc
    {
        public TestShape(int X, int Y):base(X,Y)
        {
        }
    }
}
