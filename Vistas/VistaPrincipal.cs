using System;
using System.Data;
using System.Windows.Forms;
using AppFrancisco.Controlador;

namespace AppFrancisco
{
    public partial class Form1 : Form
    {
        //Atributos
        ControladorBaseDeDatos controladorBaseDeDatos;
        DataSet dataSet;
        ErrorConexionBaseDeDatos ErrorConexionDataBase;

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

        //Setters && Getters
        public ControladorBaseDeDatos _controladorBaseDeDatos { get => controladorBaseDeDatos; set => controladorBaseDeDatos = value; }
        public ErrorConexionBaseDeDatos _errorConexionDataBase1 { get => ErrorConexionDataBase; set => ErrorConexionDataBase = value; }
    }
}