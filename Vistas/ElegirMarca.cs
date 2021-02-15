using System;
using System.Data;
using System.Windows.Forms;

namespace AppFrancisco.Vistas
{
    public partial class ElegirMarca : Form
    {
        //Atributos
        private DataTable dataTable;
        private int marcaSeleccionada;

        //Constructor
        public ElegirMarca()
        {
            InitializeComponent();
        }

        //Metodos
        public void cargarComboBox()
        {
            cbMarcasCelulares.DataSource = _dataTable;
            cbMarcasCelulares.ValueMember = "IdMarca";
            cbMarcasCelulares.DisplayMember = "NombreMarca";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _marcaSeleccionada = Convert.ToInt32(cbMarcasCelulares.SelectedIndex.ToString()) + 1;
            this.Close();
        }

        //Setters && Getters
        public int _marcaSeleccionada { get => marcaSeleccionada; set => marcaSeleccionada = value; }
        public DataTable _dataTable { get => dataTable; set => dataTable = value; }
    }
}