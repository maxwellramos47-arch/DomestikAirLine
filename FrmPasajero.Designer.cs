namespace DomestikAirline
{
    partial class FrmPasajero
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
            label3 = new Label();
            label4 = new Label();
            txtRut = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            cmbTipo = new ComboBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 68);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 0;
            label1.Text = "Rut";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 114);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 164);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 217);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 3;
            label4.Text = "Tipo";
            // 
            // txtRut
            // 
            txtRut.Location = new Point(208, 65);
            txtRut.Name = "txtRut";
            txtRut.Size = new Size(235, 23);
            txtRut.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(208, 111);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(235, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(208, 161);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(235, 23);
            txtApellido.TabIndex = 6;
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(208, 214);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(235, 23);
            cmbTipo.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(289, 308);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(cmbTipo);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtRut);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmPasajero";
            Text = "Ingresar Pasajero";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtRut;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private ComboBox cmbTipo;
        private Button btnGuardar;
    }
}