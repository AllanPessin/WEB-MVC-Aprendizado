using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MaisAprendizado.Models
{
    public class Curso
    {
        public int? IdCurso { get; set; }
        public int IdProfessor { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Campo nome obrigatório")]
        [MinLength(3)]
        public string Nome { get; set; }

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "Campo preço obrigatório")]
        [DataType(DataType.Currency)]
        public decimal Preco { get; set; }

        [Display(Name = "Carga Horaria")]
        [Required(ErrorMessage = "Carga horaria obrigatoria")]
        [DataType(DataType.Time)]
        public int CargaHoraria { get; set; }
    }
}
