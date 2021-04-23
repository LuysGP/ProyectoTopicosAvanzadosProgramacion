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
    public partial class Doctors : Form
    {
        SqlConnection conection = new SqlConnection(@"Data Source=DESKTOP-VKEH4OM;Initial Catalog = Clinica; integrated security=true");
        DataTable dataTable = new DataTable();

        public Doctors()
        {
            InitializeComponent();
            SelectAllDoctors();
        }

        private void SelectAllDoctors()
        {
            try
            {
                conection.Open();
                String query = "SELECT doctor_id AS ID, doctor_speciality AS Especialidad, doctor_name AS Nombre FROM Doctor";
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
    }
}
