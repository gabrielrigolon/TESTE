using Enem.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enem.WebAPI.Repositories
{
    public interface ICandidatoRepository
    {
        IEnumerable<Candidato> GetCandidatos();
        Candidato CreateCandidato(Candidato candidato);
        Candidato GetCandidato(int idCandidato);
        void DeleteCandidato(int idCandidato);
        Candidato UpdateCandidato(Candidato candidato);
        void UpdateCandidatos(IEnumerable<Candidato> candidatos);
    }
}
