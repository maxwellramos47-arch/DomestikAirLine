namespace DomestikAirline
{
    partial class FrmListInfo
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
            dgvListInfo = new DataGridView();
            cmbTipoPasajero = new ComboBox();
            label1 = new Label();
            btnMod = new Button();
            btnList = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListInfo).BeginInit();
            SuspendLayout();
            // 
            // dgvListInfo
            // 
            dgvListInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListInfo.Location = new Point(32, 23);
            dgvListInfo.Name = "dgvListInfo";
            dgvListInfo.Size = new Size(552, 338);
            dgvListInfo.TabIndex = 0;
            dgvListInfo.CellClick += dgvListInfo_CellClick;
            // 
            // cmbTipoPasajero
            // 
            cmbTipoPasajero.FormattingEnabled = true;
            cmbTipoPasajero.Location = new Point(191, 395);
            cmbTipoPasajero.Name = "cmbTipoPasajero";
            cmbTipoPasajero.Size = new Size(218, 23);
            cmbTipoPasajero.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 398);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 2;
            label1.Text = "Tipo Pasajero";
            // 
            // btnMod
            // 
            btnMod.Location = new Point(433, 395);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(75, 23);
            btnMod.TabIndex = 3;
            btnMod.Text = "Modificar";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btnMod_Click;
            // 
            // btnList
            // 
            btnList.Location = new Point(649, 173);
            btnList.Name = "btnList";
            btnList.Size = new Size(75, 23);
            btnList.TabIndex = 4;
            btnList.Text = "Refrescar";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // FrmListInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnList);
            Controls.Add(btnMod);
            Controls.Add(label1);
            Controls.Add(cmbTipoPasajero);
            Controls.Add(dgvListInfo);
            Name = "FrmListInfo";
            Text = "Listar Pasajeros";
            Load += FrmListInfo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListInfo;
        private ComboBox cmbTipoPasajero;
        private Label label1;
        private Button btnMod;
        private Button btnList;
    }
}