using ApiContatos.Application.Models.Requests;
using ApiContatos.Application.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiContatos.Application.Interfaces
{
    public interface IContatoAppService
    {
        ContatoResponse Create(ContatoCreateRequest request);
        ContatoResponse Update(ContatoUpdateRequest request);
        ContatoResponse Delete(Guid id);
        List<ContatoResponse> GetAll();
        ContatoResponse GetById(Guid id);
    }
}
