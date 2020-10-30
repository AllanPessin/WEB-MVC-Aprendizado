using MaisAprendizado.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MaisAprendizado.Data
{
    public class AulaGravadaData : Data
    {
        //Create - INSERT
        public void Create(AulaGravada aula)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connectionDB;
            cmd.CommandText = @"INSERT INTO Aula_gravada VALUES(@AulaId, @CursoId, @Titulo,)";//Inserir tambem no curso espcifico
            cmd.Parameters.AddWithValue("@AulaId", aula.IdAula);
            cmd.Parameters.AddWithValue("@CursoId", aula.Titulo);
            cmd.ExecuteNonQuery();
        }
        //Read - SELECT
        public AulaGravada Read(int id)
        {
            AulaGravada aulagravada = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connectionDB;
            cmd.CommandText = @"SELECT * FROM Aula_Gravada WHERE AulaId = @id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                aulagravada = new AulaGravada();
                aulagravada.IdAula = (int)reader["AulaId"];
                aulagravada.Titulo = (string)reader["Titulo"];
                aulagravada.Descricao = (string)reader["Descricao"];
            }
            return aulagravada;
        }
    }
}
