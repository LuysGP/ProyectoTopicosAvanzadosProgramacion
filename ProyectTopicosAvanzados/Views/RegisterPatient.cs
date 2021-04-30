﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ProyectTopicosAvanzados.Views
{
    public partial class RegisterPatient : Form
    {
        PatientDetails patient;
        EditUnity editUnity = new EditUnity();

        public RegisterPatient()
        {
            InitializeComponent();
            editUnity.SelectAllUnits(textBoxUnity);//Combobox de la unidad
        }
        //Enviamos los datos ingresados en cada uno de los textbox de la forma como parametros en el objeto
        private void buttonRegisterConsult_Click(object sender, EventArgs e)
        {
            try
            {
                patient = new PatientDetails(int.Parse(textBoxSS.Text), int.Parse(textBoxAge.Text), textBoxName.Text, int.Parse(textBoxUnity.Text));
                patient.Register();
                MessageBox.Show("Paciente registrado correctamente");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
    
    //Clase usada para almacenar y enviar los datos a la base de datos por medio de un metodo 
    public class PatientDetails
    {
        public string name;
        public int ss;
        public int age;
        public DateTime date = new DateTime();
        public int unity_id;

    //Conexion de la base de datos con el programa
        SqlConnection conection = new SqlConnection(@"Data Source=DESKTOP-VKEH4OM;Initial Catalog = Clinica; integrated security=true");
        
        //Constructor que almacena los datos enviados por el objeto dentro de los campos de la clase
        public PatientDetails(int ss, int age, string name, int unity_id)
        {
            this.ss = ss;
            this.age = age;
            this.name = name;
            this.date = DateTime.Now;
            this.unity_id = unity_id;
        }
        
        //Metodo que envia los datos capturados por el programa hacia la base de datos
        public void Register()
        {
            conection.Open();
            String query = "INSERT INTO Patient (SS_number, patient_age, date_entry, patient_name, unity_id) VALUES (@ss, @age, @date, @name, @unity)";
            SqlCommand command = new SqlCommand(query, conection);
            command.Parameters.AddWithValue("@ss", this.ss);
            command.Parameters.AddWithValue("@age", this.age);
            command.Parameters.AddWithValue("@date", this.date); 
            command.Parameters.AddWithValue("@name", this.name);
            command.Parameters.AddWithValue("@unity", this.unity_id);
            command.ExecuteNonQuery();
            conection.Close();
        }
    }
}
