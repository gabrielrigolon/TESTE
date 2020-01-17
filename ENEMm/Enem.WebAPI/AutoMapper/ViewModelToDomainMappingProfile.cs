using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Enem.WebAPI.Models;
using Enem.WebAPI.ViewModels;

namespace Enem.WebAPI.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CandidatoViewModel, Candidato>();
            CreateMap<ConcursoViewModel, Concurso>();
        }
    }
}
