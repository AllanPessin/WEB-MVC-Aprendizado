using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MaisAprendizado.Models
{
    public class Professor : Pessoa
    {
        public Pessoa Pessoaa { get; set; }//is a
        
        [Display(Name = "Crédito")]
        [DataType(DataType.Currency)]
        public decimal Credito { get; set;}
    }
}
