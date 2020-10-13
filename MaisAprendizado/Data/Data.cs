using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MaisAprendizado.Data
{
    public class Data : IDisposable
    {
        //Atributo que vai permitir conectar com o Banco de dados
        protected SqlConnection connectionDB;

        //Construtor
        public Data()
        {
            try
            {
                //string de conexão dom o Banco de Dados
                string strConxao = @"Data source = localhost; 
                                Initial Catalog = MaisAprendizado; 
                                Integrated Security = true;";
                ConnectionDB = new SqlConnection(strConxao);
                ConnectionDB.Open();
            }
            catch
            {

            }
        }

        protected SqlConnection ConnectionDB { get => connectionDB; set => connectionDB = value; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
