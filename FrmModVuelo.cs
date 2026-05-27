using DomestikAirline.BLL;
using System;
using System.Windows.Forms;

namespace DomestikAirline
{
    public partial class FrmModVuelo : Form
    {
        public FrmModVuelo()
        {
            InitializeComponent();
        }

        private void FrmModVuelo_Load(object sender, EventArgs e)
        {
            CargarVuelos();
        }

        private void CargarVuelos()
        {
            VueloBLL bll = new VueloBLL();

            dgvVuelo.DataSource = null;

            dgvVuelo.DataSource =
                bll.Listar();
        }

        private void dgvVuelo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvVuelo.Rows[e.RowIndex];

                txtDestino.Text = fila.Cells["Destino"].Value?.ToString();

                if (fila.Cells["Fecha"].Value != null)
                {
                    DateTime fecha;

                    if (DateTime.TryParse(fila.Cells["Fecha"].Value.ToString(), out fecha))
                    {
                        dtpFecha.Value = fecha;
                    }
                }

                if (fila.Cells["Hora"].Value != null)
                {
                    TimeSpan hora;

                    if (TimeSpan.TryParse(fila.Cells["Hora"].Value.ToString(), out hora))
                    {
                        dtpHora.Value = DateTime.Today.Add(hora);
                    }
                }
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            CargarVuelos();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVuelo.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un vuelo");

                    return;
                }

                if (string.IsNullOrWhiteSpace(txtDestino.Text))
                {
                    MessageBox.Show("Complete el destino");

                    return;
                }

                string numvlo = dgvVuelo.CurrentRow.Cells["NumVlo"].Value.ToString();

                VueloBLL bll = new VueloBLL();

                bll.Actualizar(numvlo, dtpFecha.Value, dtpHora.Value.TimeOfDay, txtDestino.Text);

                MessageBox.Show("Vuelo actualizado");

                CargarVuelos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message);
            }
        }
    }
}