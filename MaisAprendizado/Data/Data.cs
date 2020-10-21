using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;


namespace MaisAprendizado.Data
{
    public class Data : IDisposable
    {
        //Atributo : vai nos permitir  conectar com o Banco de Dados
        protected SqlConnection connectionDB;

        //Construtor
        public Data()
        {
            try
            {
                //String de conexão com o Banco de Dados
                string strConexao = @"Data source = localhost;
                                    Initial Catalog = Interdisciplinar;
                                    Integrated Security=true;"; //Autentcação do Windows
                                                                //User Id=sa; Password=dba; //Autenticação SQL Server

                connectionDB = new SqlConnection(strConexao);

                connectionDB.Open();
            }
            catch (SqlException er)
            {
                Console.WriteLine("Erro do banco " + er);
            }
        }
        public void Dispose()
        {
            connectionDB.Close();
        }
    }
}
