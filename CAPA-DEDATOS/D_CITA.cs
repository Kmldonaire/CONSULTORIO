using CAPA_DEDATOS.MODELOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DEDATOS
{
    public  class D_CITA
    {
        Repository<CITA> _repository;
        public D_CITA()
        {
            _repository = new Repository<CITA>();
        }

        public List<CITA> ObtenerTodalascITAS()
        {
            return _repository.Consulta().ToList();
        }

        public int AgregarCITA (CITA  CITA)
        {
            CITA.FechaCreacion = DateTime.Now;
            _repository.Agregar(CITA);
            return 1;
        }

        public int EditarCita(CITA CITA)
        {
            {
            var CITAEnDB = _repository.Consulta().FirstOrDefault(r => r.CITAId == CITA.citaId);

            if (CITAEnDB != null)
            {
                 CITAEnDB.MEDICOID =  CITA.MEDICOID;
                    CITAEnDB. PACIENTEID = CITA.PACIENTEID;
                    CITAEnDB. FECHACITA = CITA.PACIENTEID;
                    CITAEnDB.Estado = CITA.Estado;
                _repository.Editar(CITAEnDB);
                return 1;
            }
            return 0;
        }

        public int EliminarCITA(int citaId)
        {
                var CITAEnDB = _repository.Consulta().FirstOrDefault(r => r.CITAID == citaId);
            if (CITAEnDB != null)
            {
                _repository.Eliminar(CITAEnDB);
                return 1;
            }
            return 0;
        }






    }
}
