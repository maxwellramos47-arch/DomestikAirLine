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
    public partial class FrmVuelo : Form
    {
        public FrmVuelo()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNumVuelo.Text) || string.IsNullOrWhiteSpace(txtDestino.Text))
                {
                    MessageBox.Show("Complete todos los campos");

                    return;
                }

                VueloBLL bll = new VueloBLL();

                bll.Insertar(txtNumVuelo.Text, txtDestino.Text, dtpFecha.Value, dtpHora.Value.TimeOfDay);

                MessageBox.Show("Vuelo guardado");

                txtNumVuelo.Clear();
                txtDestino.Clear();
                dtpHora.Value = DateTime.Now;
                dtpFecha.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
