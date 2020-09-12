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
    public class Modelo
    {
        private Sistema _sistema;
        private Vista vista;
        private string v1;
        private string v2;

        public string _V1 { get => v1; set => v1 = value; }
        public string _V2 { get => v2; set => v2 = value; }
        
        public Modelo()
        {
            vista = Factory.GetVista();
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

        public void IniciarVista()
        {
            vista.Show();
            vista.OnSumar += Vista_OnSumar;
        }
    }
}
