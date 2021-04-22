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
    public partial class EditUnity : Form
    {
        SqlConnection conection = new SqlConnection(@"Data Source=DESKTOP-VKEH4OM;Initial Catalog = Clinica; integrated security=true");
        EditUnityDetails EditUnityDetails = new EditUnityDetails();

        int actualUnity;

        public EditUnity()
        {
            InitializeComponent();
        }

        private void buttonUpdateUnit_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteUnity_Click(object sender, EventArgs e)
        {
            try
            {
                conection.Open();
                String query = "DELETE FROM Unity WHERE unity_id = @id";
                SqlCommand command = new SqlCommand(query, conection);

                command.Parameters.AddWithValue("id", actualUnity);

                command.ExecuteNonQuery();

                MessageBox.Show("Unidad eliminada correctamente");
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

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

                    EditUnityDetails.doctor = int.Parse(SqlDataReader[2].ToString());
                    textBoxDoctorId.Text = EditUnityDetails.doctor.ToString();

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
    public class EditUnityDetails
    {
        public string name;
        public string plant;
        public int doctor;

        public EditUnityDetails() { }
    }
}
