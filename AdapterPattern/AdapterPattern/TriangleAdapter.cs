using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class TriangleAdapter : IShape
    {
        private Triangle _triangle;

        public TriangleAdapter(Triangle triangle)
        {
            _triangle = triangle;
        }

        public string Name => "Triangle";

        public double Area => _triangle.Base * _triangle.Heigth / 2.0;
    }
}
