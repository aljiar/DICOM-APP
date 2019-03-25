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
    public class ModalidadService
    {
        public SqlConnection conexion;
        public SqlTransaction transaccion;
        public string error;
        public ModalidadService()
        {
            this.conexion = Conexion.getConexion();
        }

        public bool agregarModalidad(Modalidad modalidad)
        {
            bool agrega = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "Insert into Modalidad values(@modalidad,@station,@fecha,@hora,@medico";
            comando.Parameters.AddWithValue("@modalidad", modalidad.modalidad);
            comando.Parameters.AddWithValue("@station", modalidad.scheduledStationAET);
            comando.Parameters.AddWithValue("@fecha", modalidad.fecha);
            comando.Parameters.AddWithValue("@hora", modalidad.hora);
            comando.Parameters.AddWithValue("@medico", modalidad.medico);
            try
            {
                comando.ExecuteNonQuery();
                agrega = true;
            }
            catch (SqlException ex)
            {
                this.error = ex.Message;
                throw;
            }

            return agrega;
        }
        
        public List<Modalidad> listaModalidades()
        {
            List<Modalidad> listaDeModalidades = new List<Modalidad>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "select * from Modalidad";
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                Modalidad modalidad = new Modalidad();
                modalidad.idModalidad = registro.GetInt32(0);
                modalidad.modalidad = registro.GetString(1);
                modalidad.scheduledStationAET = registro.GetString(2);
                modalidad.fecha = registro.GetDateTime(3);
                modalidad.hora = registro.GetTimeSpan(4);
                modalidad.medico = registro.GetString(5);
                
                listaDeModalidades.Add(modalidad);
                
            }
            registro.Close();
            return listaDeModalidades;

        }

    }
}