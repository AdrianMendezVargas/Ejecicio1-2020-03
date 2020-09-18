using System.ComponentModel.DataAnnotations;

namespace Ejercicio1_2020_03.Models
{
    public class Estudiante
    {

        [Key]
        public int EstudianteId { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string Nombres { get; set; }

        [Range(minimum:1, maximum:10, ErrorMessage="Seleccione un semestre")]
        public int Semestre { get; set; }

        
        public string Nacionalidad { get; set; }

        //public virtual Nacionalidades Nacionalidad { get; set; }



    }
}