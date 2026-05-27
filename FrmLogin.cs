using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DomestikAirline.BLL;

namespace DomestikAirline
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            txtConfirmar.Visible = false;
            lblConfirmar.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UsuarioBLL bll = new UsuarioBLL();

            bool acceso = bll.Ingresar(txtUser.Text, txtPassword.Text);

            if (acceso)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtConfirmar.Visible == false)
            {
                txtConfirmar.Visible = true;
                lblConfirmar.Visible = true;

                return;
            }

            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtConfirmar.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos");

                return;
            }

            UsuarioBLL bll = new UsuarioBLL();

            if (bll.ExisteUsuario(txtUser.Text))
            {
                MessageBox.Show("El usuario ya existe");

                return;
            }

            if (txtPassword.Text == txtConfirmar.Text)
            {
                bool registrado = bll.Registrar(txtUser.Text, txtPassword.Text);

                if (registrado)
                {
                    MessageBox.Show("Usuario Registrado");
                    txtConfirmar.Visible = false;
                    lblConfirmar.Visible = false;
                }
                else
                {
                    MessageBox.Show("Error al registrar usuario");
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
        }
    }
}
