using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Sistema
    {
        private int Valor1;
        private int Valor2;
        public int _valor1 { get => Valor1; set => Valor1 = value; }
        public int _valor2 { get => Valor2; set => Valor2 = value; }
        public int sumar()
        {
            int resultado = (_valor1 + _valor2);
            return resultado;
        }
    }


   
}
