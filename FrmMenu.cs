using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DomestikAirline
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void AbrirForm(Form frm)
        {
            foreach (Form f in this.MdiChildren)
                f.Close();

            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void crearPasajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmPasajero());
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmListInfo());
        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmVuelo());
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmModVuelo());
        }

        private void ingresarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmReserva());
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmModReserva());
        }
    }
}
