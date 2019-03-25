using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DICOM_APP.Models
{
    public class Conexion
    {
        private static SqlConnection objConexion;
        private static string error;

        public static SqlConnection getConexion()
        {
            if (objConexion!=null)
          
                return objConexion;
                objConexion = new SqlConnection();
                objConexion.ConnectionString = "Data Source=LAPTOP-VQO7HG50\\SQLEXPRESS; Initial Catalog=Agenda; Integrated Security=True";
            
            try
            {
                objConexion.Open();
                return objConexion;
            }
            catch (Exception e)
            {
                error = e.Message;
                return null;
            }
        }
        public static void cerrarConexion()
        {
            if (objConexion!=null)
            {
                objConexion.Close();
            }
        }
       
    }
}