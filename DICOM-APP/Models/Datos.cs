using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DICOM_APP.Models
{
    public class Datos
    {
        public Datos()
        {

        }
        public Datos(string patientName, DateTime patientBD, string patientSex, string medicalAlert, string allergies, string studyInstance, string requestingPhysician, string requestedPD, string requestedPID, string requestedPP)
        {
            
            this.patientName = patientName;
            this.patientBD = patientBD;
            this.patientSex = patientSex;
            this.medicalAlert = medicalAlert;
            this.allergies = allergies;
            this.studyInstance = studyInstance;
            this.requestingPhysician = requestingPhysician;
            this.requestedPD = requestedPD;
            this.requestedPID = requestedPID;
            this.requestedPP = requestedPP;
        }

        public int idDatos { get; set; }
        public string patientName { get; set; }
        public DateTime patientBD { get; set; }
        public string patientSex { get; set; }
        public string medicalAlert { get; set; }

        public string allergies { get; set; }
        public string studyInstance { get; set; }
        public string requestingPhysician { get; set; }
        public string requestedPD { get; set; }
        public string requestedPID { get; set; }
        public string requestedPP { get; set; }
    }
}