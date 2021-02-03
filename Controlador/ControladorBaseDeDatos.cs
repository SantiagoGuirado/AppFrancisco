using System;
using System.Data;
using AppFrancisco.Modelo;

namespace AppFrancisco.Controlador
{
    public class ControladorBaseDeDatos
    {
        //Atributos
        private DataSet dataSet;
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
            _dataSet = _consultasSelect._dataSet;
            return _bandera;
        }


        //Setters && Getters
        internal Conexion _conexion { get => conexion; set => conexion = value; }
        public DataSet _dataSet { get => dataSet; set => dataSet = value; }
        public Select _consultasSelect { get => consultasSelect; set => consultasSelect = value; }
        public bool _bandera { get => bandera; set => bandera = value; }
    }
}
