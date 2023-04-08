using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class CircleAdapter : IShape
    {
        private readonly Circle _circle;

        public CircleAdapter(Circle circle) 
        { 
            _circle= circle;
        }

        public string Name => "Circle";

        public double Area => Math.PI * _circle.Radius * _circle.Radius;
    }
}
