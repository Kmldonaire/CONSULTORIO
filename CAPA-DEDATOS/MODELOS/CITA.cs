using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DEDATOS.MODELOS
{
    public class CITA
    {

        [Key]
        public int citaId { get; set; }

        [Required]
        [StringLength(50)]
        public string Codigo { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }

        [Required]
        public bool Estado { get; set; }




    }
}
