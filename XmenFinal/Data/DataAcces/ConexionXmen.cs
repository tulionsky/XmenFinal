using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmenFinal.Data.DataAcces
{
    internal class ConexionXmen
    {
        private string connectionString = "Server=localhost;Database=db_xmen;Uid=root;Pwd=Alejandro2005#";
        // PROBAR CONEXION ENTRE VS Y WORKBENCH
        public bool ProbarConexion()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public DataTable LeerPersonajes()
        {
            DataTable personajes = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM personajes_dragon_ball";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(personajes);
                    }
                }
            }

            return personajes;
        }

    }
}
