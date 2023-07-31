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
    public partial class Form1 : Form
    {
        //Cadena de Conexion
        string cadena = "Data Source=LAPTOP-L79D624G\\SQLEXPRESS;Initial Catalog=Kamil;Integrated Security=True";
        public SqlConnection Conectarbd = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
            Conectarbd.ConnectionString = cadena;
            abrir();
            cerrar();
        }
        //Metodo para abrir la conexion
        public void abrir()
        {
            try
            {
                Conectarbd.Open();
                MessageBox.Show("Conexión abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("error al abrir BD " + ex.Message);
            }
        }
        //Metodo para cerrar la conexion
        public void cerrar()
        {
            Conectarbd.Close();
        }
    }
}
