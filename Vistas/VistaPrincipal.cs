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
        AgregarNuevoCliente agregarNuevoCliente;

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
            _agregarNuevoCliente = new AgregarNuevoCliente();
            _dataTable = _controladorBaseDeDatos._dataTable;
            dataGridView1.DataSource = _dataTable;
        }

        //Este metodo realiza las consultas para no tenesr que repetir las mismas lineas en multiples
        //metodos
        public void realizarConsultaSelect(int numeroConsulta)
        {
            if (!_controladorBaseDeDatos.realizarConsultaSelect(numeroConsulta))
            {
                _errorConexionDataBase1.ShowDialog(this);
            }
        }

        public void realizarConsultaInsert(int dni, String nombre, int numTelefono)
        {
            if (!_controladorBaseDeDatos.realizarConsultaInsert(dni, nombre, numTelefono))
            {
                _errorConexionDataBase1.ShowDialog(this);
            }
        }

        //Eventos que utilizan consultas SELECT
        private void menuVerClientes_Click(object sender, EventArgs e)
        {
            realizarConsultaSelect(1);
        }

        private void menuVerMarcasTelefonos_Click(object sender, EventArgs e)
        {
            realizarConsultaSelect(2);
        }

        private void menuVerModelosTelefonos_Click(object sender, EventArgs e)
        {
            if (_controladorBaseDeDatos.realizarConsultaSelect(2))
            {
                _elegirMarca._dataTable = _controladorBaseDeDatos._dataTable;
                _elegirMarca.cargarComboBox();
                _elegirMarca.ShowDialog(this);
                if (!_controladorBaseDeDatos.realizarConsultaSelect(3, _elegirMarca._marcaSeleccionada))
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
            realizarConsultaSelect(4);
        }

        private void menuVerTrabajosRealizados_Click(object sender, EventArgs e)
        {
            realizarConsultaSelect(5);
        }

        //Eventos que utilizan consultas INSERT INTO
        private void menuAgregarNuevoCliente_Click(object sender, EventArgs e)
        {
            _agregarNuevoCliente.ShowDialog(this);
            realizarConsultaInsert(_agregarNuevoCliente._dni, _agregarNuevoCliente._nombre,
                _agregarNuevoCliente._telefono);

        }

        //Setters && Getters
        public ControladorBaseDeDatos _controladorBaseDeDatos { get => controladorBaseDeDatos; set => controladorBaseDeDatos = value; }
        public ErrorConexionBaseDeDatos _errorConexionDataBase1 { get => errorConexionDataBase; set => errorConexionDataBase = value; }
        public ElegirMarca _elegirMarca { get => elegirMarca; set => elegirMarca = value; }
        public DataTable _dataTable { get => dataTable; set => dataTable = value; }
        public AgregarNuevoCliente _agregarNuevoCliente { get => agregarNuevoCliente; set => agregarNuevoCliente = value; }
    }
}