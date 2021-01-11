using System;
using System.Collections.Generic;
using System.Text;

namespace Naty.Peludinho.Business.Models
{
    public class Pessoa : Entity
    {
        public Guid PessoaId { get; set; }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }
        
        /* EF Relations */
        public IEnumerable<Animal> Animais { get; set; }
    }
}
