using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Enem.WebAPI.Data.Repositories.Interfaces;
using Enem.WebAPI.Models;
using Enem.WebAPI.Repositories;

namespace Enem.WebAPI.Data.Repositories
{
    public class ConcursoRepository : IConcursoRepository
    {
        private readonly DataContext _dbcontext;

        public ConcursoRepository(DataContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public IEnumerable<Concurso> GetConcursos()
        {
            var concursos = _dbcontext.Concursos;
            return concursos;
        }

        public Concurso CreateConcursos(Concurso concurso)
        {
            _dbcontext.Concursos.Add(concurso);
            _dbcontext.SaveChanges();
            return concurso;
        }

        public Concurso GetConcurso(int idConcurso)
        {
           var concurso = _dbcontext.Concursos.FirstOrDefault(x => x.Id == idConcurso);
           return concurso;
        }

        public void DeleteConcursos(int idConcurso)
        {
            var concurso = _dbcontext.Concursos.FirstOrDefault(x => x.Id == idConcurso);
            if (concurso == null)
                return;
            _dbcontext.Concursos.Remove(concurso);
            _dbcontext.SaveChanges();
        }

        public void UpdateConcurso(Concurso concurso)
        {
            _dbcontext.Concursos.Update(concurso);
            _dbcontext.SaveChanges();

        }

        public void UpdateConcursos(IEnumerable<Concurso> concursos)
        {
            _dbcontext.Concursos.UpdateRange(concursos);
            _dbcontext.SaveChanges();
        }
    }
}
