using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Enem.WebAPI.Models;

namespace Enem.WebAPI.Services
{
    public interface ICandidatoService
    {
        IEnumerable<Candidato> GetCandidatos();
        Candidato GetCandidato(int idCandidato);
        Candidato CreateCandidato(Candidato candidato);
        void DeleteCandidato(int idCandidato);
        Candidato UpdateCandidato(Candidato candidato);
        void RecalcularVagas(int vagas);

    }
}
