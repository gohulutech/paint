using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    public delegate void OnSumar();

    public partial class Vista : Form
    {

        public event OnSumar OnSumar;

        public Vista()
        {
            InitializeComponent();
        }

        public static Vista MostrarVista()
        {
            Vista vista = new Vista();
            return vista;
        }

        public string GetValor1()
        {
            return this.txtValor1.Text;
        }

        public string GetValor2()
        {
            return this.txtValor2.Text;
        }

        public void SetResultado(string resultado)
        {
            this.lblResultado.Text = resultado;
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            OnSumar?.Invoke();
        }
    }
}
