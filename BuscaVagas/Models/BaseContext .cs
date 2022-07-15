//using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace BuscaVagas.Models
{
    public class BaseContext : DbContext //lembre de fazer a importação
    {
        //instanciando BaseContext com o banco com esse nome

        public BaseContext() : base("BuscaVagas.Data") { }

        //public BaseContext(DbContextOptions<BaseContext> options): base(options)
        //{

        //}
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Vaga> Vaga { get; set; }
    }
}
