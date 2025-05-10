using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using GYM_Proyecto2_Forms_Ext.Models;
using GYM_Proyecto2_Forms_Ext.Data;
using GYM_Proyecto2_Forms_Ext.Service;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_Proyecto2_Forms_Ext.Services
{
    public class InstructorService
    {
        private readonly DatabaseManager _db;

        public InstructorService(DatabaseManager db)
        {
            _db = db;
        }

        public List<Instructor> ObtenerTodos()
        {
            var lista = new List<Instructor>();
             var conn = _db.GetNewConnection();
            conn.Open();

             var cmd = new SqlCommand("SELECT * FROM Instructores", conn);
             var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Instructor
                {
                    ID_Instructor = Convert.ToInt32(reader["ID_Instructor"]),
                    Nombre = reader["Nombre"].ToString(),
                    Apellido = reader["Apellido"].ToString(),
                    Especialidad = reader["Especialidad"].ToString()
                });
            }

            return lista;
        }

        public void Crear(Instructor ins)
        {
             var conn = _db.GetNewConnection();
            conn.Open();

            var cmd = new SqlCommand("INSERT INTO Instructores (Nombre, Apellido, Especialidad) VALUES (@nom, @ape, @esp)", conn);
            cmd.Parameters.AddWithValue("@nom", ins.Nombre);
            cmd.Parameters.AddWithValue("@ape", ins.Apellido);
            cmd.Parameters.AddWithValue("@esp", ins.Especialidad);
            cmd.ExecuteNonQuery();
        }

        public void Actualizar(Instructor ins)
        {
             var conn = _db.GetNewConnection();
            conn.Open();

            var cmd = new SqlCommand(
                "UPDATE Instructores SET Nombre = @nom, Apellido = @ape, Especialidad = @esp WHERE ID_Instructor = @id",
                conn);

            cmd.Parameters.AddWithValue("@nom", ins.Nombre);
            cmd.Parameters.AddWithValue("@ape", ins.Apellido);
            cmd.Parameters.AddWithValue("@esp", ins.Especialidad);
            cmd.Parameters.AddWithValue("@id", ins.ID_Instructor);

            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int id)
        {
             var conn = _db.GetNewConnection();
            conn.Open();

            var cmd = new SqlCommand("DELETE FROM Instructores WHERE ID_Instructor = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}