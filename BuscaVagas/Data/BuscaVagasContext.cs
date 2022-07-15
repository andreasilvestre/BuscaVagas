using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BuscaVagas.Models;

namespace BuscaVagas.Data
{
    public class BuscaVagasContext : DbContext
    {
        public BuscaVagasContext (DbContextOptions<BuscaVagasContext> options)
            : base(options)
        {
        }

        public DbSet<BuscaVagas.Models.Empresa> Empresa { get; set; } = default!;

        public DbSet<BuscaVagas.Models.Vaga>? Vaga { get; set; }
    }
}
