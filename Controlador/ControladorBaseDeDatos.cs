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
        }

        public Boolean verClientes()
        {
            _conexion.establecerConexion();
            _consultasSelect.carcarConsultaSQL(1);
            _bandera = _consultasSelect.realizarConsulta(_conexion._conexion);
            _dataTable = _consultasSelect._dataTable;
            return _bandera;
        }

        public Boolean verMarcasTelefonos()
        {
            _conexion.establecerConexion();
            _consultasSelect.carcarConsultaSQL(2);
            _bandera = _consultasSelect.realizarConsulta(_conexion._conexion);
            _dataTable = _consultasSelect._dataTable;
            return _bandera;
        }

        public Boolean cargarComboBoxMarcas()
        {
            _conexion.establecerConexion();
            _consultasSelect.carcarConsultaSQL(2);
            _bandera = _consultasSelect.realizarConsulta(_conexion._conexion);
            _dataTable = _consultasSelect._dataTable;
            return _bandera;
        }

        public Boolean cargarModelosTelefonos(int marcaSeleccionada)
        {
            _conexion.establecerConexion();
            _consultasSelect._idMarca = marcaSeleccionada;
            _consultasSelect.carcarConsultaSQL(3);
            _bandera = _consultasSelect.realizarConsulta(_conexion._conexion);
            _dataTable = _consultasSelect._dataTable;
            return _bandera;
        }


        //Setters && Getters
        internal Conexion _conexion { get => conexion; set => conexion = value; }
        public DataTable _dataTable { get => dataTable; set => dataTable = value; }
        public Select _consultasSelect { get => consultasSelect; set => consultasSelect = value; }
        public bool _bandera { get => bandera; set => bandera = value; }
    }
}
