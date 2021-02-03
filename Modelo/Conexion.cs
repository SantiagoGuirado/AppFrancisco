using System.Data.SQLite;


namespace AppFrancisco.Modelo
{
    public class Conexion
    {
        //Atributos
        private string rutaDeConexion;
        private SQLiteConnection conexion;

        //Metodos
        public void establecerConexion()
        {
            _rutaDeConexion = "Data Source=BaseDeDatosFran.db;";
            _conexion = new SQLiteConnection(_rutaDeConexion);
        }

        //Setters && Getters
        public string _rutaDeConexion { get => rutaDeConexion; set => rutaDeConexion = value; }
        public SQLiteConnection _conexion { get => conexion; set => conexion = value; }
    }
}