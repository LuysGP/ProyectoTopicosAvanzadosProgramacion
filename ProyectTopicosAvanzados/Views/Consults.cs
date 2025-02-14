﻿using System;
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
    public partial class Consults : Form
    {
        //Conexion a la base de datos
        SqlConnection conection = new SqlConnection(@"Data Source=DESKTOP-VKEH4OM;Initial Catalog = Clinica; integrated security=true");
        DataTable dataTable = new DataTable();
        public Consults()
        {
            InitializeComponent();
            SelectAllConsults();
        }
        //Seleccion de todas las consultas para llenar en la tabla
        private void SelectAllConsults()
        {
            try
            {
                conection.Open();
                String query = "SELECT register_date AS Fecha_Registro, sympton AS Sintomas, SS_number AS Numero_SS, register_id AS IDRegistro FROM Register";
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
