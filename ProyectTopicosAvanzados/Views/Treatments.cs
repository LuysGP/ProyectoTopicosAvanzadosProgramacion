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
    public partial class Treatments : Form
    {
        SqlConnection conection = new SqlConnection(@"Data Source=DESKTOP-VKEH4OM;Initial Catalog = Clinica; integrated security=true");
        DataTable dataTable = new DataTable();
        public Treatments()
        {
            InitializeComponent();
            SelectAllTreatments();
        }
        private void SelectAllTreatments()
        {
            try
            {
                conection.Open();
                String query = "SELECT * FROM Treatment";
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
