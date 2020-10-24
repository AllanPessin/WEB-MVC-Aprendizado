using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace MaisAprendizado.Data
{
    public class AlunoData
    {
        //Create - INSERT
        public void Create(Aluno aluno)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connectionDB;
            cmd.CommandText = @"EXEC AdicionarAluno @Nome, @Email, @DataNascimetno, @Senha, @Telefone";
            cmd.Parameters.AddWithValue("@Nome", aluno.Telefone);
            cmd.ExecuteNonQuery();
        }
        //Read - SELECT
        public LinkedList<Aluno> Read()
        {
            List<Aluno> lista = new List<Aluno>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connectionDB;
            cmd.CommandText = @"SELEC * FROM Alunos ORDER BY Nome";
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Aluno aluno = new Aluno();
            }
        }
    }
}
