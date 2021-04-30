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

namespace ProyectTopicosAvanzados.Views
{
    public partial class EditDoctor : Form
    {
        //Conexion a la DB y doctor actual
        SqlConnection cnt = new SqlConnection(@"Data Source=DESKTOP-VKEH4OM;Initial Catalog = Clinica; integrated security=true");
        DoctorDetail doctor = new DoctorDetail();
        public int doctorActual;

        public EditDoctor()
        {
            InitializeComponent();
            SelectAllDoctors(textBoxDoctor);
            SelectAllDoctors();
            buttonDeleteDoctor.Enabled = false;
            buttonUpdateDoctor.Enabled = false;
        }
        //Seleccion de todos los doctores.
        public void SelectAllDoctors(ComboBox textBox)
        {
            try
            {
                cnt.Open();
                String query = "Select doctor_id FROM Doctor";

                SqlCommand command = new SqlCommand(query, cnt);
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
                cnt.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        //Consulta a solo un doctor
        private void buttonSearchDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                cnt.Open();
                String query = $"SELECT doctor_speciality, doctor_name FROM Doctor WHERE doctor_id = {int.Parse(textBoxDoctor.Text)}";

                SqlCommand command = new SqlCommand(query, cnt);
                SqlDataReader sqlDataReader = null;

                try
                {
                    sqlDataReader = command.ExecuteReader();
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                }

                while (sqlDataReader.Read())
                {
                    doctor.speciality = sqlDataReader[0].ToString() ;
                    textBoxEspeciality.Text = doctor.speciality;
                    doctor.nombre = sqlDataReader[1].ToString();
                    textBoxName.Text = doctor.nombre;

                    buttonUpdateDoctor.Enabled = true;
                    buttonDeleteDoctor.Enabled = true;                    
                    doctorActual = int.Parse(textBoxDoctor.Text);
                }
                cnt.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    
        //Modificacion del doctor
        private void buttonUpdateDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                cnt.Open();
                String query = $"UPDATE doctor SET doctor_speciality=@speciality, doctor_name=@name WHERE doctor_id=@doctorID";

                SqlCommand command = new SqlCommand(query, cnt);

                command.Parameters.AddWithValue("@speciality", textBoxEspeciality.Text);
                command.Parameters.AddWithValue("@name", textBoxName.Text);
                command.Parameters.AddWithValue("@doctorID", doctorActual);

                command.ExecuteNonQuery();

                cnt.Close();

                MessageBox.Show("Doctor actualizado correctamente");

                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        DataTable dataTable = new DataTable();
        //Seleccion de todos los doctores
        private void SelectAllDoctors()
        {
            try
            {
                cnt.Open();
                String query = "SELECT doctor_id AS ID, doctor_speciality AS Especialidad, doctor_name AS Nombre FROM Doctor";
                SqlCommand command = new SqlCommand(query, cnt);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

                cnt.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        //Eliminacion del doctor
        private void buttonDeleteDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                cnt.Open();//Abrimos la conexion para poder eliminar los datos de la base de datos
                String query = "DELETE FROM Doctor WHERE doctor_id=@doctorId";//codigo para poder eliminar los datos

                SqlCommand command = new SqlCommand(query, cnt);//establecemos una instancia del tipo SqlCommand para poder ejecutar la accion
                command.Parameters.AddWithValue("doctorId", doctorActual);//Con este codigo accedemos a la tabla que queremos elimnar los datos
                command.ExecuteNonQuery();
                MessageBox.Show("Doctor eliminado correctamente");

                cnt.Close();//Se cierra la base de datos

                textBoxEspeciality.Clear();
                textBoxName.Clear();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
    //Clase para los detalles del doctor
    public class DoctorDetail
    {
        public string speciality;
        public string nombre;

        public DoctorDetail() { }
    }
}
