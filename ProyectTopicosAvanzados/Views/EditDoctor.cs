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
        SqlConnection cnt = new SqlConnection(@"Data Source=DESKTOP-VKEH4OM;Initial Catalog = Clinica; integrated security=true");
        DoctorDetail doctor = new DoctorDetail();
        public int doctorActual;

        public EditDoctor()
        {
            InitializeComponent();
            SelectAllDoctors();
        }
        private void SelectAllDoctors()
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
                    textBoxDoctor.Items.Add(sqlDataReader[0]);
                }
                cnt.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
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
                    doctorActual = int.Parse(textBoxDoctor.Text);
                }
                cnt.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

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

        private void buttonDeleteDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                cnt.Open();
                String query = "DELETE FROM Doctor WHERE doctor_id=@doctorId";

                SqlCommand command = new SqlCommand(query, cnt);
                command.Parameters.AddWithValue("doctorId", doctorActual);
                command.ExecuteNonQuery();
                MessageBox.Show("Doctor eliminado correctamente");

                cnt.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }

    public class DoctorDetail
    {
        public string speciality;
        public string nombre;

        public DoctorDetail() { }
    }
}
