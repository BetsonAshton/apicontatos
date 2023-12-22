using ApiContatos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiContatos.Domain.Interfaces.Repositories
{
    public interface IContatoRepository:IBaseRepository<Contato>
    {
    }
}
