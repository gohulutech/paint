using Presentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Launcher
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Modelo modelo = new Modelo();
            modelo.IniciarVista();

            Console.ReadKey();
        }
    }
}
