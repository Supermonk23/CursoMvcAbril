using System;
using System.Collections.Generic;

namespace CS.CursoMvc.Domain.Entities
{
    class Cliente
    {
        public Cliente()
        {
            ClienteId = Guid.NewGuid();
        }

        public Guid ClienteId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Ativo { get; set; }
        public ICollection<Endereco> Enderecos { get; set; }
    }
}
