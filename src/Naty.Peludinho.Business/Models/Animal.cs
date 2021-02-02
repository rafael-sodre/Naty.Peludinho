using Naty.Peludinho.Business.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Naty.Peludinho.Business.Models
{
    public class Animal : Entity
    {
        public Guid PessoaId { get; set; }

        public TipoAnimal TipoAnimal { get; set; }
        public string Raca { get; set; }
        public string Cor { get; set; }
        public Sexo Sexo { get; set; }

        /* EF Relations */
        public Pessoa Pessoa { get; set; }
    }
}
