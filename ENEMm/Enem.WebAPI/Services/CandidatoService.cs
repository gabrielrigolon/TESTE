using Enem.WebAPI.Models;
using Enem.WebAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enem.WebAPI.Services
{
    public class CandidatoService : ICandidatoService
    {
        private readonly ICandidatoRepository _candidatoRepository;

        public CandidatoService(ICandidatoRepository candidatoRepository)
        {
            _candidatoRepository = candidatoRepository;
        }

        public IEnumerable<Candidato> GetCandidatos()
        {
            var candidatos = _candidatoRepository.GetCandidatos().ToList();
            return candidatos.OrderByDescending(x => x.Nota);
        }

        public Candidato CreateCandidato(Candidato candidato)
        {
            if (candidato != null)
            {
                if (candidato.Nota >= 0 && candidato.Nota <= 100
                    && !candidato.Nome.Any(char.IsDigit) && !candidato.Cidade.Any(char.IsDigit))
                {
                    var candidatoDb = _candidatoRepository.UpdateCandidato(candidato);

                    return candidatoDb;
                }
            }
            return null;
        }

        public Candidato GetCandidato(int idCandidato)
        {
            var candidato = _candidatoRepository.GetCandidato(idCandidato);

            return candidato;
        }

        public void DeleteCandidato(int idCandidato)
        {
            _candidatoRepository.DeleteCandidato(idCandidato);
        }

        public Candidato UpdateCandidato(Candidato candidato)
        {

            if (candidato != null)
            {
                if (candidato.Nota >= 0 && candidato.Nota <= 100
                    && !candidato.Nome.Any(char.IsDigit) && !candidato.Cidade.Any(char.IsDigit))
                {
                    var candidatoDb = _candidatoRepository.UpdateCandidato(candidato);

                    return candidatoDb;
                }
            }
            return null;
        }

        private void UpdateCandidatos(IEnumerable<Candidato> candidatos)
        {
            _candidatoRepository.UpdateCandidatos(candidatos);
        }


        public void RecalcularVagas(int numVagas)
        {
            var candidatos = GetCandidatos().OrderByDescending(x => x.Nota).ToList();
            foreach (var candidato in candidatos)
            {
                if (candidato.Nota > 0 && numVagas > 0)
                {
                    candidato.Status = true;
                    numVagas--;
                }
                else if (numVagas == 0)
                {
                    candidato.Status = false;
                }
            }

            UpdateCandidatos(candidatos);
        }
    }
}
