using System;
using System.Collections;
using System.Collections.Generic;
namespace Interfacetest
{
    public class ShapeCollection:IEnumerable<Shape>
    {
        List<Shape> _Shapes;
        int _Count;
        public ShapeCollection()
        {
            _Shapes = new List<Shape>();
            _Count = 0;

        }
        public IEnumerator<Shape> GetEnumerator()
        {
            foreach (Shape s in _Shapes) { yield return s; }
        }
        IEnumerator IEnumerable.GetEnumerator() { return _Shapes.GetEnumerator(); }
        public Circle GetCircle(int Index) { return (Circle)_Shapes[Index]; }
        public Rect GetRect(int Index) { return (Rect)_Shapes[Index]; }
        public void Add(Shape Shape) { _Shapes.Add(Shape);}
        public void RemoveAt(int Index) {  _Shapes.RemoveAt(Index); }
        public Shape this[int Index] {
            get => _Shapes[Index];
            set => _Shapes[Index] = value;
        }
        public int Length { get => _Shapes.Count; }
        
        
    }
}
