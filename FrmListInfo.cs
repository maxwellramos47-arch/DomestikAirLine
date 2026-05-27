using DomestikAirline.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DomestikAirline
{
    public partial class FrmListInfo : Form
    {
        public FrmListInfo()
        {
            InitializeComponent();
        }

        private void FrmListInfo_Load(object sender, EventArgs e)
        {
            cmbTipoPasajero.Items.Add("Normal");
            cmbTipoPasajero.Items.Add("Frecuente");

            CargarPasajeros();
        }

        private void dgvListInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvListInfo.Rows[e.RowIndex];

                cmbTipoPasajero.Text = fila.Cells["Tipo"].Value.ToString();
            }
        }

        private void CargarPasajeros()
        {
            PasajeroBLL pasajeroBLL = new PasajeroBLL();

            dgvListInfo.DataSource = null;

            dgvListInfo.DataSource = pasajeroBLL.Listar();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            CargarPasajeros();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvListInfo.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un pasajero");

                    return;
                }

                string rut = dgvListInfo.CurrentRow.Cells["Rut"].Value.ToString();

                PasajeroBLL bll = new PasajeroBLL();

                bll.ActualizarTipo(rut, cmbTipoPasajero.Text);

                MessageBox.Show("Tipo actualizado");

                CargarPasajeros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
