using HastaneUygulamasi.Models;
using Microsoft.EntityFrameworkCore;

namespace HastaneUygulamasi.Data
{
    // Tabloların yönetimini bu class'tan yapıyoruz.
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        public virtual DbSet<Hastalar> Hastalar { get; set; }
        public virtual DbSet<Katlar> Katlars { get; set; }
        public virtual DbSet<Odalar> Odalars { get; set; }
    }
}
