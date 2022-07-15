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
using System.Configuration;

namespace PobreTITO
{
    public partial class Reclamo : Form
    {
        private SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Matias Morero\Desktop\TPsDS\PobreTITO_Git\PobreTITO\BD\BD.mdf;Integrated Security=True");

        public Reclamo()
        {
            InitializeComponent();
        }

        public void llenarCBIncidente()
        {
            conexion.Open();
            SqlCommand select = new SqlCommand("select * from Incidente", conexion);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(select);
            adapter.Fill(data);
            conexion.Close();
            cb_Incidente.DisplayMember = "tipo";
            cb_Incidente.ValueMember = "Id";
            cb_Incidente.DataSource = data;

        }

        public void llenarCBSubIncidente(int incidente_id)
        {
            conexion.Open();
            SqlCommand select = new SqlCommand($"select * from SubIncidente where Incidente_Id = {incidente_id}", conexion);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(select);
            adapter.Fill(data);
            conexion.Close();
            cb_subIncidente.DisplayMember = "tipo";
            cb_subIncidente.ValueMember = "Id";
            cb_subIncidente.DataSource = data;

        }

        private void Reclamo_Load(object sender, EventArgs e) //Para cuando se carge el form 
        {
            llenarCBIncidente();
        }

        private void cb_Incidente_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = (int)cb_Incidente.SelectedValue;
            if ((int)cb_Incidente.SelectedIndex != -1)
            {
                llenarCBSubIncidente(id);
            }
        }

        private void btn_RealizarReclamo_Click(object sender, EventArgs e)
        {

            Program.gestorPobreTITO.RegistrarReclamo(txt_Direccion.Text, txt_Descripcion.Text, (int)cb_subIncidente.SelectedValue);
        }

        private void txt_Direccion_MouseEnter(object sender, EventArgs e)
        {

        }

        // MARCAS DE AGUA (WATERMARK)

        private void txt_Direccion_Enter(object sender, EventArgs e)
        {
            if (txt_Direccion.Text == "Direccion")
            {
                txt_Direccion.Text = "";
                txt_Direccion.ForeColor = Color.Black;
            }
        }

        private void txt_Direccion_Leave(object sender, EventArgs e)
        {
            if (txt_Direccion.Text == "")
            {
                txt_Direccion.Text = "Direccion";
                txt_Direccion.ForeColor = Color.DimGray;
            }
        }

        private void txt_Descripcion_Enter(object sender, EventArgs e)
        {
            if (txt_Descripcion.Text == "Descripcion")
            {
                txt_Descripcion.Text = "";
                txt_Descripcion.ForeColor = Color.Black;
            }
        }

        private void txt_Descripcion_Leave(object sender, EventArgs e)
        {
            if (txt_Descripcion.Text == "")
            {
                txt_Descripcion.Text = "Descripcion";
                txt_Descripcion.ForeColor = Color.DimGray;
            }
        }

        // VALIDACIONES

        Validaciones validaciones = new Validaciones(); // Se crea objeto/instancia.

        private void txt_Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validarLetrasNumeros(e);
        }

        private void txt_Descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.validarLetrasNumeros(e);
        }
    }
}
