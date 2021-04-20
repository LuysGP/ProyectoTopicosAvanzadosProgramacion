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
    public partial class RegisterDoctor : Form
    {
        DoctorsDetail doctor;
        public RegisterDoctor()
        {
            InitializeComponent();
        }
        private void buttonRegisterConsult_Click(object sender, EventArgs e)
        {
            try
            {
                doctor = new DoctorsDetail(textBoxEspeciality.Text, textBoxName.Text);
                doctor.Register();
                MessageBox.Show("Doctor registrado correctamente");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
    public class DoctorsDetail
    {
        public string doctor_speciality;
        public string doctor_name;
        SqlConnection conection = new SqlConnection(@"Data Source=DESKTOP-VKEH4OM;Initial Catalog = Clinica; integrated security=true");
        public DoctorsDetail(string doc_speciality, string doc_name)
        {
            this.doctor_speciality = doc_speciality;
            this.doctor_name = doc_name;
        }
        public void Register()
        {
            conection.Open();
            String query = "INSERT INTO Doctor (doctor_speciality, doctor_name) VALUES (@speciality, @name)";
            SqlCommand command = new SqlCommand(query, conection);
            command.Parameters.AddWithValue("@speciality", this.doctor_speciality);
            command.Parameters.AddWithValue("@name", this.doctor_name);
            command.ExecuteNonQuery();
            conection.Close();
        }
    }
}
