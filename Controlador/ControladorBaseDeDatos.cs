using System;
using System.Data;
using AppFrancisco.Modelo;

namespace AppFrancisco.Controlador
{
    public class ControladorBaseDeDatos
    {
        //Atributos
        private DataTable dataTable;
        private Boolean bandera;

        private Conexion conexion;
        Select consultasSelect;

        //Constructor
        public ControladorBaseDeDatos()
        {
            implementarElementos();
        }

        //Metodos
        public void implementarElementos()
        {
            _conexion = new Conexion();
            _consultasSelect = new Select();
            _dataTable = _consultasSelect._dataTable;
        }

        public void realizarConsulta(int numeroConsulta)
        {
            _conexion.establecerConexion();
            _consultasSelect.carcarConsultaSQL(numeroConsulta);
            _bandera = _consultasSelect.realizarConsulta(_conexion._conexion);
        }

        public Boolean verClientes()
        {
            realizarConsulta(1);
            return _bandera;
        }

        public Boolean verMarcasTelefonos()
        {
            realizarConsulta(2);
            return _bandera;
        }

        public Boolean cargarModelosTelefonos(int marcaSeleccionada)
        {
            _consultasSelect._idMarca = marcaSeleccionada;
            realizarConsulta(3);
            return _bandera;
        }

        //Setters && Getters
        internal Conexion _conexion { get => conexion; set => conexion = value; }
        public DataTable _dataTable { get => dataTable; set => dataTable = value; }
        public Select _consultasSelect { get => consultasSelect; set => consultasSelect = value; }
        public bool _bandera { get => bandera; set => bandera = value; }
    }
}