using ApiContatos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiContatos.Data.Mappings
{
    public class ContatoMap : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.HasKey(c => c.IdContato);

            builder.Property(c => c.Nome).HasMaxLength(150).IsRequired();
            builder.Property(c => c.Email).IsRequired();
            builder.Property(c => c.Telefone).IsRequired();
            builder.Property(c => c.DataHoraCadastro).IsRequired();
        }
    }
}
