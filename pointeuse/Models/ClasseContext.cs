using Microsoft.EntityFrameworkCore;

namespace pointeuse.Models
{
    public class ClasseContext:DbContext
    {
        public ClasseContext(DbContextOptions<ClasseContext> options) : base(options)
        {

        }
        public DbSet<Cycle> cycle { get; set; } = null!;
        public DbSet<Emargement> emargement { get; set; } = null!;
        public DbSet<EtClasse> etClasse { get; set; } = null!;
        public DbSet<Etudiant> Etudiant { get; set; } = null!;
        public DbSet<Groupe> groupe { get; set; } = null!;
        public DbSet<Presence> presence { get; set; } = null!;
    }
}
