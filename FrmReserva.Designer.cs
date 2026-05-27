namespace DomestikAirline
{
    partial class FrmReserva
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
            cmbTipoVuelo = new ComboBox();
            label4 = new Label();
            txtValor = new TextBox();
            cmbNumVuelo = new ComboBox();
            cmbPasajero = new ComboBox();
            btnIngresar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 159);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "Tipo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 216);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 1;
            label2.Text = "Valor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 48);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Pasajero";
            // 
            // cmbTipoVuelo
            // 
            cmbTipoVuelo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoVuelo.FormattingEnabled = true;
            cmbTipoVuelo.Location = new Point(196, 156);
            cmbTipoVuelo.Name = "cmbTipoVuelo";
            cmbTipoVuelo.Size = new Size(220, 23);
            cmbTipoVuelo.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 103);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 4;
            label4.Text = "Numero Vuelo";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(196, 213);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(220, 23);
            txtValor.TabIndex = 5;
            // 
            // cmbNumVuelo
            // 
            cmbNumVuelo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNumVuelo.FormattingEnabled = true;
            cmbNumVuelo.Location = new Point(196, 100);
            cmbNumVuelo.Name = "cmbNumVuelo";
            cmbNumVuelo.Size = new Size(220, 23);
            cmbNumVuelo.TabIndex = 6;
            // 
            // cmbPasajero
            // 
            cmbPasajero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPasajero.FormattingEnabled = true;
            cmbPasajero.Location = new Point(196, 45);
            cmbPasajero.Name = "cmbPasajero";
            cmbPasajero.Size = new Size(220, 23);
            cmbPasajero.TabIndex = 7;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(248, 309);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 8;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // FrmReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIngresar);
            Controls.Add(cmbPasajero);
            Controls.Add(cmbNumVuelo);
            Controls.Add(txtValor);
            Controls.Add(label4);
            Controls.Add(cmbTipoVuelo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmReserva";
            Text = "Ingresar Reserva";
            Load += FrmReserva_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbTipoVuelo;
        private Label label4;
        private TextBox txtValor;
        private ComboBox cmbNumVuelo;
        private ComboBox cmbPasajero;
        private Button btnIngresar;
    }
}