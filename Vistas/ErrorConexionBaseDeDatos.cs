using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFrancisco
{
    public partial class ErrorConexionBaseDeDatos : Form
    {
        //Constructor
        public ErrorConexionBaseDeDatos()
        {
            InitializeComponent();
        }

        //Metodos
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReintentar_Click(object sender, EventArgs e)
        {

        }
    }
}
