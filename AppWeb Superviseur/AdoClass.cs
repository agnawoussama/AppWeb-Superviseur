using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace AppWeb_Superviseur
{
    public class AdoClass
    {
        public SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);
        public SqlCommand command;
        public SqlDataReader reader;
        public BindingSource bs;

        public void Connecter()
        {
            connection.Open();
        }

        public void Deconnecter()
        {
            connection.Close();
        }
    }
}