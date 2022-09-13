using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ConexionBD.DAL;

namespace ConexionBD
{
    public partial class btn_Insertar_Registro : Form
    {

        public btn_Insertar_Registro()
        {
            InitializeComponent();
        }

        public void MessageVaciarCampos()
        {
            this.text_Nombre.Text = "";
            this.text_Apellido.Text = "";
            this.text_Email.Text = "";
            this.text_Salary.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees(this.text_Nombre.Text, this.text_Apellido.Text, this.text_Email.Text, int.Parse(this.text_Salary.Text));
            DALEmployees insertar = new DALEmployees();
            insertar.InsertEmployees(employees);
            MessageVaciarCampos();
            MostrasTablasEmplaoyes();
        }

        private void btn_MostrarSelect_Click(object sender, EventArgs e)
        {
            MostrasTablasEmplaoyes();
        }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            DALEmployees borrrar = new DALEmployees();
            borrrar.BorrarEmployees(int.Parse(this.tabla_Employees.SelectedItems[0].SubItems[1].Text));
            MostrasTablasEmplaoyes();
        }

        public void MostrasTablasEmplaoyes()
        {
            this.tabla_Employees.Items.Clear();
            this.tabla_Employees.Columns.Clear();

            DALEmployees select = new DALEmployees();
            this.tabla_Employees.Columns.Add("Nº", 60);
            this.tabla_Employees.Columns.Add("ID", 60);
            this.tabla_Employees.Columns.Add("Nombre", 60);
            this.tabla_Employees.Columns.Add("Apellido", 60);
            this.tabla_Employees.Columns.Add("Email", 90);
            this.tabla_Employees.Columns.Add("Móvil", 60);
            this.tabla_Employees.Columns.Add("Fecha", 90);
            this.tabla_Employees.Columns.Add("Job", 60);
            this.tabla_Employees.Columns.Add("Salario", 60);
            this.tabla_Employees.Columns.Add("Manager", 60);
            this.tabla_Employees.Columns.Add("Departamento", 60);

            List<Employees> employeesnums = select.SelectEmployes();
            int i = 0;
            foreach (var item in employeesnums)
            {
                i++;
                ListViewItem list1 = new ListViewItem(i.ToString());
                list1.SubItems.Add(item.Id.ToString());
                list1.SubItems.Add(item.First_name.ToString());
                list1.SubItems.Add(item.Last_name.ToString());
                list1.SubItems.Add(item.Email.ToString());

                if (item.Phone == null)
                {
                    list1.SubItems.Add("NULL");
                }
                else
                {
                    list1.SubItems.Add(item.Phone.ToString());
                }

                list1.SubItems.Add(item.Date.ToString());
                list1.SubItems.Add(item.Fkjob_id.ToString());
                list1.SubItems.Add(item.Salary.ToString());

                if (item.Fkmanager_id == null)
                {
                    list1.SubItems.Add("NULL");
                }
                else
                {
                    list1.SubItems.Add(item.Fkmanager_id.ToString());
                }

                if (item.Fkdepartament_id == null)
                {
                    list1.SubItems.Add("NULL");
                }
                else
                {
                    list1.SubItems.Add(item.Fkdepartament_id.ToString());
                }

                this.tabla_Employees.Items.Add(list1);
            }
        }
    }
}

