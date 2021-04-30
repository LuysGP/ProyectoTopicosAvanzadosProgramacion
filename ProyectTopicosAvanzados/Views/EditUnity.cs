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
    public partial class EditUnity : Form
    {
    //Conexion a la db
        SqlConnection conection = new SqlConnection(@"Data Source=DESKTOP-VKEH4OM;Initial Catalog = Clinica; integrated security=true");
        EditUnityDetails EditUnityDetails = new EditUnityDetails();
        EditDoctor editDoctor = new EditDoctor();
        //Unidad actual
        int actualUnity;
        DataTable dataTable = new DataTable();

        public EditUnity()
        {
            InitializeComponent();
            editDoctor.SelectAllDoctors(textBoxDoctorId);
            SelectAllUnits(textBoxUnity);
            SelectAllUnits();
            buttonUpdateUnit.Enabled = false;
            buttonDeleteUnity.Enabled = false;
        }
        //Seleccion de todas las unidades
        private void SelectAllUnits()
        {
            try
            {
                conection.Open();

                String query = "SELECT unity_id AS ID, unity_name AS Nombre, unity_plant AS Planta#, doctor_id AS IDDoctor FROM Unity";
                SqlCommand command = new SqlCommand(query, conection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

                conection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        //Rellenado de combobox para las unidades.
        public void SelectAllUnits(ComboBox textBox)
        {
            try
            {
                conection.Open();
                String query = "SELECT unity_id FROM Unity";

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
                    textBox.Items.Add(sqlDataReader[0]);
                }
                conection.Close();
            }

            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }

        }
        
        //Modificacion de unidad
        private void buttonUpdateUnit_Click(object sender, EventArgs e)
        {
            try
            {
                conection.Open();
                String query = @"UPDATE unity SET unity_name=@name, unity_plant=@plant, doctor_id=@doctorID WHERE unity_id=@unityID";
                SqlCommand command = new SqlCommand(query,conection);

                command.Parameters.AddWithValue("@name", textBoxName.Text);
                command.Parameters.AddWithValue("@plant", textBoxPlant.Text);
                command.Parameters.AddWithValue("@doctorID", textBoxDoctorId.Text);
                command.Parameters.AddWithValue("@unityID", actualUnity);

                command.ExecuteNonQuery();

                conection.Close();

                MessageBox.Show("Unidad actualizada correctamente");
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        //Eliminacion de unidad
        private void buttonDeleteUnity_Click(object sender, EventArgs e)
        {
            try
            {
                conection.Open();//Abrimos la conexion para poder eliminar los datos de la base de datos
                String query = "DELETE FROM Unity WHERE unity_id = @id";//codigo para poder eliminar los datos
                SqlCommand command = new SqlCommand(query, conection);//establecemos una instancia del tipo SqlCommand para poder ejecutar la accion

                command.Parameters.AddWithValue("id", actualUnity);//Con este codigo accedemos a la tabla que queremos elimnar los datos

                command.ExecuteNonQuery();//Se cierra la base de datos

                MessageBox.Show("Unidad eliminada correctamente");
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }
        //Busqueda de unidad
        private void buttonSearchUnity_Click(object sender, EventArgs e)
        {
            try
            {
                conection.Open();
                String query = $"SELECT unity_name, unity_plant, doctor_id FROM Unity WHERE unity_id={int.Parse(textBoxUnity.Text)}";
                SqlCommand command = new SqlCommand(query, conection);
                SqlDataReader SqlDataReader = null;

                try
                {
                    SqlDataReader = command.ExecuteReader();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

                while (SqlDataReader.Read())
                {
                    EditUnityDetails.name = SqlDataReader[0].ToString();
                    textBoxName.Text = EditUnityDetails.name;

                    EditUnityDetails.plant = SqlDataReader[1].ToString();
                    textBoxPlant.Text = EditUnityDetails.plant;

                    if (SqlDataReader[2].ToString().Length == 0)
                    {
                        textBoxDoctorId.Text = "0";
                    }
                    else
                    {
                        EditUnityDetails.doctor = int.Parse(SqlDataReader[2].ToString());
                        textBoxDoctorId.Text = EditUnityDetails.doctor.ToString();
                    }

                    actualUnity = int.Parse(textBoxUnity.Text);
                }
                conection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
    //Clase para los detalles de unidad
    public class EditUnityDetails
    {
        public string name;
        public string plant;
        public int doctor;

        public EditUnityDetails() { }
    }
}
