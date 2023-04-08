using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class SquareAdapter : IShape
    {
        private Square _square;

        public SquareAdapter(Square square)
        {
            _square = square;
        }

        public string Name => "Square";

        public double Area => _square.SideLength * _square.SideLength;
    }
}
