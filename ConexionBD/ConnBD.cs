using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConexionBD
{
    class ConnBD
    {
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        SqlConnection connection;

        public SqlConnection Connection { get => connection; set => connection = value; }

        public ConnBD()
        {
            builder.DataSource = "46.183.116.173,54321";
            builder.InitialCatalog = "BryanEmployees";
            builder.UserID = "sa";
            builder.Password = "123456789";

            try
            {
                this.Connection = new SqlConnection(builder.ConnectionString);
                this.Connection.Open();
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }
        }

        public void CerrarConexion()
        {
            try
            {
                this.Connection.Close();
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }
        }
    }
}
