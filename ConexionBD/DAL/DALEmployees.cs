using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConexionBD.DAL
{
    class DALEmployees
    {
        public void InsertEmployees(Employees employees)
        {
            ConnBD cnn = new ConnBD();
            try
            {
                //Crear String de la query
                String query = @"insert into employees(first_name, last_name, email, hire_date, fkjob_id, salary) 
                               values(@pFirst_name, @pLast_name, @pEmail, @pHire_date, 4, @pSalary)";

                SqlCommand comando = new SqlCommand(query, cnn.Connection);

                //Parametros de la query
                SqlParameter pFirst_name = new SqlParameter("@pFirst_name", employees.First_name);
                SqlParameter pLast_name = new SqlParameter("@pLast_name", employees.Last_name);
                SqlParameter pEmail = new SqlParameter("@pEmail", employees.Email);
                SqlParameter pHire_date = new SqlParameter("@pHire_date", DateTime.Now);
                SqlParameter pSalary = new SqlParameter("@pSalary", employees.Salary);

                comando.Parameters.Add(pFirst_name);
                comando.Parameters.Add(pLast_name);
                comando.Parameters.Add(pEmail);
                comando.Parameters.Add(pHire_date);
                comando.Parameters.Add(pSalary);

                //Ejecutar la query
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuario: " + employees.First_name + " creado");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }
        }

        public List<Employees> SelectEmployes()
        {
            List<Employees> lisEmployees = new List<Employees>();
            ConnBD cnn = new ConnBD();

            try
            {
                //Crear y ejecutar la sentencia
                String query = "select * from employees";
                SqlCommand comando = new SqlCommand(query, cnn.Connection);
                SqlDataReader registros = comando.ExecuteReader();

                //Obtener los datos
                while (registros.Read())
                {
                    Employees employees = new Employees();
                    employees.Id = (int)GestionarNulos(registros["employee_id"]);
                    employees.First_name = (string)GestionarNulos(registros["first_name"]);
                    employees.Last_name = (string)GestionarNulos(registros["last_name"]);
                    employees.Email = (string)GestionarNulos(registros["email"]);
                    employees.Phone = (string)GestionarNulos(registros["phone_number"]);
                    employees.Date = (DateTime)GestionarNulos(registros["hire_date"]);
                    employees.Fkjob_id = (int)GestionarNulos(registros["fkjob_id"]);
                    employees.Salary = (decimal)GestionarNulos(registros["salary"]);
                    employees.Fkmanager_id = (int?)GestionarNulos(registros["fkmanager_id"]);
                    employees.Fkdepartament_id = (int?)GestionarNulos(registros["fkdepartment_id"]);
                    lisEmployees.Add(employees);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }
            return lisEmployees;
        }

        public void BorrarEmployees(int id)
        {

            ConnBD cnn = new ConnBD();
            try
            {
                //Crear String de la query
                String query = @"delete from employees
                                 where employee_id = @pEmployee_id;";

                SqlCommand comando = new SqlCommand(query, cnn.Connection);

                //Parametros de la query
                SqlParameter pEmployee_id = new SqlParameter("@pEmployee_id", id);
                comando.Parameters.Add(pEmployee_id);

                //Ejecutar la query
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuario con id: " + id + " fue eliminado");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }
        }

        public object GestionarNulos(object valOriginal)
        {
            if (valOriginal == System.DBNull.Value)
                return null;
            else
                return valOriginal;
        }
    }
}
