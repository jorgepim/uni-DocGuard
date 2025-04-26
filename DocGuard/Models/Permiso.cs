using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DocGuard.Models
{
    public class Permiso
    {
        [Key]
        [Column("id_permiso")]
        public int IdPermiso { get; set; }

        [Required]
        [ForeignKey("Documento")]
        [Column("id_documento")]
        public int IdDocumento { get; set; }

        [Required]
        [ForeignKey("Usuario")]
        [Column("id_usuario")]
        public int IdUsuario { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("nivel_acceso")]
        public string NivelAcceso { get; set; } 
        public Documento Documento { get; set; }
        public Usuario Usuario { get; set; }
    }
}
