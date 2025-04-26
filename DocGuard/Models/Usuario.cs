using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DocGuard.Models
{
    public class Usuario
    {
        [Key]
        [Column("id_usuario")]
        public int IdUsuario { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("nombre")]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("apellido")]
        public string Apellido { get; set; }

        [Required]
        [MaxLength(100)]
        [EmailAddress]
        [Column("correo")]
        public string Correo { get; set; }

        [Required]
        [MaxLength(255)]
        [Column("clave")]
        public string Clave { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("rol")]
        public string Rol { get; set; }

        public ICollection<Documento> DocumentosSubidos { get; set; }
        public ICollection<Permiso> Permisos { get; set; }
    }
}
