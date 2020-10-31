using MaisAprendizado.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MaisAprendizado.Data
{
    public class CompraCursoData : Data
    {
        //Create - INSERT
        public void Create(CompraCurso compracurso)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connectionDB;
            cmd.CommandText = @"INSERT INTO Compra_Curso VALUES";
        }
    }
}
