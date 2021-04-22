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
    public partial class EditPatient : Form
    {
        SqlConnection conection = new SqlConnection(@"Data Source=DESKTOP-VKEH4OM;Initial Catalog = Clinica; integrated security=true");
        EditPatientDetails patient = new EditPatientDetails();
        int actualPatient;
        public EditPatient()
        {
            InitializeComponent();
            SelectAllPatients();
        }
        private void SelectAllPatients()
        {
            try
            {
                conection.Open();
                String query = "SELECT SS_number FROM Patient";

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
                    textBoxSS.Items.Add(sqlDataReader[0]);
                }
                conection.Close();
            }

            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }

        }
        private void searchPatientButton_Click(object sender, EventArgs e)
        {
            try
            {
                conection.Open();
                String query = $"SELECT patient_age, date_entry, unity_id, patient_name FROM Patient WHERE SS_number = {int.Parse(textBoxSS.Text)}";

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
                    patient.age = int.Parse(sqlDataReader[0].ToString());
                    textBoxAge.Text = patient.age.ToString();
                    patient.date = (DateTime)sqlDataReader[1];
                    dateTimePicker1.Value = patient.date;
                    patient.unity = int.Parse(sqlDataReader[2].ToString());
                    textBoxUnity.Text = patient.unity.ToString();
                    patient.name = sqlDataReader[3].ToString();
                    textBoxName.Text = patient.name;

                    buttonRegisterConsult.Enabled = true;
                    buttonDelete.Enabled = true;
                    actualPatient = int.Parse(textBoxSS.Text);
                }
                conection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void buttonRegisterConsult_Click(object sender, EventArgs e)
        {
            try
            {
                conection.Open();
                String query = $"UPDATE patient SET patient_age=@age, date_entry=@date, patient_name=@name, unity_id=@unityID WHERE SS_number=@ss";

                SqlCommand command = new SqlCommand(query, conection);

                command.Parameters.AddWithValue("@age", textBoxAge.Text);
                command.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                command.Parameters.AddWithValue("@name", textBoxName.Text);
                command.Parameters.AddWithValue("@unityID", textBoxUnity.Text);
                command.Parameters.AddWithValue("@ss", actualPatient);

                command.ExecuteNonQuery();

                conection.Close();

                MessageBox.Show("Paciente actualizado correctamente");

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conection.Open();
                String query = "DELETE FROM Patient WHERE SS_number=@patientId";

                SqlCommand command = new SqlCommand(query, conection);
                command.Parameters.AddWithValue("patientId", actualPatient);
                command.ExecuteNonQuery();
                MessageBox.Show("Paciente eliminado correctamente");

                conection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
    public class EditPatientDetails
    {
        public DateTime date = new DateTime();
        public int unity;
        public int age;
        public string name;
        public EditPatientDetails() { }
       
    }
}
