namespace DomestikAirline
{
    partial class FrmVuelo
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
            dtpFecha = new DateTimePicker();
            dtpHora = new DateTimePicker();
            txtDestino = new TextBox();
            btnCrear = new Button();
            label4 = new Label();
            txtNumVuelo = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 137);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 196);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 1;
            label2.Text = "Hora";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 254);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "Destino";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(203, 131);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 3;
            // 
            // dtpHora
            // 
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.Location = new Point(203, 190);
            dtpHora.Name = "dtpHora";
            dtpHora.ShowUpDown = true;
            dtpHora.Size = new Size(200, 23);
            dtpHora.TabIndex = 4;
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(203, 251);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(200, 23);
            txtDestino.TabIndex = 5;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(259, 340);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 6;
            btnCrear.Text = "Guardar";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 71);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 7;
            label4.Text = "Numero Vuelo";
            // 
            // txtNumVuelo
            // 
            txtNumVuelo.CharacterCasing = CharacterCasing.Upper;
            txtNumVuelo.Location = new Point(203, 68);
            txtNumVuelo.Name = "txtNumVuelo";
            txtNumVuelo.Size = new Size(200, 23);
            txtNumVuelo.TabIndex = 8;
            // 
            // FrmVuelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNumVuelo);
            Controls.Add(label4);
            Controls.Add(btnCrear);
            Controls.Add(txtDestino);
            Controls.Add(dtpHora);
            Controls.Add(dtpFecha);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmVuelo";
            Text = "Ingresar Vuelo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpFecha;
        private DateTimePicker dtpHora;
        private TextBox txtDestino;
        private Button btnCrear;
        private Label label4;
        private TextBox txtNumVuelo;
    }
}