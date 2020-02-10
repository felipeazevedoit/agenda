using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agenda.Dominio.Organizacao;
using Agenda.Repositorio.Organizacao;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.Servico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizacaoController : ControllerBase
    {
        private readonly OrganizacaoRepositorio _Rep = new OrganizacaoRepositorio();
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
    }
}