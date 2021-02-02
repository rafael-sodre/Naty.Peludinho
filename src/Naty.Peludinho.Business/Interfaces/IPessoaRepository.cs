using Naty.Peludinho.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Naty.Peludinho.Business.Interfaces
{
    public interface IPessoaRepository : IRepository<Pessoa>
    {
        Task<Pessoa> ObterPessoaEndereco(Guid id);
    }
}
