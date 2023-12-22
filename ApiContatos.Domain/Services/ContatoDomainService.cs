using ApiContatos.Domain.Entities;
using ApiContatos.Domain.Interfaces.Repositories;
using ApiContatos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiContatos.Domain.Services
{
    public class ContatoDomainService:IContatoDomainService
    {
        private readonly IContatoRepository _contatoRepository;

        public ContatoDomainService(IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }

        public void Create(Contato entity)
        {
           

            _contatoRepository.Create(entity);

        }

        public void Update(Contato entity)
        {
            var contato = _contatoRepository.GetById((Guid)entity.IdContato);
            contato.Nome = entity.Nome;
            contato.Email = entity.Email;
            contato.Telefone = entity.Telefone;
            contato.DataHoraCadastro = entity.DataHoraCadastro;
            _contatoRepository.Update(entity);
        }

        public void Delete(Guid id)
        {
            var contato =_contatoRepository.GetById(id);
            _contatoRepository.Delete(contato);
        }

        public List<Contato> GetAll()
        {
            return _contatoRepository.GetAll();
        }

        public Contato GetById(Guid id)
        {
            
            return _contatoRepository.GetById(id);
        }
    }
}
