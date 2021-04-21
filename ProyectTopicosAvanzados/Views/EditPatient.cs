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
    }
    public class EditPatientDetails
    {
        public DateTime date = new DateTime();
        public int unity;
        public int age;
        public string name;
        public EditPatientDetails() { }
        public EditPatientDetails(int unity, int age, string name, DateTime date)
        {
            this.name = name;
            this.age = age;
            this.date = date;
            this.unity = unity;
        }
    }
}
