using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using GYM_Proyecto2_Forms_Ext.Models;
using GYM_Proyecto2_Forms_Ext.Data;

namespace GYM_Proyecto2_Forms_Ext.Service
{
    public class MiembroService
    {
        private readonly DatabaseManager _db;

        public MiembroService(DatabaseManager db)
        {
            _db = db;
        }


        public List<Miembro> ObtenerTodos()
        {
            var lista = new List<Miembro>();
             var conn = _db.GetNewConnection();
            conn.Open();
            var cmd = new SqlCommand("SELECT * FROM Miembros", conn);
             var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Miembro
                {
                    ID_Miembro = Convert.ToInt32(reader["ID_Miembro"]),
                    Nombre = reader["Nombre"].ToString(),
                    Apellido = reader["Apellido"].ToString(),
                    Email = reader["Email"].ToString(),
                    Telefono = reader["Telefono"].ToString(),
                    FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"])
                });
            }

            return lista;
        }
        public List<Miembro> BuscarPorNombre(string nombre)
        {
            var resultado = new List<Miembro>();
            var conn = _db.GetNewConnection();
            conn.Open();

            var cmd = new SqlCommand("SELECT * FROM Miembros WHERE Nombre LIKE @nombre OR Apellido LIKE @nombre", conn);
            cmd.Parameters.AddWithValue("@nombre", $"%{nombre}%");

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                resultado.Add(new Miembro
                {
                    ID_Miembro = Convert.ToInt32(reader["ID_Miembro"]),
                    Nombre = reader["Nombre"].ToString(),
                    Apellido = reader["Apellido"].ToString(),
                    FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]),
                    Email = reader["Email"].ToString(),
                    Telefono = reader["Telefono"].ToString()
                });
            }

            return resultado;
        }



        public void AgregarMiembro(Miembro miembro)
        {
            var conn = _db.GetNewConnection();
            conn.Open();

            var cmd = new SqlCommand(
                "INSERT INTO Miembros (Nombre, Apellido, FechaNacimiento, Email, Telefono) VALUES (@Nombre, @Apellido, @FechaNacimiento, @Email, @Telefono)",
                conn);

            cmd.Parameters.AddWithValue("@Nombre", miembro.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", miembro.Apellido);
            cmd.Parameters.AddWithValue("@FechaNacimiento", miembro.FechaNacimiento);
            cmd.Parameters.AddWithValue("@Email", miembro.Email);
            cmd.Parameters.AddWithValue("@Telefono", miembro.Telefono);

            cmd.ExecuteNonQuery();
        }

        public void ActualizarMiembro(Miembro miembro)
        {
            using (var conn = _db.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("UPDATE Miembros SET Nombre = @Nombre, Apellido = @Apellido, FechaNacimiento = @FechaNacimiento, Email = @Email, Telefono = @Telefono WHERE ID_Miembro = @ID", conn);
                cmd.Parameters.AddWithValue("@Nombre", miembro.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", miembro.Apellido);
                cmd.Parameters.AddWithValue("@FechaNacimiento", miembro.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Email", miembro.Email);
                cmd.Parameters.AddWithValue("@Telefono", miembro.Telefono);
                cmd.Parameters.AddWithValue("@ID", miembro.ID_Miembro);
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
             var conn = _db.GetNewConnection(); 
            conn.Open();

            var cmd = new SqlCommand("DELETE FROM Miembros WHERE ID_Miembro = @ID", conn);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.ExecuteNonQuery();
        }
    }
}
