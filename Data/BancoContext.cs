using Microsoft.EntityFrameworkCore;
using Primeiro_Site.Models;

namespace Primeiro_Site.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions <BancoContext> options) : base(options)
        {

        }   
        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
