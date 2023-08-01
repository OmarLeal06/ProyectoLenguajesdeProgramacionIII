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
    public partial class FormPuestos : Form
    {

        SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        public FormPuestos()
        {
            InitializeComponent();

            cn = new SqlConnection(@"Data Source=126013TP03CAT\SQLEXPRESS02; Initial Catalog=Kamil; Integrated Security=True");
            cn.Open();
            ObtenerCatalogoPuestos();
        }


        public void ObtenerCatalogoPuestos()
        {
            cmd = new SqlCommand("CatalogoPuestosCrudOperation", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Num_Puesto", 0);
            cmd.Parameters.AddWithValue("@Nombre", "");
            cmd.Parameters.AddWithValue("@Descripcion", "");
            cmd.Parameters.AddWithValue("@OperationType", "5");
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvPuestos.DataSource = dt;
        }
        private void txtbNumeroPuesto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarPuesto_Click(object sender, EventArgs e)
        {
            if (txtbNombrePuesto.Text != string.Empty && txtbDescripcionPuesto.Text != string.Empty)
            {
                cmd = new SqlCommand("CatalogoPuestosCrudOperation", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Num_Puesto", 0);
                cmd.Parameters.AddWithValue("@Nombre", txtbNombrePuesto.Text);
                cmd.Parameters.AddWithValue("@Descripcion", txtbDescripcionPuesto.Text);
                cmd.Parameters.AddWithValue("@OperationType", "1");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record inserted successfully.", "Record Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ObtenerCatalogoPuestos();
                txtbNumeroPuesto.Text = "";
                txtbNombrePuesto.Text = "";
                txtbDescripcionPuesto.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter value in all fields", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void btnModificarPuesto_Click(object sender, EventArgs e)
        {
            if (txtbNumeroPuesto.Text != string.Empty && txtbNombrePuesto.Text != string.Empty && txtbDescripcionPuesto.Text != string.Empty)
            {
                cmd = new SqlCommand("CatalogoPuestosCrudOperation", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Num_Puesto", txtbNumeroPuesto.Text);
                cmd.Parameters.AddWithValue("@Nombre", txtbNombrePuesto.Text);
                cmd.Parameters.AddWithValue("@Descripcion", txtbDescripcionPuesto.Text);
                cmd.Parameters.AddWithValue("@OperationType", "2");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record update successfully.", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ObtenerCatalogoPuestos();
                btnEliminarPuesto.Enabled = false;
                btnModificarPuesto.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please enter value in all fields", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminarPuesto_Click(object sender, EventArgs e)
        {
            if (txtbNumeroPuesto.Text != string.Empty)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this centro ? ", "Delete Centro", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dialogResult == DialogResult.Yes)
                {
                    cmd = new SqlCommand("CatalogoPuestosCrudOperation", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Num_Puesto", txtbNumeroPuesto.Text);
                    cmd.Parameters.AddWithValue("@Nombre", "");
                    cmd.Parameters.AddWithValue("@Descripcion", "");
                    cmd.Parameters.AddWithValue("@OperationType", "3");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record deleted successfully.", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ObtenerCatalogoPuestos();
                    txtbNumeroPuesto.Text = "";
                    txtbNombrePuesto.Text = "";
                    txtbDescripcionPuesto.Text = "";
                    btnEliminarPuesto.Enabled = false;
                    btnModificarPuesto.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Please enter employee id", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscarPuesto_Click(object sender, EventArgs e)
        {
            if (txtbNumeroPuesto.Text != string.Empty)
            {
                cmd = new SqlCommand("CatalogoPuestosCrudOperation", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Num_Puesto", txtbNumeroPuesto.Text);
                cmd.Parameters.AddWithValue("@Nombre", "");
                cmd.Parameters.AddWithValue("@Descripcion", "");
                cmd.Parameters.AddWithValue("@OperationType", "4");
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtbNombrePuesto.Text = dr["Nombre"].ToString();
                    txtbDescripcionPuesto.Text = dr["Descripcion"].ToString();
                    btnModificarPuesto.Enabled = true;
                    btnEliminarPuesto.Enabled = true;
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
    }
}
