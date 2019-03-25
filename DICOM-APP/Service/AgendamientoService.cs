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
        //public List<Agendamiento> listaAgendamientos()
        //{
        //    List<Modalidad> listaDeAgendamientos = new List<Modalidad>();
        //    SqlCommand comando = new SqlCommand();
        //    comando.Connection = conexion;
        //    comando.CommandText = "Select * from Agendamiento";
        //    SqlDataReader registro = comando.ExecuteReader();
        //    while (registro.Read())
        //    {
        //        Modalidad modalidad = new Modalidad();
        //        modalidad.idModalidad = registro.GetInt32(0);
        //        modalidad.modalidad = registro.GetString(1);
        //        modalidad.scheduledStationAET = registro.GetString(2);
        //        modalidad.fecha = registro.GetDateTime(3);
        //        modalidad.hora = registro.GetTimeSpan(4);
        //        modalidad.medico = registro.GetString(5);

        //        listaDeModalidades.Add(modalidad);

        //    }
        //    registro.Close();
        //    return listaDeModalidades;

        //}
    }
}