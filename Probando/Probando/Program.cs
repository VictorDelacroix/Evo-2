using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probando
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Operacion ObjOperacion = new Operacion();

        }

        public bool Prueba1_Iguales_Suma(int a, int b, int REsperado)
        {
            Operacion ObjOperacion = new Operacion();
            ObjOperacion.setA(a); ObjOperacion.setB(b);
            if (ObjOperacion.Suma() == REsperado) return true; return false;
        }
    }
}
