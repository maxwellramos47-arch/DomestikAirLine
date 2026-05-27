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
    public partial class FrmPasajero : Form
    {
        public FrmPasajero()
        {
            InitializeComponent();

            cmbTipo.Items.Add("Normal");
            cmbTipo.Items.Add("Frecuente");

            cmbTipo.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtRut.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
                {
                    MessageBox.Show("Complete todos los campos");

                    return;
                }

                PasajeroBLL bll = new PasajeroBLL();

                bll.Insertar(txtRut.Text, txtNombre.Text, txtApellido.Text, cmbTipo.Text);

                MessageBox.Show("Pasajero guardado");

                txtRut.Clear();
                txtNombre.Clear();
                txtApellido.Clear();

                cmbTipo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
