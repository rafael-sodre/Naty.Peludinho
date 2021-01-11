using Microsoft.EntityFrameworkCore;
using Naty.Peludinho.Business.Interfaces;
using Naty.Peludinho.Business.Models;
using Naty.Peludinho.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naty.Peludinho.Data.Repository
{
    public class PessoaRepository : Repository<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(NatyPeludinhoDbContext context) : base(context) { }
    }
}
