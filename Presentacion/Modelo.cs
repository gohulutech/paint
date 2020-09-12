using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;


namespace Presentacion
{

    public class Modelo
    {
        private Sistema _sistema;
        private string v1;
        private string v2;

        public string _V1 { get => v1; set => v1 = value; }
        public string _V2 { get => v2; set => v2 = value; }
        
        public string GeneraSuma()
        {
            _sistema = new Sistema();
            int _resultado;
            
            try
            {
                _sistema._valor1 = Convert.ToInt32(_V1);
                _sistema._valor2 = Convert.ToInt32(_V2);
                _resultado = _sistema.sumar();

                return "EL RESULTADO ES: " + _resultado.ToString();
            }
            catch
            {
                return "VALORES INCORRECTOS";
            }

        
        }

    }
}
