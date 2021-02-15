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
        private int idMarca;

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
                    _consultaSQL = "SELECT Telefono.IdTelefono, MarcasTelefonos.NombreMarca, " +
                        "Telefono.Modelo, Telefono.Descripcion FROM Telefono INNER JOIN MarcasTelefonos " +
                        "ON Telefono.IdMarca = MarcasTelefonos.IdMarca WHERE " +
                        "MarcasTelefonos.IdMarca = " + _idMarca + ";";
                    break;
                case 4:
                    _consultaSQL = "SELECT * FROM Servicios;";
                    break;
                case 5:
                    _consultaSQL = "SELECT TrabajoRealizado.IdTrabajosRealizados, Cliente.Dni, " +
                        "Cliente.Nombre, Servicios.NombreServicio, MarcasTelefonos.NombreMarca, " +
                        "Telefono.Modelo, TrabajoRealizado.Fecha, TrabajoRealizado.Precio, " +
                        "TrabajoRealizado.Descripcion FROM TrabajoRealizado INNER JOIN Cliente ON " +
                        "TrabajoRealizado.Dni = Cliente.Dni INNER JOIN Servicios ON " +
                        "TrabajoRealizado.IdServicios = Servicios.IdServicio INNER JOIN Telefono ON " +
                        "TrabajoRealizado.IdTelefono = Telefono.IdTelefono INNER JOIN MarcasTelefonos " +
                        "ON Telefono.IdMarca = MarcasTelefonos.IdMarca; ";
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
        public int _idMarca { get => idMarca; set => idMarca = value; }
    }
}