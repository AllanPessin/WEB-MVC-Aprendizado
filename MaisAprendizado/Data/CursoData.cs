using MaisAprendizado.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MaisAprendizado.Data
{
    public class CursoData : Data
    {
        //Create - INSERT
        public void Create (Curso curso) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connectionDB;
            cmd.CommandText = @"EXEC AdicionarCurso @IdProfessor, @Nome, @Preco, @CargaHoraria";
            //cmd.Parameters.AddWithValue("@IdProfessor",) //Preciso utilizar o Id de professor na procedure do banco
            cmd.Parameters.AddWithValue("@Nome", curso.Nome);
            cmd.Parameters.AddWithValue("@Preco", curso.Preco);
            cmd.Parameters.AddWithValue("@CargaHoraria", curso.CargaHoraria);
            cmd.ExecuteNonQuery();
        }
    }
}
