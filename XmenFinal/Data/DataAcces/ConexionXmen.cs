﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XmenFinal.Data.Models;

namespace XmenFinal.Data.DataAcces
{
    internal class ConexionXmen
    {
        private string connectionString = "Server=localhost;Database=db_xmen;Uid=root;Pwd=Alejandro2005#";
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

                string sql = "select * from xmen_lista";
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

        public void Insertar(usuario usr)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))

                try
                {
                string query = "INSERT INTO xmen_lista (nombre, edad, mutante, poder, nivel_mutacion, grupo) VALUES (@nombre, @edad, @mutante, @poder, @nivel_mutacion, @grupo)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nombre", usr.Nombre);
                cmd.Parameters.AddWithValue("@edad", usr.Edad);
                cmd.Parameters.AddWithValue("@mutante", usr.Mutante);
                cmd.Parameters.AddWithValue("@poder", usr.Poder);
                cmd.Parameters.AddWithValue("@nivel_mutacion", usr.Nivel_Mutacion);
                cmd.Parameters.AddWithValue("@grupo", usr.Grupo);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el registro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public List<usuario> ObtenerTodosLosUsuarios()
        {
            List<usuario> usuarios = new List<usuario>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM xmen_lista";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        usuario nuevoUsuario = new usuario(
                            reader.GetInt32(reader.GetOrdinal("id")),
                            reader.GetString(reader.GetOrdinal("nombre")),
                            reader.GetInt32(reader.GetOrdinal("edad")),
                            reader.GetBoolean(reader.GetOrdinal("mutante")),
                            reader.GetString(reader.GetOrdinal("poder")),
                            reader.GetString(reader.GetOrdinal("nivel_mutacion")),
                            reader.GetString(reader.GetOrdinal("grupo"))
                            );

                        usuarios.Add(nuevoUsuario);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return usuarios;
        }

    }
}
