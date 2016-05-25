using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probando
{
    public class Operacion
    {
        private int a, b;

        public Operacion ()
        {
           
        }

        public int Suma() { return a + b; }
        public int Resta1() { return a - b; }
        public int Resta2() { return b - a; }
        public void setA(int a1) { a = a1; }
        public void setB(int b1) { b = b1; }
        public bool Iguales(int a, int b) { if (a == b) return true;  return false; }
        public String Iguales(String a, String b) { if (a == b) return "Iguales";  return "Diferentes"; }

    }


}
