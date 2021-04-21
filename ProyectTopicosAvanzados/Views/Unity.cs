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
    public partial class Unity : Form
    {
        public Unity()
        {
            InitializeComponent();
        }

        private void buttonRegisterConsult_Click(object sender, EventArgs e)
        {
            try
            {
                UnityDetails unityDetails = new UnityDetails(int.Parse(textBoxPlant.Text), textBoxName.Text, int.Parse(textBoxDoctorId.Text));
                unityDetails.Register();

                MessageBox.Show("Unidad registrada correctamente");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
    public class UnityDetails
    {
        int plant;
        string name;
        int doctor_id;

        SqlConnection conection = new SqlConnection(@"Data Source=DESKTOP-VKEH4OM;Initial Catalog = Clinica; integrated security=true");
        public UnityDetails(int plant, string name, int doctor_id)
        {
            this.doctor_id = doctor_id;
            this.name = name;
            this.plant = plant;
        }

        public void Register()
        {
            conection.Open();
            String query = "INSERT INTO Unity (unity_name, unity_plant, doctor_id) VALUES (@name, @plant, @doctor)";
            SqlCommand command = new SqlCommand(query, conection);
            command.Parameters.AddWithValue("@name", this.name);
            command.Parameters.AddWithValue("@plant", this.plant);
            command.Parameters.AddWithValue("@doctor", this.doctor_id);

            command.ExecuteNonQuery();
            conection.Close();
        }
    }
}
