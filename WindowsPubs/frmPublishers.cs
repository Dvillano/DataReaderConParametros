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
    public partial class frmPublishers : Form
    {


        public frmPublishers()
        {
            InitializeComponent();
        }

        private void frmPublishers_Load(object sender, EventArgs e)
        {
            gridPublisher.DataSource = AdminPublisher.Listar();
        }

        private void btnTraerCiudad_Click(object sender, EventArgs e)
        {
            string ciudad = txtCiudad.Text;
            gridPublisher.DataSource = AdminPublisher.Listar(ciudad);
        }

        private void btnTraerPublisher_Click(object sender, EventArgs e)
        {
            gridPublisher.DataSource = AdminPublisher.Listar();
        }

        private void btnTraerPublisherCiudadEstado_Click(object sender, EventArgs e)
        {
            string ciudad = txtCiudad.Text;
            string estado = txtEstado.Text;
            gridPublisher.DataSource = AdminPublisher.Listar(ciudad, estado);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ciudad = txtCiudad.Text;
            string estado = txtEstado.Text;
            string pais = txtPais.Text;
            gridPublisher.DataSource = AdminPublisher.Listar(ciudad, estado, pais);
        }
    }
}
