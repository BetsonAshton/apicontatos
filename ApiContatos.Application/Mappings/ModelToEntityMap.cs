using ApiContatos.Application.Models.Requests;
using ApiContatos.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiContatos.Application.Mappings
{
    public class ModelToEntityMap: Profile
    {
        public ModelToEntityMap() 
        {
            CreateMap<ContatoCreateRequest, Contato>()
              .AfterMap((src, dest) =>
              {
                  dest.IdContato= Guid.NewGuid();
                  dest.DataHoraCadastro = DateTime.Now;
              });

            CreateMap<ContatoUpdateRequest, Contato>();

           
        }
    }
}
