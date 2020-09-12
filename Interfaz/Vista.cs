using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion;

namespace Interfaz
{
    public partial class Vista : Form
    {
        Modelo _modelo;
        public Vista()
        {
            InitializeComponent();
        }


        private void btncalcular_Click(object sender, EventArgs e)
        {
            _modelo = new Modelo();
            _modelo._V1 = this.txtvalor1.Text;
            _modelo._V2 = this.txtvalor2.Text;
            this.lbresultado.Text = _modelo.GeneraSuma();
        }
    }
}
