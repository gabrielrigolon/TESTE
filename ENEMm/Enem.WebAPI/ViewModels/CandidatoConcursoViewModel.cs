using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enem.WebAPI.ViewModels
{
    public class CandidatoConcursoViewModel
    {
        public int IdCandidato { get; set; }
        public int IdConcurso { get; set; }

        public CandidatoViewModel Candidato { get; set; }
        public ConcursoViewModel Concurso { get; set; }
    }
}
