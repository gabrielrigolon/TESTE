using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Enem.WebAPI.Models;

namespace Enem.WebAPI.Services.Interfaces
{
    public interface IConcursoService
    {
        IEnumerable<Concurso> GetConcursos();
        Concurso GetConcurso(int idConcurso);
        Concurso CreateConcurso(Concurso concurso);
        void DeleteConcurso(int idConcurso);
        void UpdateConcurso(Concurso concurso);
    }
}
