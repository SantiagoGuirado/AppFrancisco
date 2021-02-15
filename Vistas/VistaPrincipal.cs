using System;
using System.Data;
using System.Windows.Forms;
using AppFrancisco.Controlador;
using AppFrancisco.Vistas;

namespace AppFrancisco
{
    public partial class Form1 : Form
    {
        //Atributos
        ControladorBaseDeDatos controladorBaseDeDatos;
        DataTable dataTable;
        ErrorConexionBaseDeDatos errorConexionDataBase;
        ElegirMarca elegirMarca;

        public Form1()
        {
            InitializeComponent();
            implementarElementos();
        }

        //Metodos
        public void implementarElementos()
        {
            _controladorBaseDeDatos = new ControladorBaseDeDatos();
            _errorConexionDataBase1 = new ErrorConexionBaseDeDatos();
            _elegirMarca = new ElegirMarca();
            _dataTable = _controladorBaseDeDatos._dataTable;
            dataGridView1.DataSource = _dataTable;
        }

        private void menuVerClientes_Click(object sender, EventArgs e)
        {
            if (!_controladorBaseDeDatos.realizarConsulta(1))
            {
                _errorConexionDataBase1.ShowDialog(this);
            }
        }

        private void menuVerMarcasTelefonos_Click(object sender, EventArgs e)
        {
            if (!_controladorBaseDeDatos.realizarConsulta(2))
            {
                _errorConexionDataBase1.ShowDialog(this);
            }
        }

        private void menuVerModelosTelefonos_Click(object sender, EventArgs e)
        {
            if (_controladorBaseDeDatos.realizarConsulta(2))
            {
                _elegirMarca._dataTable = _controladorBaseDeDatos._dataTable;
                _elegirMarca.cargarComboBox();
                _elegirMarca.ShowDialog(this);
                if (!_controladorBaseDeDatos.realizarConsulta(3, _elegirMarca._marcaSeleccionada))
                {
                    _errorConexionDataBase1.ShowDialog(this);
                }
            }
            else
            {
                _errorConexionDataBase1.ShowDialog(this);
            }
        }

        private void menuVerServiciosOfrecidos_Click(object sender, EventArgs e)
        {
            if (!_controladorBaseDeDatos.realizarConsulta(4))
            {
                _errorConexionDataBase1.ShowDialog(this);
            }
        }

        //Setters && Getters
        public ControladorBaseDeDatos _controladorBaseDeDatos { get => controladorBaseDeDatos; set => controladorBaseDeDatos = value; }
        public ErrorConexionBaseDeDatos _errorConexionDataBase1 { get => errorConexionDataBase; set => errorConexionDataBase = value; }
        public ElegirMarca _elegirMarca { get => elegirMarca; set => elegirMarca = value; }
        public DataTable _dataTable { get => dataTable; set => dataTable = value; }
    }
}