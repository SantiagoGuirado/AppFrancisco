using System;
using System.Data.SQLite;

namespace AppFrancisco.Modelo
{
    class Insert
    {
        //Atributos
        private string consultaSQL;
        private SQLiteCommand comando;

        //Constructor

        //Metodos
        public void cargarConsultaSQL(int dni, String nombre, Int64 numTelefono)
        {
            _consultaSQL = "INSERT INTO Cliente(Dni, Nombre, NumeroTelefono) VALUES (" + dni + ", '" +
                nombre + "', " + numTelefono + ");";
        }

        public Boolean realizarConsulta(SQLiteConnection conexion)
        {
            Boolean bandera = true;
            try
            {
                conexion.Open();
                _comando = new SQLiteCommand(_consultaSQL, conexion);
                _comando.ExecuteNonQuery();
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
        public SQLiteCommand _comando { get => comando; set => comando = value; }
    }
}