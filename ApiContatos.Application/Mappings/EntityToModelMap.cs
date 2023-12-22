using ApiContatos.Application.Models.Responses;
using ApiContatos.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiContatos.Application.Mappings
{
    public class EntityToModelMap:Profile
    {
        public EntityToModelMap()
        {
            CreateMap<Contato, ContatoResponse>();
           


        }
    }
}
