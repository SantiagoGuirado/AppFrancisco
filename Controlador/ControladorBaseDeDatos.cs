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
        private Select consultasSelect;
        private Insert consultasInsert;

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
            _consultasInsert = new Insert();
            _dataTable = _consultasSelect._dataTable;
        }

        public Boolean realizarConsultaSelect(int numeroConsulta)
        {
            _conexion.establecerConexion();
            _consultasSelect.carcarConsultaSQL(numeroConsulta);
            _bandera = _consultasSelect.realizarConsulta(_conexion._conexion);
            return _bandera;
        }

        public Boolean realizarConsultaSelect(int numeroConsulta, int marcaSeleccionada)
        {
            _conexion.establecerConexion();
            _consultasSelect._idMarca = marcaSeleccionada;
            _consultasSelect.carcarConsultaSQL(numeroConsulta);
            _bandera = _consultasSelect.realizarConsulta(_conexion._conexion);
            return _bandera;
        }

        public Boolean realizarConsultaInsert(int dni, String nombre, Int64 numTelefono)
        {
            _conexion.establecerConexion();
            _consultasInsert.cargarConsultaSQL(dni, nombre, numTelefono);
            _bandera = _consultasInsert.realizarConsulta(_conexion._conexion);
            return _bandera;
        }

        //Setters && Getters
        internal Conexion _conexion { get => conexion; set => conexion = value; }
        public DataTable _dataTable { get => dataTable; set => dataTable = value; }
        public Select _consultasSelect { get => consultasSelect; set => consultasSelect = value; }
        public bool _bandera { get => bandera; set => bandera = value; }
        internal Insert _consultasInsert { get => consultasInsert; set => consultasInsert = value; }
    }
}