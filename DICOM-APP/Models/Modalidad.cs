using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DICOM_APP.Models
{
    public class Modalidad

    {
        public int idModalidad { get; set; }
        public string modalidad { get; set; }
        public string scheduledStationAET { get; set; }
        public DateTime fecha { get; set; }
        public TimeSpan hora { get; set; }
        public string medico { get; set; }

        public Modalidad()
        {

        }
        public Modalidad(string modalidad, string scheduledStationAET, DateTime fecha, TimeSpan hora,String medico)
        {
          
            this.modalidad = modalidad;
            this.scheduledStationAET = scheduledStationAET;
            this.fecha = fecha;
            this.hora = hora;
            this.medico = medico;
        }

    
    }
}