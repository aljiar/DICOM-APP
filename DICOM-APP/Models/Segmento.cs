using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DICOM_APP.Models
{
    public class Segmento
    {
        // public Campo[] campos;
        //public Campo[] camposobligados;

        public List<Campo> campos;
        public List<Campo> camposobligados;
        public String errorText;
    }
}