using System;
using System.Collections.Generic;
namespace Interfacetest
{
    public class Shape:IDesc
    {
         int _X, _Y;
        public Shape(int X, int Y)
        {
            _X = X;
            _Y = Y;
        }
        public int GetX() { return _X; }
        public int GetY() { return _Y; }
        protected string CostunDesc(string TrailingMessage){
            return "Hello I'm a shape of the class " + GetFullObjectName() + " at " + GetX() + "," + GetY() + TrailingMessage;
        }
       
        
        public string GetFullObjectName()
        {
            return this.GetType().Namespace + "." + this.GetType().Name;
        }
        public virtual string Describe() { return CostunDesc(" Unfortunatly I cant't describe myself in any more detail"); }
    }
}
