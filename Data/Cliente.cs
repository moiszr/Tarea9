using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tarea9.Data
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(11), Required]
        public string? Cedula { get; set; }

        [MaxLength(70), Required]
        public string? Nombre { get; set; }

        [MaxLength(70), Required]
        public string? Apellido { get; set; }

        [MaxLength(10)]
        public string? Telefono { get; set; }

        [MaxLength(70), Required]
        public string? Email { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }

        [ForeignKey("TipoSangre"), Required]
        public int IdTipo { get; set; }
        public TipoSangre? TipoSangre { get; set; }

        [MaxLength(70), Required]
        public string? Provincia { get; set; }

        [MaxLength(256), Required]
        public string? Direccion { get; set; }

        [Required]
        public double Latitude { get; set; } = default!;

        [Required]
        public double Longitude { get; set; } = default!;

        [Required]
        public bool lehadadocovid { get; set; } = default!;

        [MaxLength(256), Required]
        public string? Justificacion { get; set; }
    }
}
