using ApiContatos.Data.Contexts;
using ApiContatos.Domain.Entities;
using ApiContatos.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiContatos.Data.Repositories
{
    public class ContatoRepository :IContatoRepository
    {
        public void Create(Contato entity)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Contato.Add(entity);
                dataContext.SaveChanges();
            }
        }

        public void Update(Contato entity)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Entry(entity).State = EntityState.Modified;
                dataContext.SaveChanges();
            }
        }

        public void Delete(Contato entity)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Contato.Remove(entity);
                dataContext.SaveChanges();
            }
        }


        public List<Contato> GetAll()
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Contato
                    .OrderBy(c => c.Nome)
                    .ToList();
            }
        }

        public Contato GetById(Guid id)
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Contato
                    .Where(c => c.IdContato == id)
                    .FirstOrDefault();
            }
        }

       
    }
}
