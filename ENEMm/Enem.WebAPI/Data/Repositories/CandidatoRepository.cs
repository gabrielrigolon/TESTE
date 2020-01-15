using Enem.WebAPI.Data;
using Enem.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enem.WebAPI.Repositories
{
    public class CandidatoRepository : ICandidatoRepository
    {
        private readonly DataContext _dbcontext;

        public CandidatoRepository(DataContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public IEnumerable<Candidato> GetCandidatos()
        {
            var candidatos = _dbcontext.Candidatos;

            return candidatos;
        }

        public Candidato CreateCandidato(Candidato candidato)
        {
            _dbcontext.Candidatos.Add(candidato);
            _dbcontext.SaveChanges();

            return candidato;
        }

        public Candidato GetCandidato(int idCandidato)
        {
            var candidato = _dbcontext.Candidatos.FirstOrDefault(x => x.Id == idCandidato);

            return candidato;
        }

        public void DeleteCandidato(int idCandidato)
        {
            var candidato = _dbcontext.Candidatos.FirstOrDefault(x => x.Id == idCandidato);
            if (candidato == null)
                return ;
            _dbcontext.Candidatos.Remove(candidato);
            _dbcontext.SaveChanges();
        }

        public Candidato UpdateCandidato(Candidato candidato)
        {
            _dbcontext.Candidatos.Update(candidato);
            _dbcontext.SaveChanges();

            return candidato;
        }

        public void UpdateCandidatos(IEnumerable<Candidato> candidatos)
        {
            _dbcontext.Candidatos.UpdateRange(candidatos);
            _dbcontext.SaveChanges();
        }
    }
}
