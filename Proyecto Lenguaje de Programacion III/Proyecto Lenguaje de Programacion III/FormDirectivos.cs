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
    public partial class FormDirectivos : Form
    {

        SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        public FormDirectivos()
        {
            InitializeComponent();

            cn = new SqlConnection(@"Data Source=126013TP03CAT\SQLEXPRESS02; Initial Catalog=Kamil; Integrated Security=True");
            cn.Open();
            ObtenerCatalogoDirectivos();
        }

        public void ObtenerCatalogoDirectivos()
        {
            cmd = new SqlCommand("CatalogoDirectivosCrudOperation", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Num_Directivo", 0);
            cmd.Parameters.AddWithValue("@CentroSupervisado", "");
            cmd.Parameters.AddWithValue("@Prestacion", "");
            cmd.Parameters.AddWithValue("@Num_empleado", "");
            cmd.Parameters.AddWithValue("@OperationType", "5");
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDirectivos.DataSource = dt;
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarDirectivo_Click(object sender, EventArgs e)
        {
            if (txtbCentroSupervisado.Text != string.Empty && txtbPrestacion.Text != string.Empty && txtbNumeroEmpleado.Text != string.Empty)
            {
                cmd = new SqlCommand("CatalogoDirectivosCrudOperation", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Num_Directivo", 0);
                cmd.Parameters.AddWithValue("@CentroSupervisado", txtbCentroSupervisado.Text);
                cmd.Parameters.AddWithValue("@Prestacion",txtbPrestacion.Text);
                cmd.Parameters.AddWithValue("@Num_empleado",txtbNumeroEmpleado.Text);
                cmd.Parameters.AddWithValue("@OperationType", "1");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record inserted successfully.", "Record Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ObtenerCatalogoDirectivos();
                txtbNumeroDirectivo.Text = "";
                txtbCentroSupervisado.Text = "";
                txtbPrestacion.Text = "";
                txtbNumeroEmpleado.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter value in all fields", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModificarDirectivo_Click(object sender, EventArgs e)
        {
            if (txtbCentroSupervisado.Text != string.Empty && txtbPrestacion.Text != string.Empty && txtbNumeroEmpleado.Text != string.Empty)
            {
                cmd = new SqlCommand("CatalogoDirectivosCrudOperation", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Num_Directivo", txtbNumeroDirectivo.Text);
                cmd.Parameters.AddWithValue("@CentroSupervisado", txtbCentroSupervisado.Text);
                cmd.Parameters.AddWithValue("@Prestacion", txtbPrestacion.Text);
                cmd.Parameters.AddWithValue("@Num_empleado", txtbNumeroEmpleado.Text);
                cmd.Parameters.AddWithValue("@OperationType", "2");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record update successfully.", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ObtenerCatalogoDirectivos();
                btnEliminarDirectivo.Enabled = false;
                btnModificarDirectivo.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please enter value in all fields", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminarDirectivo_Click(object sender, EventArgs e)
        {
            if (txtbNumeroDirectivo.Text != string.Empty)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this centro ? ", "Delete Centro", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dialogResult == DialogResult.Yes)
                {
                    cmd = new SqlCommand("CatalogoDirectivosCrudOperation", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Num_Directivo", txtbNumeroDirectivo.Text);
                    cmd.Parameters.AddWithValue("@CentroSupervisado", "");
                    cmd.Parameters.AddWithValue("@Prestacion", "");
                    cmd.Parameters.AddWithValue("@Num_empleado", "");
                    cmd.Parameters.AddWithValue("@OperationType", "3");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record deleted successfully.", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ObtenerCatalogoDirectivos();
                    txtbNumeroDirectivo.Text = "";
                    txtbCentroSupervisado.Text = "";
                    txtbPrestacion.Text = "";
                    txtbNumeroEmpleado.Text = "";
                    btnEliminarDirectivo.Enabled = false;
                    btnModificarDirectivo.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Please enter employee id", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscarDirectivo_Click(object sender, EventArgs e)
        {
            if (txtbNumeroDirectivo.Text != string.Empty)
            {
                cmd = new SqlCommand("CatalogoDirectivosCrudOperation", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Num_directivo", txtbNumeroDirectivo.Text);
                cmd.Parameters.AddWithValue("@CentroSupervisado", "");
                cmd.Parameters.AddWithValue("@Prestacion", "");
                cmd.Parameters.AddWithValue("@Num_empleado", "");
                cmd.Parameters.AddWithValue("@OperationType", "4");
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtbCentroSupervisado.Text = dr["centro_sup"].ToString();
                    txtbPrestacion.Text = dr["prestacion_comb"].ToString();
                    txtbNumeroEmpleado.Text = dr["num_empleado"].ToString();
                    btnModificarDirectivo.Enabled = true;
                    btnEliminarDirectivo.Enabled = true;
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
