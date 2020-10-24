using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MaisAprendizado.Models
{
    public class Aluno : Pessoa
    {
        public Pessoa Pessoa { get; set; }//is a

        [Display(Name = "Telefone")]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }
    }
}
