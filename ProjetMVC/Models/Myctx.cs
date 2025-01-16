using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProjetMVC.Models
{
    public class Myctx : DbContext
    {
        public Myctx(DbContextOptions<Myctx> options) : base(options)
        {
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Produit> Produit { get; set; }
        public DbSet<Catalogue> Catalogue { get; set; }

        public DbSet<Commande> Commande { get; set; }

    }
}
