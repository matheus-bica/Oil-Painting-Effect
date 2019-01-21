using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoFPI
{
    class Retangulo
    {
        public int x;
        public int y;

        public Retangulo(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int getArea()
        {
            return this.x * this.y;
        }
    }
}
