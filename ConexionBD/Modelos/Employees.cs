using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBD
{
    class Employees
    {
        //Atributos
        int id;
        String first_name;
        String last_name;
        String email;
        String phone;
        DateTime date;
        int fkjob_id;
        decimal salary;
        int? fkmanager_id;
        int? fkdepartament_id;

        //SET and GET
        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public DateTime Date { get => date; set => date = value; }
        public int Fkjob_id { get => fkjob_id; set => fkjob_id = value; }
        public decimal Salary { get => salary; set => salary = value; }
        public int? Fkmanager_id { get => fkmanager_id; set => fkmanager_id = value; }
        public int? Fkdepartament_id { get => fkdepartament_id; set => fkdepartament_id = value; }
        public int Id { get => id; set => id = value; }


        //Constructor
        public Employees(string first_name, string last_name, string email, String phone, DateTime date, int fkjob_id, decimal salary, int? fkmanager_id, int? fkdepartament_id)
        {
            this.First_name = first_name;
            this.Last_name = last_name;
            this.Email = email;
            this.Phone = phone;
            this.Date = date;
            this.Fkjob_id = fkjob_id;
            this.Salary = salary;
            this.Fkmanager_id = fkmanager_id;
            this.Fkdepartament_id = fkdepartament_id;
        }


        public Employees(string first_name, string last_name, string email, decimal salary)
        {
            this.First_name = first_name;
            this.Last_name = last_name;
            this.Email = email;
            this.Date = date;
            this.Fkjob_id = fkjob_id;
            this.Salary = salary;
        }

        public Employees()
        {
            this.First_name = "Kevin22";
            this.Last_name = "Pibaque";
            this.Email = "bryan@bryan.com";
            this.Date = DateTime.Now;
            this.Fkjob_id = 4;
            this.Salary = 10000;
        }
    }
}
