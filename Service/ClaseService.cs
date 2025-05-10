using GYM_Proyecto2_Forms_Ext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using GYM_Proyecto2_Forms_Ext.Data;

namespace GYM_Proyecto2_Forms_Ext.Service
{
    public class ClaseService
    {
        private readonly DatabaseManager _db;

        public ClaseService(DatabaseManager db)
        {
            _db = db;
        }

        public List<Clase> ObtenerTodos()
        {
            var lista = new List<Clase>();

            var conn = _db.GetNewConnection();
            conn.Open();

            var cmd = new SqlCommand("SELECT * FROM Clases", conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Clase
                {
                    ID_Clase = Convert.ToInt32(reader["ID_Clase"]),
                    NombreClase = reader["NombreClase"].ToString(),
                    Horario = reader["Horario"].ToString(),
                    CapacidadMaxima = Convert.ToInt32(reader["CapacidadMaxima"])
                });
            }

            return lista;
        }

        public void Crear(Clase clase)
        {
             var conn = _db.GetNewConnection(); 
            conn.Open(); 

            var cmd = new SqlCommand(
                "INSERT INTO Clases (NombreClase, Horario, CapacidadMaxima) VALUES (@nombre, @horario, @cupo)",
                conn);

            cmd.Parameters.AddWithValue("@nombre", clase.NombreClase);
            cmd.Parameters.AddWithValue("@horario", clase.Horario);
            cmd.Parameters.AddWithValue("@cupo", clase.CapacidadMaxima);

            cmd.ExecuteNonQuery();
        }


        public void Actualizar(Clase clase)
        {
             var conn = _db.GetNewConnection(); 
            conn.Open();

            var cmd = new SqlCommand(
                "UPDATE Clases SET NombreClase = @nombre, Horario = @horario, CapacidadMaxima = @cupo WHERE ID_Clase = @id",
                conn);

            cmd.Parameters.AddWithValue("@nombre", clase.NombreClase);
            cmd.Parameters.AddWithValue("@horario", clase.Horario);
            cmd.Parameters.AddWithValue("@cupo", clase.CapacidadMaxima);
            cmd.Parameters.AddWithValue("@id", clase.ID_Clase);

            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int id)
        {
            var conn = _db.GetConnection();

            var cmd = new SqlCommand("DELETE FROM Clases WHERE ID_Clase = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }
    }
}
