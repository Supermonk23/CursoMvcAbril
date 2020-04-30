﻿using System;

namespace CS.CursoMvc.Domain.Entities
{
    class Endereco
    {
        public Endereco()
        {
            EnderecoId = Guid.NewGuid();
            ClienteId = Guid.NewGuid();
        }

        public Guid EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }

    }
}
