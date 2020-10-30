using MaisAprendizado.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
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
            cmd.Parameters.AddWithValue("@IdProfessor", curso.IdPessoa);
            cmd.Parameters.AddWithValue("@Nome", curso.Nome);
            cmd.Parameters.AddWithValue("@Preco", curso.Preco);
            cmd.Parameters.AddWithValue("@CargaHoraria", curso.CargaHoraria);
            cmd.ExecuteNonQuery();
        }
        //Read - SELECT
        public List<Curso> Read()
        {
            List<Curso> lista = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connectionDB;
            cmd.CommandText = @"SELECT * FROM Cursos ORDER BY Nome";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Curso curso = new Curso();
                curso.IdCurso = (int)reader["CursoId"];
                curso.Nome = (string)reader["Nome"];
                curso.Preco = (decimal)reader["Preco"];
                curso.CargaHoraria = (int)reader["CargaHoraria"];
                curso.IdPessoa = (int)reader["PessoaId"];
            }
            return lista;            
        }
        //Read - SELECT (por nome)
        public void Read(string nome, int id)
        {
            Pessoa pessoa = null;
            Curso curso = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connectionDB;
            cmd.CommandText = @"SELECT c.*, p.Nome AS Professor FROM Cursos c LEFT JOIN Pessoa p ON c.PessoaId = p.PessoaId WHERE Nome LIKE UPPER('@Nome%') AND c.PessoaId = @id";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                pessoa = new Pessoa();
                curso = new Curso();
                curso.IdCurso = (int)reader["CursoId"];
                curso.Nome = (string)reader["Nome"];
                curso.Preco = (decimal)reader["Preco"];
                curso.CargaHoraria = (int)reader["CargaHoraria"];//Mudar para string atualizar banco para
                pessoa.Nome = (string)reader["Professor"];
            }
        }
    }
}
