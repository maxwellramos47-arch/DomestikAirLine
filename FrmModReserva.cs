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
    public partial class FrmModReserva : Form
    {
        public FrmModReserva()
        {
            InitializeComponent();
        }

        private void FrmModReserva_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.Add("Económica");
            cmbTipo.Items.Add("Turista");
            cmbTipo.Items.Add("Ejecutivo");

            CargarReservas();
            CargarPasajeros();
            CargarVuelos();
        }

        private void dgvReserva_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvReserva.Rows[e.RowIndex];

                cmbTipo.Text = fila.Cells["Tipo"].Value.ToString();

                txtValor.Text = fila.Cells["Valor"].Value.ToString();

                cmbPasajero.Text = fila.Cells["Rut"].Value.ToString();

                cmbVuelo.Text = fila.Cells["NumVlo"].Value.ToString();
            }
        }

        private void CargarReservas()
        {
            ReservaBLL bll = new ReservaBLL();

            dgvReserva.DataSource = null;

            dgvReserva.DataSource = bll.Listar();
        }

        private void CargarPasajeros()
        {
            PasajeroBLL bll = new PasajeroBLL();

            cmbPasajero.DataSource = bll.Listar();
            cmbPasajero.DisplayMember = "Rut";
            cmbPasajero.ValueMember = "Rut";
        }

        private void CargarVuelos()
        {
            VueloBLL bll = new VueloBLL();

            cmbVuelo.DataSource = bll.Listar();
            cmbVuelo.DisplayMember = "NumVlo";
            cmbVuelo.ValueMember = "NumVlo";
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            CargarPasajeros();
            CargarReservas();
            CargarVuelos();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReserva.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione una reserva");

                    return;
                }

                int codigo = Convert.ToInt32(dgvReserva.CurrentRow.Cells["Codigo"].Value);

                ReservaBLL bll = new ReservaBLL();

                bll.Actualizar(codigo, cmbTipo.Text, Convert.ToDouble(txtValor.Text), cmbPasajero.Text, cmbVuelo.Text);

                MessageBox.Show("Reserva actualizada");

                CargarReservas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCondicion_Click(object sender, EventArgs e)
        {
            ReservaBLL bll = new ReservaBLL();

            string condicion = bll.ObtenerCondicion(cmbTipo.Text);

            lblCondicion.Text = condicion;
        }
    }
}
