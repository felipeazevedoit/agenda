using System;
using Agenda.Dominio.Organizacao;
using Agenda.Repositorio.Organizacao;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.Servico.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrganizacaoController : ControllerBase
    {
        private readonly OrganizacaoRepositorio _Rep = new OrganizacaoRepositorio();
       
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(_Rep.Listar());
            }
            catch (Exception ex)
            {
                return StatusCode(403, ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post(Organizacao organizacao)
        {
            try
            {
                return Ok(_Rep.Cadastrar(organizacao));
            }
            catch (Exception ex)
            {
                return StatusCode(403, ex.Message);
            }
        }

    }
}