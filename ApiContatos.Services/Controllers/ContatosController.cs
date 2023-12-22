using ApiContatos.Application.Interfaces;
using ApiContatos.Application.Models.Requests;
using ApiContatos.Application.Models.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiContatos.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatosController : ControllerBase
    {
        private readonly IContatoAppService _contatoAppService;

        public ContatosController(IContatoAppService contatoAppService)
        {
            _contatoAppService = contatoAppService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(ContatoResponse), 201)]
        public IActionResult Post(ContatoCreateRequest request)
        {
            return StatusCode(201, new
            {
                mensagem = "Contato cadastrado com sucesso.",
                produto = _contatoAppService.Create(request)
            });
        }

        [HttpPut]
        [ProducesResponseType(typeof(ContatoResponse), 200)]
        public IActionResult Put(ContatoUpdateRequest request)
        {
            return StatusCode(200, new
            {
                mensagem = "Contato atualizado com sucesso.",
                produto = _contatoAppService.Update(request)
            });
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(ContatoResponse), 200)]
        public IActionResult Delete(Guid id)
        {
            return StatusCode(200, new
            {
                mensagem = "Os seguintes dados do contato foram excluídos como sucesso.",
                produto = _contatoAppService.Delete(id)
            });
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<ContatoResponse>), 200)]
        public IActionResult GetAll()
        {
            return Ok(_contatoAppService.GetAll());
        }


        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ContatoResponse), 200)]
        public IActionResult GetById(Guid id)
        {
            return Ok(_contatoAppService.GetById(id));
        }

      
    }
}
