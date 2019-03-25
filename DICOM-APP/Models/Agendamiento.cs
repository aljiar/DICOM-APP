using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DICOM_APP.Models
{
    public class Agendamiento
    {
        public int idAgendamiento { get; set; }
        public int idModalidad { get; set; }
        public int idDatos { get; set; }
    }
}