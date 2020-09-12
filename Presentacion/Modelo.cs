using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaces;
using Logica;


namespace Presentacion
{
    public class Modelo : ApplicationContext
    {
        private Sistema _sistema;
        private Vista vista;
        
        public Modelo()
        {
            vista = Vista.GetVista();
            vista.Show();
            vista.OnSumar += Vista_OnSumar;
        }

        private void Vista_OnSumar()
        {
            GeneraSuma();
        }

        private void GeneraSuma()
        {
            _sistema = new Sistema();
            int _resultado;

            try
            {
                _sistema._valor1 = Convert.ToInt32(vista.GetValor1());
                _sistema._valor2 = Convert.ToInt32(vista.GetValor2());
                _resultado = _sistema.sumar();

                vista.SetResultado("EL RESULTADO ES: " + _resultado.ToString());
            }
            catch
            {
                vista.SetResultado("VALORES INCORRECTOS");
            }
        }
    }
}
