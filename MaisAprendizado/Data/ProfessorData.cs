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
        public void Create(Professor professor)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connectionDB;
            cmd.CommandText = @"EXEC AdicionarProfessor @Nome, @Email, @DataNascimetno, @Senha, @Credito";
            cmd.Parameters.AddWithValue("@Nome", professor.Credito);
            cmd.Parameters.AddWithValue("@Email", professor.Nome);
            cmd.Parameters.AddWithValue("@DataNascimento", professor.DataNascimento);
            cmd.Parameters.AddWithValue("@Senha", professor.Senha);
            cmd.ExecuteNonQuery();
        }
        //Read - SELECT
        public List<Professor> Read()
        {
            List<Professor> lista = new List<Professor>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connectionDB;
            cmd.CommandText = @"SELEC * FROM Professores ORDER BY Nome";
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Professor professor = new Professor();
            }
        }
    }
}
