using Microsoft.EntityFrameworkCore;

namespace DocGuard.Models
{
    public class DocuGuardsContext:DbContext
    {
        public DocuGuardsContext(DbContextOptions<DocuGuardsContext> options) : base(options)
        {
        }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Documento> Documentos { get; set; }
    }
}
