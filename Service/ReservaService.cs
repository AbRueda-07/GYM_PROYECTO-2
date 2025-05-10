using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using GYM_Proyecto2_Forms_Ext.Models;
using GYM_Proyecto2_Forms_Ext.Data;

namespace GYM_Proyecto2_Forms_Ext.Service
{
    public class ReservaService
    {
        private readonly DatabaseManager _db;

        public ReservaService(DatabaseManager db)
        {
            _db = db;
        }

        public List<Reserva> ObtenerTodos()
        {
            var lista = new List<Reserva>();
            var conn = _db.GetNewConnection();
            conn.Open();

            var cmd = new SqlCommand("SELECT * FROM Reservas", conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Reserva
                {
                    ID_Reserva = Convert.ToInt32(reader["ID_Reserva"]),
                    ID_Miembro = Convert.ToInt32(reader["ID_Miembro"]),
                    ID_Clase = Convert.ToInt32(reader["ID_Clase"]),
                    FechaReserva = Convert.ToDateTime(reader["FechaReserva"])
                });
            }

            return lista;
        }

        public void Crear(Reserva reserva)
        {
            var conn = _db.GetNewConnection();
            conn.Open();

            var cmd = new SqlCommand(
                "INSERT INTO Reservas (ID_Miembro, ID_Clase, FechaReserva) VALUES (@miembro, @clase, @fecha)",
                conn);

            cmd.Parameters.AddWithValue("@miembro", reserva.ID_Miembro);
            cmd.Parameters.AddWithValue("@clase", reserva.ID_Clase);
            cmd.Parameters.AddWithValue("@fecha", reserva.FechaReserva);
            cmd.ExecuteNonQuery();
        }

        public void Actualizar(Reserva reserva)
        {
             var conn = _db.GetNewConnection();
            conn.Open();

            var cmd = new SqlCommand(
                "UPDATE Reservas SET ID_Miembro = @miembro, ID_Clase = @clase, FechaReserva = @fecha WHERE ID_Reserva = @id",
                conn);

            cmd.Parameters.AddWithValue("@miembro", reserva.ID_Miembro);
            cmd.Parameters.AddWithValue("@clase", reserva.ID_Clase);
            cmd.Parameters.AddWithValue("@fecha", reserva.FechaReserva);
            cmd.Parameters.AddWithValue("@id", reserva.ID_Reserva);
            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int id)
        {
             var conn = _db.GetNewConnection();
            conn.Open();

            var checkCmd = new SqlCommand(
                "SELECT COUNT(*) FROM Asistencia WHERE ID_Reserva = @reservaId", conn);
            checkCmd.Parameters.AddWithValue("@reservaId", id);
            int count = Convert.ToInt32(checkCmd.ExecuteScalar());

            if (count > 0)
            {
                throw new InvalidOperationException(
                    $"Esta reserva tiene {count} asistencias asociadas. No se puede eliminar.");
            }

            var cmd = new SqlCommand("DELETE FROM Reservas WHERE ID_Reserva = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public List<Reserva> BuscarPorMiembro(int idMiembro)
        {
            var resultados = new List<Reserva>();
            var conn = _db.GetNewConnection();
            conn.Open();

            var cmd = new SqlCommand("SELECT * FROM Reservas WHERE ID_Miembro = @miembroId", conn);
            cmd.Parameters.AddWithValue("@miembroId", idMiembro);
             var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                resultados.Add(new Reserva
                {
                    ID_Reserva = Convert.ToInt32(reader["ID_Reserva"]),
                    ID_Miembro = Convert.ToInt32(reader["ID_Miembro"]),
                    ID_Clase = Convert.ToInt32(reader["ID_Clase"]),
                    FechaReserva = Convert.ToDateTime(reader["FechaReserva"])
                });
            }

            return resultados;
        }
    }
}