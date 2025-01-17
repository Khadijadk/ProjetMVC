using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProjetMVC.Models
{
    public class Myctx : DbContext
    {
        public Myctx(DbContextOptions<Myctx> options) : base(options)
        {
        }
       
        public DbSet<Produit> Produit { get; set; }
       
        public DbSet<Client> Client { get; set; }

    }
}
