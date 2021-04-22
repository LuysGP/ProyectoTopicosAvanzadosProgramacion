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
    public partial class EditTreatment : Form
    {
        SqlConnection conection = new SqlConnection(@"Data Source=DESKTOP-VKEH4OM;Initial Catalog = Clinica; integrated security=true");
        EditTreatmentDetails editTreatmentDetails = new EditTreatmentDetails();

        int actualTreatment;
        public EditTreatment()
        {
            InitializeComponent();
        }

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

                    editTreatmentDetails.diary = sqlDataReader[3].ToString();
                    textBoxDiary.Text = editTreatmentDetails.diary;

                    actualTreatment = int.Parse(textBoxID.Text);
                }
                conection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void buttonDeleteTreatment_Click(object sender, EventArgs e)
        {
            try
            {
                conection.Open();
                String query = "DELETE FROM Treatment WHERE treatment_id=@id";

                SqlCommand command = new SqlCommand(query, conection);

                command.Parameters.AddWithValue("id", actualTreatment);
                command.ExecuteNonQuery();
                MessageBox.Show("Tratamiento eliminado correctamente");

                conection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
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
