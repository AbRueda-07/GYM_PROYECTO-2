using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using GYM_Proyecto2_Forms_Ext.Models;
using GYM_Proyecto2_Forms_Ext.Data;

namespace GYM_Proyecto2_Forms_Ext.Services
{
    public class MembresiaService
    {
        private readonly DatabaseManager _db;

        public MembresiaService(DatabaseManager db)
        {
            _db = db;
        }

        public List<Membresia> ObtenerTodos()
        {
            var lista = new List<Membresia>();

            var conn = _db.GetNewConnection(); 
            conn.Open();

             var cmd = new SqlCommand("SELECT * FROM Membresias", conn);
             var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Membresia
                {
                    ID_Membresia = Convert.ToInt32(reader["ID_Membresia"]),
                    TipoMembresia = reader["TipoMembresia"].ToString(),
                    Precio = Convert.ToDecimal(reader["Precio"]),
                    FechaInicio = Convert.ToDateTime(reader["FechaInicio"]),
                    FechaFin = Convert.ToDateTime(reader["FechaFin"])
                });
            }

            return lista;
        }

        public void Crear(Membresia membresia)
        {
            var conn = _db.GetConnection();
            var cmd = new SqlCommand("INSERT INTO Membresias (TipoMembresia, Precio, FechaInicio, FechaFin) VALUES (@tipo, @precio, @inicio, @fin)", conn);
            cmd.Parameters.AddWithValue("@tipo", membresia.TipoMembresia);
            cmd.Parameters.AddWithValue("@precio", membresia.Precio);
            cmd.Parameters.AddWithValue("@inicio", membresia.FechaInicio);
            cmd.Parameters.AddWithValue("@fin", membresia.FechaFin);
            cmd.ExecuteNonQuery();
        }

        public void Actualizar(Membresia membresia)
        {
            var conn = _db.GetConnection();
            var cmd = new SqlCommand("UPDATE Membresias SET TipoMembresia=@tipo, Precio=@precio, FechaInicio=@inicio, FechaFin=@fin WHERE ID_Membresia=@id", conn);
            cmd.Parameters.AddWithValue("@tipo", membresia.TipoMembresia);
            cmd.Parameters.AddWithValue("@precio", membresia.Precio);
            cmd.Parameters.AddWithValue("@inicio", membresia.FechaInicio);
            cmd.Parameters.AddWithValue("@fin", membresia.FechaFin);
            cmd.Parameters.AddWithValue("@id", membresia.ID_Membresia);
            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int id)
        {
            var conn = _db.GetConnection();
            var cmd = new SqlCommand("DELETE FROM Membresias WHERE ID_Membresia=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}