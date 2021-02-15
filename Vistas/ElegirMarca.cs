using System;
using System.Data;
using System.Windows.Forms;

namespace AppFrancisco.Vistas
{
    public partial class ElegirMarca : Form
    {
        //Atributos
        private Boolean bandera;
        private int marcaSeleccionada;

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _bandera = true;
            _marcaSeleccionada = Convert.ToInt32(cbMarcasCelulares.SelectedIndex.ToString());
            this.Close();
        }

        //Setters && Getters
        public bool _bandera { get => bandera; set => bandera = value; }
        public int _marcaSeleccionada { get => marcaSeleccionada; set => marcaSeleccionada = value; }

    }
}