using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DICOM_APP.Models
{
    public class Agendamiento
    {
        public Agendamiento(Modalidad modalidad, Datos dato)
        {
            this.modalidad = modalidad;
            this.dato = dato;
        }

        public int idAgendamiento { get; set; }
        public Modalidad modalidad { get; set; }
        public Datos dato { get; set; }
    }
}