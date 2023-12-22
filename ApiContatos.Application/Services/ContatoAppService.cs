using ApiContatos.Application.Interfaces;
using ApiContatos.Application.Models.Requests;
using ApiContatos.Application.Models.Responses;
using ApiContatos.Domain.Entities;
using ApiContatos.Domain.Interfaces.Services;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiContatos.Application.Services
{
    public class ContatoAppService :IContatoAppService
    {
        private readonly IContatoDomainService _contatoDomainService;
        private readonly IMapper _mapper;

        public ContatoAppService(IContatoDomainService contatoDomainService, IMapper mapper)
        {
            _contatoDomainService = contatoDomainService;
            _mapper = mapper;
        }

        public ContatoResponse Create(ContatoCreateRequest request)
        {
            var contato = _mapper.Map<Contato>(request);
            _contatoDomainService.Create(contato);

            return _mapper.Map<ContatoResponse>(contato);
        }

        public ContatoResponse Update(ContatoUpdateRequest request)
        {
            var contato = _contatoDomainService.GetById(request.IdContato);

            var updatedContato = _mapper.Map(request, contato);
            updatedContato.DataHoraCadastro = DateTime.Now;
            _contatoDomainService.Update(updatedContato);

            return _mapper.Map<ContatoResponse>(updatedContato);


        }

        public ContatoResponse Delete(Guid id)
        {
          var contato = _contatoDomainService.GetById(id);
            _contatoDomainService.Delete(id);
            return _mapper.Map<ContatoResponse>(contato);
        }

        public List<ContatoResponse> GetAll()
        {
            var contato = _contatoDomainService.GetAll();
            return _mapper.Map<List<ContatoResponse>>(contato);
        }

        public ContatoResponse GetById(Guid id)
        {
            var contato = _contatoDomainService.GetById(id);
            return _mapper.Map<ContatoResponse>(contato);
        }
    }
}
