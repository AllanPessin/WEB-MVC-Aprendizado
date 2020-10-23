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
            Pessoa pessoa = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connectionDB;
            cmd.CommandText = @"SELECT * FROM Pessoas WHERE Id = @id";
            cmd.Parameters.AddWithValue(@"id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                pessoa = new Pessoa();
                pessoa.IdPessoa = (int)reader["IdPessoa"];
                pessoa.Nome = (int)reader["Nome"];
                pessoa.Email = (int)reader["Email"];
                pessoa.DataNascimento = (int)reader["DataNascimento"];
                pessoa.Senha = (int)reader["Senha"];
            }
            return pessoa;
        }
        //Update - UPDATE
        public void Update()
        {
            SqlCommand cmd = new SqlCommand(Pessoa pessoa);
            cmd.Connection = connectionDB;
            cmd.CommandText = @"UPDATE Pessoa SET Nome = @Nome, Email = @Email, DataNascimento = @DataNascimento, Senha = @senha WHERE IdPessao = @IdPessoa";
            cmd.Parameters.AddWithValue = ("@Nome", pessoa.Nome);
            cmd.Parameters.AddWithValue = ("@Email", pessoa.Email);
            cmd.Parameters.AddWithValue = ("@DataNascimento", pessoa.DtaNascimento);
            cmd.Parameters.AddWithValue = ("@Senha", pessoa.Senha);
            cmd.ExecuteNonQuery();
        }
        //public void Update()
    }
}
