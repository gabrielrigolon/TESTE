using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Enem.WebAPI.Models;
using Enem.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Enem.WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ConcursoController : ControllerBase
    {
        private readonly IConcursoService _concursoService;

        public ConcursoController(IConcursoService concursoService)
        {
            _concursoService = concursoService;
        }

        // GET: api/Concurso
        [HttpGet]
        public ActionResult<IEnumerable<Concurso>> Get()
        {
            try
            {
                return Ok(_concursoService.GetConcursos());
            }
            catch (Exception exception)
            {
                return BadRequest(exception);
            }
        }

        // GET: api/Concurso/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_concursoService.GetConcurso(id));
            }
            catch (Exception exception)
            {
                return BadRequest(exception);
            }
        }

        // POST: api/Concurso
        [HttpPost]
        public IActionResult Post([FromBody] Concurso concurso)
        {
            try
            {
                return Created("concursos", _concursoService.CreateConcurso(concurso));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }

        // PUT: api/Concurso/5
        [HttpPut("{id}")]
        public IActionResult EditConcurso(int id, [FromBody] Concurso concurso)
        {
            try
            {
                _concursoService.UpdateConcurso(concurso);
                return Ok(new { Success = true, Message = "Concurso Atualizado com sucesso!" });
            }
            catch (Exception e)
            {

                return BadRequest(e);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCandidatos(int idConcurso)
        {
            try
            {
                _concursoService.DeleteConcurso(idConcurso);
                return Ok(new { Sucess = true, Message = "Deletado com sucesso" });
            }
            catch (Exception exception)
            {

                return BadRequest(exception);
            }
        }
    }
}
