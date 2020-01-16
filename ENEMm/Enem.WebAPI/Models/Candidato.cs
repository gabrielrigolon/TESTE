using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Enem.WebAPI.Models
{
    public class Candidato
    {
        private double _nota;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }

        public double Nota
        {
            get => _nota;
            set => _nota = Math.Round(value, 2);
        }

        public bool Status { get; set; }

        public virtual ICollection<CandidatoConcurso> CandidatoConcursos { get; set; }
    }
}
