using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Lenguaje_de_Programacion_III
{
    public partial class FormCentros : Form
    {

        SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        public FormCentros()
        {
            InitializeComponent();

            cn = new SqlConnection(@"Data Source=126013TP03CAT\SQLEXPRESS02; Initial Catalog=Kamil; Integrated Security=True");
            cn.Open();
            ObtenerCatalogoCentros();
        }

        public void ObtenerCatalogoCentros()
        {
            cmd = new SqlCommand("CatalogoCentrosCrudOperation", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Num_Centro", 0);
            cmd.Parameters.AddWithValue("@Nombre", "");
            cmd.Parameters.AddWithValue("@Ciudad", "");
            cmd.Parameters.AddWithValue("@OperationType", "5");
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvCentros.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarCentro_Click(object sender, EventArgs e)
        {

            if (txtbNombreCentro.Text != string.Empty && txtbCiudad.Text != string.Empty)
            {
                cmd = new SqlCommand("CatalogoCentrosCrudOperation", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Num_Centro", 0);
                cmd.Parameters.AddWithValue("@Nombre", txtbNombreCentro.Text);
                cmd.Parameters.AddWithValue("@Ciudad", txtbCiudad.Text);
                cmd.Parameters.AddWithValue("@OperationType", "1");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record inserted successfully.", "Record Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ObtenerCatalogoCentros();
                txtbNumeroCentro.Text = "";
                txtbNombreCentro.Text = "";
                txtbCiudad.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter value in all fields", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnModificarCentro_Click(object sender, EventArgs e)
        {

            if (txtbNumeroCentro.Text != string.Empty && txtbNombreCentro.Text != string.Empty && txtbCiudad.Text != string.Empty)
            {
                cmd = new SqlCommand("CatalogoCentrosCrudOperation", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Num_Centro", txtbNumeroCentro.Text);
                cmd.Parameters.AddWithValue("@Nombre", txtbNombreCentro.Text);
                cmd.Parameters.AddWithValue("@Ciudad", txtbCiudad.Text);
                cmd.Parameters.AddWithValue("@OperationType", "2");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record update successfully.", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ObtenerCatalogoCentros();
                btnEliminarCentro.Enabled = false;
                btnModificarCentro.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please enter value in all fields", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnEliminarCentro_Click(object sender, EventArgs e)
        {
            if (txtbNumeroCentro.Text != string.Empty)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this centro ? ", "Delete Centro", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dialogResult == DialogResult.Yes)
                {
                    cmd = new SqlCommand("CatalogoCentrosCrudOperation", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Num_Centro", txtbNumeroCentro.Text);
                    cmd.Parameters.AddWithValue("@Nombre", "");
                    cmd.Parameters.AddWithValue("@Ciudad", "");
                    cmd.Parameters.AddWithValue("@OperationType", "3");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record deleted successfully.", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ObtenerCatalogoCentros();
                    txtbNumeroCentro.Text = "";
                    txtbNombreCentro.Text = "";
                    txtbCiudad.Text = "";
                    btnEliminarCentro.Enabled = false;
                    btnModificarCentro.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Please enter employee id", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    


        private void btnBuscarCentro_Click(object sender, EventArgs e)
        {
            if (txtbNumeroCentro.Text != string.Empty)
            {
                cmd = new SqlCommand("CatalogoCentrosCrudOperation", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Num_Centro", txtbNumeroCentro.Text);
                cmd.Parameters.AddWithValue("@Nombre", "");
                cmd.Parameters.AddWithValue("@Ciudad", "");
                cmd.Parameters.AddWithValue("@OperationType", "4");
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtbNombreCentro.Text = dr["Nombre"].ToString();
                    txtbCiudad.Text = dr["Ciudad"].ToString();
                    btnModificarCentro.Enabled = true;
                    btnEliminarCentro.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No record found with this id", "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dr.Close();
            }
            else
            {
                MessageBox.Show("Please enter employee id ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtbNombreCentro_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtbCiudad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
