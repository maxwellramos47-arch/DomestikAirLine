namespace DomestikAirline
{
    partial class FrmModVuelo
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
            dgvVuelo = new DataGridView();
            txtDestino = new TextBox();
            dtpFecha = new DateTimePicker();
            dtpHora = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnList = new Button();
            btnMod = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVuelo).BeginInit();
            SuspendLayout();
            // 
            // dgvVuelo
            // 
            dgvVuelo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVuelo.Location = new Point(56, 37);
            dgvVuelo.Name = "dgvVuelo";
            dgvVuelo.Size = new Size(483, 137);
            dgvVuelo.TabIndex = 0;
            dgvVuelo.CellClick += dgvVuelo_CellClick;
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(224, 231);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(246, 23);
            txtDestino.TabIndex = 1;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(224, 282);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(246, 23);
            dtpFecha.TabIndex = 2;
            // 
            // dtpHora
            // 
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.Location = new Point(224, 331);
            dtpHora.Name = "dtpHora";
            dtpHora.ShowUpDown = true;
            dtpHora.Size = new Size(246, 23);
            dtpHora.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 234);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 4;
            label1.Text = "Destino";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 288);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "Fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(134, 337);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 6;
            label3.Text = "Hora";
            // 
            // btnList
            // 
            btnList.Location = new Point(641, 97);
            btnList.Name = "btnList";
            btnList.Size = new Size(75, 23);
            btnList.TabIndex = 7;
            btnList.Text = "Refrescar";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnMod
            // 
            btnMod.Location = new Point(641, 284);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(75, 23);
            btnMod.TabIndex = 8;
            btnMod.Text = "Modificar";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btnMod_Click;
            // 
            // FrmModVuelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMod);
            Controls.Add(btnList);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpHora);
            Controls.Add(dtpFecha);
            Controls.Add(txtDestino);
            Controls.Add(dgvVuelo);
            Name = "FrmModVuelo";
            Text = "Modificar Vuelos";
            Load += FrmModVuelo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVuelo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVuelo;
        private TextBox txtDestino;
        private DateTimePicker dtpFecha;
        private DateTimePicker dtpHora;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnList;
        private Button btnMod;
    }
}