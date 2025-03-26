using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PracticaMVC.Models
{
    public class usuarios
    {
        [Key]
        [DisplayName("ID de Usuario")]
        public int id_usuario { get; set; }

        [DisplayName("Nombre del usuario")]
        [StringLength(200, ErrorMessage = "La cantidad máxima de caracteres válida es {1}")]
        public string? nombre { get; set; }

        [DisplayName("Documento")]
        [StringLength(50, ErrorMessage = "La cantidad máxima de caracteres válida es {1}")]
        public string? documento { get; set; }

        [DisplayName("Carnet")]
        [StringLength(50, ErrorMessage = "La cantidad máxima de caracteres válida es {1}")]
        public string? carnet { get; set; }

        [DisplayName("Carrera ID")]
        public int? carrera_id { get; set; }

        [DisplayName("Correo Electrónico")]
        [StringLength(250, ErrorMessage = "La cantidad máxima de caracteres válida es {1}")]
        [EmailAddress(ErrorMessage = "Debe ingresar un correo válido!")]
        public string? email { get; set; }

        [DisplayName("Contraseña")]
        [StringLength(50, ErrorMessage = "La cantidad máxima de caracteres válida es {1}")]
        [DataType(DataType.Password)]
        public string? contrasenia { get; set; }

        [DisplayName("Tipo de Usuario")]
        [StringLength(50, ErrorMessage = "La cantidad máxima de caracteres válida es {1}")]
        public string? tipo_usuario { get; set; }

        [DisplayName("Bloqueado")]
        [StringLength(1, ErrorMessage = "La cantidad máxima de caracteres válida es {1}")]
        public string? bloqueado { get; set; }

        [DisplayName("Último Login")]
        public DateTime? ultimo_login { get; set; }

        [DisplayName("Activo")]
        [StringLength(1, ErrorMessage = "La cantidad máxima de caracteres válida es {1}")]
        public string? activo { get; set; }
    }
}
