using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Enem.WebAPI.Models;

namespace Enem.WebAPI.Data.Repositories.Interfaces
{
    public interface IConcursoRepository
    {
        IEnumerable<Concurso> GetConcursos();
        Concurso CreateConcursos(Concurso concurso);
        Concurso GetConcurso(int idConcurso);
        void DeleteConcursos(int idConcurso);
        void UpdateConcurso(Concurso concurso);
    }
}
