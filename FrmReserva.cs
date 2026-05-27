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
    public partial class FrmReserva : Form
    {
        public FrmReserva()
        {
            InitializeComponent();
        }

        private void FrmReserva_Load(object sender, EventArgs e)
        {

            cmbTipoVuelo.Items.Add("Económica");
            cmbTipoVuelo.Items.Add("Turista");
            cmbTipoVuelo.Items.Add("Ejecutivo");

            cmbTipoVuelo.SelectedIndex = 0;

            PasajeroBLL pasajeroBLL = new PasajeroBLL();

            cmbPasajero.DataSource = pasajeroBLL.Listar();
            cmbPasajero.DisplayMember = "Nombre";
            cmbPasajero.ValueMember = "Rut";

            VueloBLL vueloBLL = new VueloBLL();

            cmbNumVuelo.DataSource = vueloBLL.Listar();
            cmbNumVuelo.DisplayMember = "NumVlo";
            cmbNumVuelo.ValueMember = "NumVlo";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPasajero.SelectedIndex == -1 || cmbTipoVuelo.SelectedIndex == -1 || cmbNumVuelo.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtValor.Text))
                {
                    MessageBox.Show(
                        "Complete todos los campos");

                    return;
                }

                ReservaBLL bll = new ReservaBLL();

                bll.Insertar(cmbTipoVuelo.Text, Convert.ToDouble(txtValor.Text), cmbPasajero.SelectedValue.ToString(), cmbNumVuelo.SelectedValue.ToString());

                MessageBox.Show("Reserva guardada");

                txtValor.Clear();

                cmbPasajero.SelectedIndex = -1;
                cmbNumVuelo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
