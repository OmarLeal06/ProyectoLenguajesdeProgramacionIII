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
    public partial class FormEmpleados : Form
    {

        SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        public FormEmpleados()
        {
            InitializeComponent();

            cn = new SqlConnection(@"Data Source=126013TP03CAT\SQLEXPRESS02; Initial Catalog=Kamil; Integrated Security=True");
            cn.Open();

            ObtenerCatalogoEmpleados();


            using (SqlConnection con = cn)
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT Num_Centro, Nombre FROM Catalogo_Centros", con))
                {
                    //Fill the DataTable with records from Table.
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    //Insert the Default Item to DataTable.
                    DataRow row = dt.NewRow();
                    row[0] = 0;
                    row[1] = "Please select";
                    dt.Rows.InsertAt(row, 0);
                    //Assign DataTable as DataSource.
                    cbNumeroCentro.DataSource = dt;
                    cbNumeroCentro.DisplayMember = "Nombre";
                    cbNumeroCentro.ValueMember = "Num_Centro";
                }

                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT num_puesto, Nombre FROM catalogo_puestos", con))
                {
                    //Fill the DataTable with records from Table.
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    //Insert the Default Item to DataTable.
                    DataRow row = dt.NewRow();
                    row[0] = 0;
                    row[1] = "Please select";
                    dt.Rows.InsertAt(row, 0);
                    //Assign DataTable as DataSource.
                    cbNumeroPuesto.DataSource = dt;
                    cbNumeroPuesto.DisplayMember = "nombre";
                    cbNumeroPuesto.ValueMember = "num_puesto";
                }
            }

            
        }

        public void ObtenerCatalogoEmpleados()
        {
            cmd = new SqlCommand("[CatalogoEmpleadosCrudOperation]", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Num_Empleado", 0);
            cmd.Parameters.AddWithValue("@Nombre","");
            cmd.Parameters.AddWithValue("@Apellido_Paterno", "");
            cmd.Parameters.AddWithValue("@Apellido_Materno", "");
            cmd.Parameters.AddWithValue("@Fecha_Nacimiento", "");
            cmd.Parameters.AddWithValue("@RFC", "");
            cmd.Parameters.AddWithValue("@Num_centro", "");
            cmd.Parameters.AddWithValue("@Num_puesto", "");
            cmd.Parameters.AddWithValue("@OperationType", "5");
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvEmpleados.DataSource = dt;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=126013TP03CAT\SQLEXPRESS02; Initial Catalog=Kamil; Integrated Security=True");

            cn.Open();
            if (txtbNombre.Text != string.Empty && txtbApellidoPaterno.Text != string.Empty && txtbApellidoMaterno.Text != string.Empty && txtbFechaNacimiento.Text != string.Empty && txtbRFC.Text != string.Empty)
            {
                cmd = new SqlCommand("CatalogoEmpleadosCrudOperation", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Num_empleado", 0);
                cmd.Parameters.AddWithValue("@Nombre", txtbNombre.Text);
                cmd.Parameters.AddWithValue("@Apellido_Paterno", txtbApellidoPaterno.Text);
                cmd.Parameters.AddWithValue("@Apellido_Materno", txtbApellidoMaterno.Text);
                cmd.Parameters.AddWithValue("@Fecha_Nacimiento", txtbFechaNacimiento.Text);
                cmd.Parameters.AddWithValue("@RFC", txtbRFC.Text);
                cmd.Parameters.AddWithValue("@Num_centro", cbNumeroCentro.SelectedValue);
                cmd.Parameters.AddWithValue("@Num_puesto", cbNumeroPuesto.SelectedValue);
                cmd.Parameters.AddWithValue("@OperationType", "1");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record inserted successfully.", "Record Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ObtenerCatalogoEmpleados();
                txtbNumeroEmpleado.Text = "";
                txtbNombre.Text = "";
                txtbApellidoPaterno.Text = "";
                txtbApellidoMaterno.Text = "";
                txtbFechaNacimiento.Text = "";
                txtbRFC.Text = "";
                cbNumeroCentro.Text = "";
                cbNumeroPuesto.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter value in all fields", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtbNumeroEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificarEmpleado_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=126013TP03CAT\SQLEXPRESS02; Initial Catalog=Kamil; Integrated Security=True");

            cn.Open();
            if (txtbNombre.Text != string.Empty && txtbApellidoPaterno.Text != string.Empty && txtbApellidoMaterno.Text != string.Empty && txtbFechaNacimiento.Text != string.Empty && txtbRFC.Text != string.Empty)
            {
                cmd = new SqlCommand("CatalogoEmpleadosCrudOperation", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Num_empleado", txtbNumeroEmpleado.Text);
                cmd.Parameters.AddWithValue("@Nombre", txtbNombre.Text);
                cmd.Parameters.AddWithValue("@Apellido_Paterno", txtbApellidoPaterno.Text);
                cmd.Parameters.AddWithValue("@Apellido_Materno", txtbApellidoMaterno.Text);
                cmd.Parameters.AddWithValue("@Fecha_Nacimiento", txtbFechaNacimiento.Text);
                cmd.Parameters.AddWithValue("@RFC", txtbRFC.Text);
                cmd.Parameters.AddWithValue("@Num_centro", cbNumeroCentro.SelectedValue);
                cmd.Parameters.AddWithValue("@Num_puesto", cbNumeroPuesto.SelectedValue);
                cmd.Parameters.AddWithValue("@OperationType", "2");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record update successfully.", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ObtenerCatalogoEmpleados();
                btnEliminarEmpleado.Enabled = false;
                btnModificarEmpleado.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please enter value in all fields", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=126013TP03CAT\SQLEXPRESS02; Initial Catalog=Kamil; Integrated Security=True");

            cn.Open();
            if (txtbNumeroEmpleado.Text != string.Empty)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this centro ? ", "Delete Centro", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dialogResult == DialogResult.Yes)
                {
                    cmd = new SqlCommand("CatalogoEmpleadosCrudOperation", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Num_Empleado", txtbNumeroEmpleado.Text);
                    cmd.Parameters.AddWithValue("@Nombre", "");
                    cmd.Parameters.AddWithValue("@Apellido_Paterno", "");
                    cmd.Parameters.AddWithValue("@Apellido_Materno", "");
                    cmd.Parameters.AddWithValue("@Fecha_Nacimiento", "");
                    cmd.Parameters.AddWithValue("@RFC", "");
                    cmd.Parameters.AddWithValue("@Num_centro", "");
                    cmd.Parameters.AddWithValue("@Num_puesto", "");
                    cmd.Parameters.AddWithValue("@OperationType", "3");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record deleted successfully.", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ObtenerCatalogoEmpleados();
                    txtbNumeroEmpleado.Text = "";
                    txtbNombre.Text = "";
                    txtbApellidoPaterno.Text = "";
                    txtbApellidoMaterno.Text = "";
                    txtbFechaNacimiento.Text = "";
                    txtbRFC.Text = "";
                    cbNumeroCentro.Text = "";
                    cbNumeroPuesto.Text = "";
                    btnEliminarEmpleado.Enabled = false;
                    btnModificarEmpleado.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Please enter employee id", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=126013TP03CAT\SQLEXPRESS02; Initial Catalog=Kamil; Integrated Security=True");

            cn.Open();
            if (txtbNumeroEmpleado.Text != string.Empty)
            {
                cmd = new SqlCommand("CatalogoEmpleadosCrudOperation", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Num_Empleado", txtbNumeroEmpleado.Text);
                cmd.Parameters.AddWithValue("@Nombre", "");
                cmd.Parameters.AddWithValue("@Apellido_Paterno", "");
                cmd.Parameters.AddWithValue("@Apellido_Materno", "");
                cmd.Parameters.AddWithValue("@Fecha_Nacimiento", "");
                cmd.Parameters.AddWithValue("@RFC", "");
                cmd.Parameters.AddWithValue("@Num_centro", "");
                cmd.Parameters.AddWithValue("@Num_puesto", "");
                cmd.Parameters.AddWithValue("@OperationType", "4");
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtbNombre.Text = dr["Nombre"].ToString(); 
                    txtbApellidoPaterno.Text = dr["Apellido_paterno"].ToString();
                    txtbApellidoMaterno.Text = dr["Apellido_Materno"].ToString();
                    txtbFechaNacimiento.Text = dr["fecha_nacimiento"].ToString();
                    txtbRFC.Text = dr["RFC"].ToString();
                    cbNumeroCentro.Text = dr["nombre_Centro"].ToString();
                    cbNumeroPuesto.Text = dr["nombre_Puesto"].ToString();
                    btnModificarEmpleado.Enabled = true;
                    btnEliminarEmpleado.Enabled = true;
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
