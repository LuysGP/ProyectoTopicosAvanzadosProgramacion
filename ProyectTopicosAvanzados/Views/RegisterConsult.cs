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
    public partial class RegisterConsult : Form
    {
        ConsultDetails ConsultDetails;
        EditPatient editPatient = new EditPatient();

        public RegisterConsult()
        {

            InitializeComponent();
            editPatient.SelectAllPatients(textBoxPatient);
        }
        
        //Boton para registrar las consultas (altas)
        private void buttonRegisterConsult_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultDetails = new ConsultDetails(int.Parse(textBoxPatient.Text), textBoxSymptom.Text);

                ConsultDetails.Register();

                MessageBox.Show("Consulta registrada correctamente");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }

    //Clase creada para almacenar los datos ingresados y mandarlos a la base datos 
    public class ConsultDetails
    {
        int patient;
        string symptom;
        SqlConnection conection = new SqlConnection(@"Data Source=DESKTOP-VKEH4OM;Initial Catalog = Clinica; integrated security=true");
        DateTime date = new DateTime();
        
        //En este constructor guardamos los paramatros enviados desde el objeto creado
        public ConsultDetails(int patient, string symptom)
        {
            this.patient = patient;
            this.symptom = symptom;
            this.date = DateTime.Now;
        }
        
        //Metodo para enviar todas las consultas registradas
        public void Register()
        {
            conection.Open();
            String query = "INSERT INTO Register (register_date, sympton, SS_number) VALUES (@date, @symptom, @patient)";
            SqlCommand command = new SqlCommand(query, conection);
            command.Parameters.AddWithValue("@date", this.date);
            command.Parameters.AddWithValue("@symptom", this.symptom);
            command.Parameters.AddWithValue("@patient", this.patient);
            command.ExecuteNonQuery();
            conection.Close();
        }
    }
}
