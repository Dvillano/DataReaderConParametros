using Datos.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPubs
{
    public partial class frmAuthors : Form
    {
        public frmAuthors()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridAuthors.DataSource = AdminAuthor.Listar();
            llenarCombo();
        }

        private void btnTraerCiudad_Click(object sender, EventArgs e)
        {
            string ciudad = txtCiudad.Text;
            gridAuthors.DataSource = AdminAuthor.Listar(ciudad);
        }

        private void btnTraerAutor_Click(object sender, EventArgs e)
        {
            gridAuthors.DataSource = AdminAuthor.Listar();
        }

        private void btnTraerAutorCiudadEstado_Click(object sender, EventArgs e)
        {
            string ciudad = txtCiudad.Text;
            string estado = txtEstado.Text;
            gridAuthors.DataSource = AdminAuthor.Listar(ciudad, estado);
        }

        private void cbCiudad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string ciudad = cbCiudad.SelectedValue.ToString();

            if (ciudad == "[ALL]")
            {
                gridAuthors.DataSource = AdminAuthor.ListarDataTable();
            }
            else
            {
                gridAuthors.DataSource = AdminAuthor.ListarDataTable(ciudad);
            }

        }

        private void llenarCombo()
        {
            DataTable dataTable = AdminCity.ListarSoloCiudades();

            cbCiudad.DataSource = dataTable;
            cbCiudad.DisplayMember = dataTable.Columns["city"].ToString();
            cbCiudad.ValueMember = dataTable.Columns["city"].ToString();

            // Agregar una fila al DataTable en memoria
            DataRow dataRow = dataTable.NewRow();
            dataRow["city"] = "[ALL]";
            dataTable.Rows.InsertAt(dataRow, 0);
        }

        private void btnTraerSoloCiudad_Click(object sender, EventArgs e)
        {
            gridAuthors.DataSource = AdminCity.ListarSoloCiudades();
        }
    }
}
