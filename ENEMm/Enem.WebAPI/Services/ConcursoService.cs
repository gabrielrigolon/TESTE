using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Enem.WebAPI.Data.Repositories.Interfaces;
using Enem.WebAPI.Models;
using Enem.WebAPI.Services.Interfaces;

namespace Enem.WebAPI.Services
{
    public class ConcursoService : IConcursoService
    {
        private readonly IConcursoRepository _concursoRepository;

        public ConcursoService(IConcursoRepository concursoRepository)
        {
            _concursoRepository = concursoRepository;
        }
        public IEnumerable<Concurso> GetConcursos()
        {
            var concursos = _concursoRepository.GetConcursos().ToList();
            return concursos.OrderByDescending(x => x.Descricao);
        }

        public Concurso CreateConcurso(Concurso concurso)
        {
           
                var concursoDb = _concursoRepository.CreateConcursos(concurso);

                return concursoDb;
        }

        public Concurso GetConcurso(int idConcurso)
        {
            var concurso = _concursoRepository.GetConcurso(idConcurso);

            return concurso; 
        }

        public void DeleteConcurso(int idConcurso)
        {
           _concursoRepository.DeleteConcursos(idConcurso);
        }

        public void UpdateConcurso(Concurso concurso)
        {
             _concursoRepository.UpdateConcurso(concurso);

        }

    }
}
