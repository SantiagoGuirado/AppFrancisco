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
        DataSet dataSet;
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
        }

        private void menuVerClientes_Click(object sender, EventArgs e)
        {
            if (_controladorBaseDeDatos.verClientes())
            {
                dataSet = _controladorBaseDeDatos._dataSet;
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            else
            {
                _errorConexionDataBase1.ShowDialog(this);
            }
        }

        private void menuVerMarcasTelefonos_Click(object sender, EventArgs e)
        {
            if (_controladorBaseDeDatos.verMarcasTelefonos())
            {
                dataSet = _controladorBaseDeDatos._dataSet;
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            else
            {
                _errorConexionDataBase1.ShowDialog(this);
            }
        }

        private void menuVerModelosTelefonos_Click(object sender, EventArgs e)
        {
            _elegirMarca.ShowDialog(this);
        }

        //Setters && Getters
        public ControladorBaseDeDatos _controladorBaseDeDatos { get => controladorBaseDeDatos; set => controladorBaseDeDatos = value; }
        public ErrorConexionBaseDeDatos _errorConexionDataBase1 { get => errorConexionDataBase; set => errorConexionDataBase = value; }
        public ElegirMarca _elegirMarca { get => elegirMarca; set => elegirMarca = value; }
    }
}