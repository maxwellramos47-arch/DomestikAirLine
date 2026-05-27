namespace DomestikAirline
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            lblConfirmar = new Label();
            txtConfirmar = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 117);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 180);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(236, 114);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(298, 23);
            txtUser.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(236, 177);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(298, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(616, 114);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(616, 177);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Registrarse";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblConfirmar
            // 
            lblConfirmar.AutoSize = true;
            lblConfirmar.Location = new Point(55, 251);
            lblConfirmar.Name = "lblConfirmar";
            lblConfirmar.Size = new Size(124, 15);
            lblConfirmar.TabIndex = 6;
            lblConfirmar.Text = "Confirmar Contraseña";
            // 
            // txtConfirmar
            // 
            txtConfirmar.Location = new Point(236, 248);
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.Size = new Size(298, 23);
            txtConfirmar.TabIndex = 7;
            txtConfirmar.UseSystemPasswordChar = true;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtConfirmar);
            Controls.Add(lblConfirmar);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmLogin";
            Text = "Inicio Sesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnRegister;
        private Label lblConfirmar;
        private TextBox txtConfirmar;
    }
}