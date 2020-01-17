using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Enem.WebAPI.Models;

namespace Enem.WebAPI.ViewModels
{
    public class CandidatoViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public double Nota { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<CandidatoConcursoViewModel> CandidatoConcursos { get; set; }
    }
}
