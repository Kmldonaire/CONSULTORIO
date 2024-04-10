using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DEDATOS.MODELOS
{
     public  class PACIENTE
    {
        [Key]
        public int Pacienteid { get; set; }

        [Required]
        [StringLength(120)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(120)]
        public string NApellidos { get; set; }

        [Required]
        public DateTime Fechadeingreso { get; set; }

        [Required]
        public bool Estado { get; set; }


    }
}
