using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Enem.WebAPI.Models;
using Enem.WebAPI.Repositories;
using Enem.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Enem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatoController : ControllerBase
    {
        private readonly ICandidatoService _candidatoService;

        public CandidatoController(ICandidatoService candidatoService)
        {
            _candidatoService = candidatoService;
        }


        // GET: api/Candidato
        [HttpGet]
        public ActionResult<IEnumerable<Candidato>> Get()
        {
            try
            {
                return Ok(_candidatoService.GetCandidatos());
            }
            catch (Exception exception)
            {
                return BadRequest(exception);
            }
        }


        // GET: api/Candidato/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_candidatoService.GetCandidato(id));
            }
            catch (Exception exception)
            {
                return BadRequest(exception);
            }
        }

        // POST: api/Candidato
        [HttpPost]
        public IActionResult RegisterCandidato([FromBody] Candidato candidato)
        {
            try
            {
                return Created("candidatos", _candidatoService.CreateCandidato(candidato));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        // PUT: api/Candidato/5
        [HttpPut]
        public IActionResult EditCandidato([FromBody] Candidato candidato)
        {
            try
            {
                return Ok(_candidatoService.UpdateCandidato(candidato));
            }
            catch (Exception e)
            {

                return BadRequest(e);
            }
        }

        [HttpPut("RecalcularVagas/{numVagas}")]
        public IActionResult RecalcularVagas(int numVagas)
        {
            try
            {
                _candidatoService.RecalcularVagas(numVagas);
                return Ok(new { Success = true, Message = "Lista de Aprovados atualizado com sucesso!" });
            }
            catch (Exception e)
            {

                return BadRequest(e);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{idCandidato}")]
        public IActionResult DeleteCandidatos(int idCandidato)
        {
            try
            {
                _candidatoService.DeleteCandidato(idCandidato);
                return Ok(new {Sucess = true, Message = "Deletado com sucesso"});
            }
            catch (Exception exception)
            {

                return BadRequest(exception);
            }
        }
    }
}
