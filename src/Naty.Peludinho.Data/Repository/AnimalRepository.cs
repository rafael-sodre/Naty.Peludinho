using Microsoft.EntityFrameworkCore;
using Naty.Peludinho.Business.Interfaces;
using Naty.Peludinho.Business.Models;
using Naty.Peludinho.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Naty.Peludinho.Data.Repository
{
    public class AnimalRepository : Repository<Animal>, IAnimalRepository
    {
        public AnimalRepository(NatyPeludinhoDbContext context) : base(context){ }

    }
}
