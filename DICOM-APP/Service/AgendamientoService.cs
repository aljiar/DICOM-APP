using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using DICOM_APP.Models;

namespace DICOM_APP.Service
{
    public class AgendamientoService
    {

        public SqlConnection conexion;
        public SqlTransaction transaccion;
        public string error;
        public AgendamientoService()
        {
            this.conexion = Conexion.getConexion();
        }
        public List<Agendamiento> listaAgendamientos()
        {
            List<Agendamiento> listaDeAgendamientos = new List<Agendamiento>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "Select Datos.patientName, Datos.patientID, Datos.patientBD, Datos.patientSex,Modalidad.modalidad,Modalidad.scheduledStationAET,Modalidad.scheduledPSSD, Modalidad.scheduledPSST,Modalidad.medicoProgramado from Modalidad, Datos,Agendamiento where Datos.idDatos=Agendamiento.idDatos and Agendamiento.idModalidad=Modalidad.idModalidad";
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                Modalidad modalidad = new Modalidad();
                Datos dato = new Datos();
                dato.patientName = registro.GetString(0);
                dato.patientID = registro.GetInt32(1);
                dato.patientBD = registro.GetDateTime(2);
                dato.patientSex = registro.GetString(3);
                modalidad.modalidad = registro.GetString(4);
                modalidad.scheduledStationAET = registro.GetString(5);
                modalidad.fecha = registro.GetDateTime(6);
                modalidad.hora = registro.GetTimeSpan(7);
                modalidad.medico = registro.GetString(8);

                Agendamiento agentamiento = new Agendamiento(modalidad, dato);

                listaDeAgendamientos.Add(agentamiento);

            }
            registro.Close();
            return listaDeAgendamientos;

        }

        //public List<Agendamiento> listaAgendamiento2()
        //{
        //    List<Agendamiento> listaDeAgendamientos = new List<Agendamiento>();
        //    SqlCommand comando = new SqlCommand();
        //    comando.Connection = conexion;
        //    comando.CommandText = "SELECT * from Agendamiento";
        //    SqlDataReader registro = comando.ExecuteReader();
        //    while (registro.Read())
        //    {
        //        Agendamiento a = new Agendamiento();
        //        a.idAgendamiento = registro.GetInt32(0);
        //        a.idModalidad = registro.GetInt32(1);
        //        a.idDatos = registro.GetInt32(2);
                
        //        listaDeAgendamientos.Add(a);

        //    }
        //    registro.Close();
        //    return listaDeAgendamientos;

        //}
    }
}