using System;
using System.Data;
using System.Windows.Forms;

namespace AppFrancisco.Vistas
{
    public partial class ElegirMarca : Form
    {
        //Constructor
        public ElegirMarca()
        {
            InitializeComponent();
        }

        //Metodos
        public void cargarComboBox(DataTable marcas)
        {
            cbMarcasCelulares.DataSource = marcas;
            cbMarcasCelulares.ValueMember = "IdMarca";
            cbMarcasCelulares.DisplayMember = "NombreMarca";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}