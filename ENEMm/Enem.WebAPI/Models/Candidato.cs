using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Enem.WebAPI.Models
{
    public class Candidato
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "DEU RUIM REQUIRED")]
        [MaxLength(9,ErrorMessage = "Deu ruim!")]
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public double Nota { get; set; }
        public bool Status { get; set; }
    }
}
