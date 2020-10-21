using MaisAprendizado.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MaisAprendizado.Data
{
    public class PessoaData : Data
    {
        //Create-INSERT
        public void Create(Pessoa Pessoa)
        {
            //cmd é um comando que permite executar uma query no Banco da Dados
            SqlCommand cmd = new SqlCommand();
            //conecta com o banco de dados
            cmd.Connection = connectionDB;
            //Cria a string SQL
            cmd.CommandText = @"INSERT INTO Pessoas VALUES (@Nome, @Email, @DataNascimento, @Senha)";
            //Colocando os dados recebidos no banco de dados
            cmd.Parameters.AddWithValue("@Nome", Pessoa.Nome);
            cmd.Parameters.AddWithValue("@Email", Pessoa.Email);
            cmd.Parameters.AddWithValue("@DataNascimento", Pessoa.DataNascimento);
            cmd.Parameters.AddWithValue("@Senha", Pessoa.Senha);
            //Executa a string SQL
            cmd.ExecuteNonQuery();
        }
        //Read - SELECT
        public List<Pessoa> Read()
        {
            List<Pessoa> lista = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connectionDB;
                cmd.CommandText = @"SELECT * FROM Pessoas ORDER BY Nome";
                SqlDataReader reader = cmd.ExecuteReader();

                lista = new List<Pessoa>();
                while(reader.Read())
                {
                    Pessoa pessoa = new Pessoa();
                    pessoa.IdPessoa = (int)reader["IdCliente"];
                    pessoa.Nome = (string)reader["Nome"];
                    pessoa.Email = (string)reader["Email"];
                    pessoa.DataNascimento = (string)reader["DataNascimento"];
                    pessoa.Senha = (string)reader["Senha"];
                    lista.Add(pessoa);
                }
            }
            catch(SqlException sqlerror )
            {

            }
            return lista;
        }
        //Read - SELECT (Faz a busca pelo ID da pessoa)
        //Sobrecarga
        public Pessoa Read(int id)
        {
            Pessoa cliente = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connectionDB;

        }
        //Update - UPDATE
        //public void Update()
    }
}
