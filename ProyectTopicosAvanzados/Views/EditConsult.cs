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
    public partial class EditConsult : Form
    {
        SqlConnection cnt = new SqlConnection(@"Data Source=DESKTOP-VKEH4OM;Initial Catalog = Clinica; integrated security=true");
        ConsultDetail consult = new ConsultDetail();
        public int consultActual;
        public EditConsult()
        {
            InitializeComponent();
            SelectAllConsults();
        }
        private void SelectAllConsults()
        {
            try
            {
                cnt.Open();
                String query = "SELECT register_id FROM Register";

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
                    textBoxID.Items.Add(sqlDataReader[0]);
                }
                cnt.Close();
            }

            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }
        private void buttonUpdateConsult_Click(object sender, EventArgs e)
        {
            try
            {
                cnt.Open();
                string query = $"UPDATE register SET register_date=@date, sympton=@sympton, SS_number=@ss WHERE register_id=@registerId";

                SqlCommand command = new SqlCommand(query, cnt);

                command.Parameters.AddWithValue("@date", textBoxRegister.Value);
                command.Parameters.AddWithValue("@sympton", textBoxSymptom.Text);
                command.Parameters.AddWithValue("@ss", int.Parse(textBoxPatient.Text));
                command.Parameters.AddWithValue("@registerId", consultActual);

                command.ExecuteNonQuery();

                cnt.Close();

                MessageBox.Show("Consulta actualizada correctamente");
            }
            catch (Exception en)
            {
                MessageBox.Show(en.Message);
            }
       }

        private void buttonDeleteConsult_Click(object sender, EventArgs e)
        {
            try
            {
                cnt.Open();
                String query = "DELETE FROM register WHERE register_id=@registerId";

                SqlCommand command = new SqlCommand(query, cnt);
                command.Parameters.AddWithValue("registerId", consultActual);
                command.ExecuteNonQuery();
                MessageBox.Show("Consulta eliminada correctamente");

                cnt.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void buttonSearchConsult_Click(object sender, EventArgs e)
        {
            try
            {
                cnt.Open();
                String query = $"SELECT register_date, sympton, SS_number FROM Register WHERE register_id = {int.Parse(textBoxID.Text)}";

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
                    consult.registerDate = (DateTime)sqlDataReader[0];
                    textBoxRegister.Value = consult.registerDate;
                    consult.sympton = sqlDataReader[1].ToString();
                    textBoxSymptom.Text = consult.sympton;
                    
                    if(sqlDataReader[2].ToString().Length == 0)
                    {
                        consult.SS_number = 0;
                        textBoxPatient.Text = "0";
                    }
                    else
                    {
                        consult.SS_number = int.Parse(sqlDataReader[2].ToString());
                        textBoxPatient.Text = consult.SS_number.ToString();
                    }

                    buttonUpdateConsult.Enabled = true;
                    buttonUpdateConsult.Enabled = true;
                    consultActual = int.Parse(textBoxID.Text);

                }
                cnt.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }

    public class ConsultDetail
    {
        public DateTime registerDate = new DateTime();
        public string sympton;
        public int SS_number;
    }
}
