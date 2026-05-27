namespace DomestikAirline
{
    partial class FrmModReserva
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
            dgvReserva = new DataGridView();
            cmbPasajero = new ComboBox();
            cmbVuelo = new ComboBox();
            cmbTipo = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtValor = new TextBox();
            label4 = new Label();
            btnList = new Button();
            btnMod = new Button();
            btnCondicion = new Button();
            lblCondicion = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReserva).BeginInit();
            SuspendLayout();
            // 
            // dgvReserva
            // 
            dgvReserva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReserva.Location = new Point(31, 22);
            dgvReserva.Name = "dgvReserva";
            dgvReserva.Size = new Size(527, 120);
            dgvReserva.TabIndex = 0;
            dgvReserva.CellClick += dgvReserva_CellClick;
            // 
            // cmbPasajero
            // 
            cmbPasajero.FormattingEnabled = true;
            cmbPasajero.Location = new Point(247, 174);
            cmbPasajero.Name = "cmbPasajero";
            cmbPasajero.Size = new Size(311, 23);
            cmbPasajero.TabIndex = 1;
            // 
            // cmbVuelo
            // 
            cmbVuelo.FormattingEnabled = true;
            cmbVuelo.Location = new Point(247, 230);
            cmbVuelo.Name = "cmbVuelo";
            cmbVuelo.Size = new Size(311, 23);
            cmbVuelo.TabIndex = 2;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(247, 288);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(311, 23);
            cmbTipo.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 177);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Pasajero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 233);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 5;
            label2.Text = "Vuelo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 291);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 6;
            label3.Text = "Tipo";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(247, 375);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(311, 23);
            txtValor.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 378);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 8;
            label4.Text = "Valor";
            // 
            // btnList
            // 
            btnList.Location = new Point(644, 72);
            btnList.Name = "btnList";
            btnList.Size = new Size(75, 23);
            btnList.TabIndex = 9;
            btnList.Text = "Refrescar";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnMod
            // 
            btnMod.Location = new Point(644, 229);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(75, 23);
            btnMod.TabIndex = 10;
            btnMod.Text = "Modificar";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btnMod_Click;
            // 
            // btnCondicion
            // 
            btnCondicion.Location = new Point(644, 327);
            btnCondicion.Name = "btnCondicion";
            btnCondicion.Size = new Size(75, 23);
            btnCondicion.TabIndex = 11;
            btnCondicion.Text = "Condicion";
            btnCondicion.UseVisualStyleBackColor = true;
            btnCondicion.Click += btnCondicion_Click;
            // 
            // lblCondicion
            // 
            lblCondicion.AutoSize = true;
            lblCondicion.Location = new Point(247, 331);
            lblCondicion.Name = "lblCondicion";
            lblCondicion.Size = new Size(62, 15);
            lblCondicion.TabIndex = 12;
            lblCondicion.Text = "Condicion";
            // 
            // FrmModReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCondicion);
            Controls.Add(btnCondicion);
            Controls.Add(btnMod);
            Controls.Add(btnList);
            Controls.Add(label4);
            Controls.Add(txtValor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbTipo);
            Controls.Add(cmbVuelo);
            Controls.Add(cmbPasajero);
            Controls.Add(dgvReserva);
            Name = "FrmModReserva";
            Text = "Modificar Reserva";
            Load += FrmModReserva_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReserva).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvReserva;
        private ComboBox cmbPasajero;
        private ComboBox cmbVuelo;
        private ComboBox cmbTipo;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtValor;
        private Label label4;
        private Button btnList;
        private Button btnMod;
        private Button btnCondicion;
        private Label lblCondicion;
    }
}