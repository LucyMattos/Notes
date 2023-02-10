using BlocodeNotasApi.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlocodeNotasApi.Repositories
{
    public class NotesContext : DbContext
    {
        public NotesContext(DbContextOptions<NotesContext> options) : base(options) 
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BlocoDeNotasConfiguration());
        }
       public DbSet<BlocoDeNotas> BlocoDeNotas { get; set; }
    }
}
