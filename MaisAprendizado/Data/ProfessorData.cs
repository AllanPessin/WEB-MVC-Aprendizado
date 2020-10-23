using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MaisAprendizado.Models;

namespace MaisAprendizado.Data
{
    public class ProfessorData : Data
    {
        //Create - INSERT
        public void Create(Pessoa pessoa)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connectionDB;
            cmd.CommandText = @"EXEC AdicionarAluno";
            cmd.Parameters.AddWithValue("@Nome", pessoa.Nome);
            cmd.Parameters.AddWithValue("@Email", pessoa.Email);
            cmd.Parameters.AddWithValue(@"DataNascimento", pessoa.DataNascimento);
            cmd.Parameters.AddWithValue("@Senha", pessoa.Senha);
            cmd.ExecuteNonQuery();
        }
    }
}
