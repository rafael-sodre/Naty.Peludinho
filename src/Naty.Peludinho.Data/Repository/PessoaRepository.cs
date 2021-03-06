﻿using Microsoft.EntityFrameworkCore;
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

        public async Task<Pessoa> ObterPessoaEndereco(Guid enderecoId)
        {
            return await Db.Pessoas.AsNoTracking()
                .Include(c => c.Endereco)
                .FirstOrDefaultAsync(c => c.Id == enderecoId);
        }
    }
}
