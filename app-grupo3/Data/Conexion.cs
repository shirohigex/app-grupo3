using MySql.Data.MySqlClient;

namespace app_grupo3.Data
{
    public class Conexion
    {
        private MySqlConnection cnx = new MySqlConnection("");

        public MySqlConnection Conectar
        {
            get { return cnx; }
        }
        public void Desconectar()
        {
            cnx.Close();
        }
    }
}
