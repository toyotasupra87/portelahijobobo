using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Cuadrado : Figura
    {
        public override float Area() 
        {
            return (Base * Base);
        }
        public override float Perimetro()
        {
            return Base * 4;
        }
    
    }
}
