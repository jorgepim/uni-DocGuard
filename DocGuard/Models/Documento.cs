using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DocGuard.Models
{
    public class Documento
    {
        [Key]
        [Column("id_documento")]
        public int IdDocumento { get; set; }

        [Required]
        [MaxLength(150)]
        [Column("titulo")]
        public string Titulo { get; set; }

        [Column("descripcion")]
        public string Descripcion { get; set; }

        [Required]
        [MaxLength(255)]
        [Column("ruta_archivo")]
        public string RutaArchivo { get; set; }

        [Required]
        [Column("fecha_subida")]
        public DateTime FechaSubida { get; set; } = DateTime.Now;

        [Required]
        [Column("version")]
        public int Version { get; set; } = 1;

        [Required]
        [MaxLength(50)]
        [Column("estado")]
        public string Estado { get; set; }

        [Required]
        [ForeignKey("UsuarioSubida")]
        [Column("id_usuario_subida")]
        public int IdUsuarioSubida { get; set; }

        public Usuario UsuarioSubida { get; set; }
        public ICollection<Permiso> Permisos { get; set; }
    }
}
