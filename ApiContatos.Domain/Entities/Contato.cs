using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiContatos.Domain.Entities
{
    public class Contato
    {
        private Guid? _idContato;
        private string? _nome;
        private string? _email;
        private string? _telefone;
        private DateTime? _dataHoraCadastro;

        public Guid? IdContato { get => _idContato; set => _idContato = value; }
        public string? Nome { get => _nome; set => _nome = value; }
        public string? Email { get => _email; set => _email = value; }
        public string? Telefone { get => _telefone; set => _telefone = value; }
        public DateTime? DataHoraCadastro { get => _dataHoraCadastro; set => _dataHoraCadastro = value; }
    }
}
