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
            cmd.CommandText = @"INSERT INTO Aula_gravada VALUES(@AulaId, @CursoId, @Titulo,)";
            cmd.Parameters.AddWithValue("@AulaId", aula.IdAula);
            cmd.Parameters.AddWithValue("@CursoId", aula.Titulo);
            cmd.ExecuteNonQuery();
        }
    }
}
