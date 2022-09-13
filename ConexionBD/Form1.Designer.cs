
namespace ConexionBD
{
    partial class btn_Insertar_Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_Nombre = new System.Windows.Forms.TextBox();
            this.text002 = new System.Windows.Forms.Label();
            this.text_Apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_Salary = new System.Windows.Forms.TextBox();
            this.btn_MostrarSelect = new System.Windows.Forms.Button();
            this.tabla_Employees = new System.Windows.Forms.ListView();
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Insertar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // text_Nombre
            // 
            this.text_Nombre.Location = new System.Drawing.Point(252, 42);
            this.text_Nombre.Name = "text_Nombre";
            this.text_Nombre.Size = new System.Drawing.Size(100, 22);
            this.text_Nombre.TabIndex = 4;
            // 
            // text002
            // 
            this.text002.AutoSize = true;
            this.text002.Location = new System.Drawing.Point(176, 73);
            this.text002.Name = "text002";
            this.text002.Size = new System.Drawing.Size(58, 17);
            this.text002.TabIndex = 5;
            this.text002.Text = "Apellido";
            // 
            // text_Apellido
            // 
            this.text_Apellido.Location = new System.Drawing.Point(252, 73);
            this.text_Apellido.Name = "text_Apellido";
            this.text_Apellido.Size = new System.Drawing.Size(100, 22);
            this.text_Apellido.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email";
            // 
            // text_Email
            // 
            this.text_Email.Location = new System.Drawing.Point(494, 73);
            this.text_Email.Name = "text_Email";
            this.text_Email.Size = new System.Drawing.Size(100, 22);
            this.text_Email.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Salario";
            // 
            // text_Salary
            // 
            this.text_Salary.Location = new System.Drawing.Point(494, 44);
            this.text_Salary.Name = "text_Salary";
            this.text_Salary.Size = new System.Drawing.Size(100, 22);
            this.text_Salary.TabIndex = 10;
            // 
            // btn_MostrarSelect
            // 
            this.btn_MostrarSelect.Location = new System.Drawing.Point(38, 113);
            this.btn_MostrarSelect.Name = "btn_MostrarSelect";
            this.btn_MostrarSelect.Size = new System.Drawing.Size(114, 51);
            this.btn_MostrarSelect.TabIndex = 11;
            this.btn_MostrarSelect.Text = "Mostrar tota la tabla";
            this.btn_MostrarSelect.UseVisualStyleBackColor = true;
            this.btn_MostrarSelect.Click += new System.EventHandler(this.btn_MostrarSelect_Click);
            // 
            // tabla_Employees
            // 
            this.tabla_Employees.HideSelection = false;
            this.tabla_Employees.Location = new System.Drawing.Point(179, 113);
            this.tabla_Employees.Name = "tabla_Employees";
            this.tabla_Employees.Size = new System.Drawing.Size(912, 232);
            this.tabla_Employees.TabIndex = 12;
            this.tabla_Employees.UseCompatibleStateImageBehavior = false;
            this.tabla_Employees.View = System.Windows.Forms.View.Details;
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.Location = new System.Drawing.Point(38, 189);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(114, 51);
            this.btn_Borrar.TabIndex = 13;
            this.btn_Borrar.Text = "Borrar";
            this.btn_Borrar.UseVisualStyleBackColor = true;
            this.btn_Borrar.Click += new System.EventHandler(this.btn_Borrar_Click);
            // 
            // btn_Insertar_Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 455);
            this.Controls.Add(this.btn_Borrar);
            this.Controls.Add(this.tabla_Employees);
            this.Controls.Add(this.btn_MostrarSelect);
            this.Controls.Add(this.text_Salary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_Apellido);
            this.Controls.Add(this.text002);
            this.Controls.Add(this.text_Nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "btn_Insertar_Registro";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_Nombre;
        private System.Windows.Forms.Label text002;
        private System.Windows.Forms.TextBox text_Apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_Salary;
        private System.Windows.Forms.Button btn_MostrarSelect;
        private System.Windows.Forms.ListView tabla_Employees;
        private System.Windows.Forms.Button btn_Borrar;
    }
}

