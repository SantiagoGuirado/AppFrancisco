using System;
using System.Data;
using System.Data.SQLite;

namespace AppFrancisco.Modelo
{
    public class Select
    {
        //Atributos
        private string consultaSQL;
        private SQLiteDataAdapter adaptador;
        private DataTable dataTable;

        //Constructor
        public Select()
        {
            implementarElementos();
        }

        //Metodos
        public void implementarElementos()
        {
            _dataTable = new DataTable();
        }

        public void carcarConsultaSQL(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    _consultaSQL = "SELECT * FROM Cliente";
                    break;
                case 2:
                    _consultaSQL = "SELECT * FROM MarcasTelefonos;";
                    break;
                case 3:
                    _consultaSQL = "SELECT IdMarca, NombreMarca FROM MarcasTelefonos;";
                    break;
            }
        }

        public Boolean realizarConsulta(SQLiteConnection conexion)
        {
            Boolean bandera = true;
            try
            {
                _dataTable.Rows.Clear();
                _dataTable.Columns.Clear();
                conexion.Open();
                _adaptador = new SQLiteDataAdapter(_consultaSQL, conexion);
                _adaptador.Fill(_dataTable);
                conexion.Close();
            }
            catch (SQLiteException e)
            {
                bandera = false;
            }

            return bandera;
        }

        //Setters && Getters
        public string _consultaSQL { get => consultaSQL; set => consultaSQL = value; }
        public SQLiteDataAdapter _adaptador { get => adaptador; set => adaptador = value; }
        public DataTable _dataTable { get => dataTable; set => dataTable = value; }
    }
}