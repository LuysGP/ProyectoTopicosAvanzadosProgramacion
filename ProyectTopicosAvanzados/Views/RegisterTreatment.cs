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
    public partial class RegisterTreatment : Form
    {
        TreatmentDetails TreatmentDetails;
        EditDoctor editDoctor = new EditDoctor();
        EditConsult editConsult = new EditConsult();

        public RegisterTreatment()
        {
            InitializeComponent();
            editDoctor.SelectAllDoctors(textBoxDoctor);//Combobox del Doctor
            editConsult.SelectAllConsults(textBoxConsult);//Combobox de las Consultas
        }
        
        //Enviamos los datos ingresados en cada uno de los textbox de la forma como parametros en el objeto     
        private void buttonRegisterConsult_Click(object sender, EventArgs e)
        {
            try
            {
                TreatmentDetails = new TreatmentDetails(int.Parse(textBoxDoctor.Text), textBoxNurse.Text, textBoxTracing.Text, textBoxDiary.Text, int.Parse(textBoxConsult.Text));

                TreatmentDetails.Register();

                MessageBox.Show("Tratamiento registrado correctamente");
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

    }
   
    //Clase usada para almacenar y enviar los datos a la base de datos por medio de un metodo 
    public class TreatmentDetails
    {
        int doctor;
        string nurse;
        String tracing;
        String diary;
        int consult;

        //Conexion de la base de datos con el programa
        SqlConnection conection = new SqlConnection(@"Data Source=DESKTOP-VKEH4OM;Initial Catalog = Clinica; integrated security=true");

        
        //Constructor que almacena los datos enviados por el objeto dentro de los campos de la clase
        public TreatmentDetails(int doctor, string nurse, String tracing, String diary, int consult)
        {
            this.consult = consult;
            this.nurse = nurse;
            this.tracing = tracing;
            this.consult = consult;
            this.diary = diary;
            this.doctor = doctor;
        }
        
        //Metodo que envia los datos capturados por el programa hacia la base de datos
        public void Register()
        {
            conection.Open();
            String query = "INSERT INTO Treatment (register_id, tracing, doctor_id, nurse, diary_evolution) VALUES (@consult, @tracing, @doctor, @nurse, @diary)";
            SqlCommand command = new SqlCommand(query, conection);
            command.Parameters.AddWithValue("@consult", this.consult);
            command.Parameters.AddWithValue("@tracing", this.tracing);
            command.Parameters.AddWithValue("@doctor", this.doctor);
            command.Parameters.AddWithValue("@nurse", this.nurse);
            command.Parameters.AddWithValue("@diary", this.diary);

            command.ExecuteNonQuery();
            conection.Close();
        }

    }
}
