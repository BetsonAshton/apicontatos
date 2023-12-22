using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiContatos.Application.Models.Requests
{
    public class ContatoUpdateRequest
    {
        [Required(ErrorMessage = "Por favor, informe o id do contato desejado.")]
        public Guid IdContato { get; set; }

        [Required(ErrorMessage = "Nome do contato é obrigatório.")]
        [RegularExpression(pattern: "^[A-Za-zÀ-Üà-ü\\s]{6,150}$",
            ErrorMessage = "Informe um nome válido de 6 a 150 caracteres.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Email do contato é obrigatório.")]
        [EmailAddress(ErrorMessage = "Informe um endereço de email válido.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Telefone do cliente é obrigatório.")]
        [RegularExpression(pattern: "[() 0-9]{5,20}$",
         ErrorMessage = "Informe um telefone no formato '(00)000000000'.")]
        public string? Telefone { get; set; }
    }
}
