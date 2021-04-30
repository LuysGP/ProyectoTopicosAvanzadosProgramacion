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
    public partial class EditTreatment : Form
    {
    //Conexion a la DB
        SqlConnection conection = new SqlConnection(@"Data Source=DESKTOP-VKEH4OM;Initial Catalog = Clinica; integrated security=true");
        EditTreatmentDetails editTreatmentDetails = new EditTreatmentDetails();
        EditDoctor editDoctor = new EditDoctor();
        EditConsult editConsult = new EditConsult();
        //Tratamiento actual
        int actualTreatment;
        public EditTreatment()
        {
            InitializeComponent();
            editDoctor.SelectAllDoctors(textBoxDoctor);
            editConsult.SelectAllConsults(textBoxConsult);
            SelectAllTreatments();
            buttonDeleteTreatment.Enabled = false;
            buttonUpdateTreatment.Enabled = false;
        }
        //Seleccion de todos los tratamientos
        private void SelectAllTreatments()
        {
            try
            {
                conection.Open();
                String query = "SELECT treatment_id FROM Treatment";

                SqlCommand command = new SqlCommand(query, conection);
                SqlDataReader sqlDataReader = null;
                try
                {
                    sqlDataReader = command.ExecuteReader();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
                while (sqlDataReader.Read())
                {
                    textBoxID.Items.Add(sqlDataReader[0]);
                }
                conection.Close();
            }

            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }
        //Busqueda de tratamiento
        private void buttonSearchTreatment_Click(object sender, EventArgs e)
        {
            try
            {
                conection.Open();
                String query = $"SELECT tracing, doctor_id, nurse, register_id, diary_evolution FROM Treatment WHERE treatment_id={int.Parse(textBoxID.Text)}";

                SqlCommand command = new SqlCommand(query, conection);
                SqlDataReader sqlDataReader = null;
                try
                {
                    sqlDataReader = command.ExecuteReader();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

                while (sqlDataReader.Read())
                {
                    editTreatmentDetails.tracing = sqlDataReader[0].ToString();
                    textBoxTracing.Text = editTreatmentDetails.tracing;

                    editTreatmentDetails.doctor = int.Parse(sqlDataReader[1].ToString());
                    textBoxDoctor.Text = editTreatmentDetails.doctor.ToString();

                    editTreatmentDetails.nurse = sqlDataReader[2].ToString();
                    textBoxNurse.Text = editTreatmentDetails.nurse;

                    textBoxConsult.Text = sqlDataReader[3].ToString();

                    editTreatmentDetails.diary = sqlDataReader[4].ToString();
                    textBoxDiary.Text = editTreatmentDetails.diary;

                    actualTreatment = int.Parse(textBoxID.Text);
                }
                conection.Close();

                buttonUpdateTreatment.Enabled = true;
                buttonDeleteTreatment.Enabled = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        //Eliminacion de tratamiento
        private void buttonDeleteTreatment_Click(object sender, EventArgs e)
        {
            try
            {
                conection.Open();//Abrimos la conexion para poder eliminar los datos de la base de datos
                String query = "DELETE FROM Treatment WHERE treatment_id=@id";//codigo para poder eliminar los datos

                SqlCommand command = new SqlCommand(query, conection);//establecemos una instancia del tipo SqlCommand para poder ejecutar la accion

                command.Parameters.AddWithValue("id", actualTreatment);//Con este codigo accedemos a la tabla que queremos elimnar los datos
                command.ExecuteNonQuery();
                MessageBox.Show("Tratamiento eliminado correctamente");

                conection.Close();//Se cierra la base de datos

                textBoxDoctor.Text = "";
                textBoxTracing.Clear();
                textBoxNurse.Clear();
                textBoxDiary.Clear();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        //Modificacion de tratamiento
        private void buttonUpdateTreatment_Click(object sender, EventArgs e)
        {
            try
            {
                conection.Open();
                string query = $"UPDATE Treatment SET tracing=@tracing, nurse=@nurse, register_id=@register, diary_evolution=@diary WHERE treatment_id=@id";

                SqlCommand command = new SqlCommand(query, conection);

                command.Parameters.AddWithValue("@tracing", textBoxTracing.Text);
                command.Parameters.AddWithValue("@nurse", textBoxNurse.Text);
                command.Parameters.AddWithValue("@register", int.Parse(textBoxConsult.Text));
                command.Parameters.AddWithValue("@id", actualTreatment);
                command.Parameters.AddWithValue("@diary", textBoxDiary.Text);

                command.ExecuteNonQuery();

                conection.Close();

                MessageBox.Show("Tratamiento actualizado correctamente");
            }
            catch (Exception en)
            {
                MessageBox.Show(en.Message);
            }
        }
    }
    //Clase para los detalles de tratamiento
    public class EditTreatmentDetails
    {
        public int doctor;
        public int patient;
        public string nurse;
        public String tracing;
        public String diary;

        public EditTreatmentDetails() { }
    }
}
