using Naty.Peludinho.Business.Interfaces;
using Naty.Peludinho.Business.Models;
using Naty.Peludinho.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Naty.Peludinho.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(NatyPeludinhoDbContext context) : base(context) { }
    }
}
