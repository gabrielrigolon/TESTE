using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enem.WebAPI.Models
{
    public class Concurso
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Candidato> Candidatos { get; set; }
    }
}
