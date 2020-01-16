using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enem.WebAPI.Models
{
    public class CandidatoConcurso
    {
        public int IdCandidato { get; set; }
        public int IdConcurso { get; set; }

        public Candidato Candidato { get; set; }
        public Concurso Concurso { get; set; }
    }
}
