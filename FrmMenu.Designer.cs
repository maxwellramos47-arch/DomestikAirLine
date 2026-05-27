namespace DomestikAirline
{
    partial class FrmMenu
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
            menuStrip1 = new MenuStrip();
            pasajeroToolStripMenuItem = new ToolStripMenuItem();
            crearPasajeroToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            vueloToolStripMenuItem = new ToolStripMenuItem();
            ingresarToolStripMenuItem = new ToolStripMenuItem();
            modificarToolStripMenuItem1 = new ToolStripMenuItem();
            reservaToolStripMenuItem = new ToolStripMenuItem();
            ingresarToolStripMenuItem1 = new ToolStripMenuItem();
            modificarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { pasajeroToolStripMenuItem, vueloToolStripMenuItem, reservaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // pasajeroToolStripMenuItem
            // 
            pasajeroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearPasajeroToolStripMenuItem, consultarToolStripMenuItem });
            pasajeroToolStripMenuItem.Name = "pasajeroToolStripMenuItem";
            pasajeroToolStripMenuItem.Size = new Size(63, 20);
            pasajeroToolStripMenuItem.Text = "Pasajero";
            // 
            // crearPasajeroToolStripMenuItem
            // 
            crearPasajeroToolStripMenuItem.Name = "crearPasajeroToolStripMenuItem";
            crearPasajeroToolStripMenuItem.Size = new Size(193, 22);
            crearPasajeroToolStripMenuItem.Text = "Ingresar";
            crearPasajeroToolStripMenuItem.Click += crearPasajeroToolStripMenuItem_Click;
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(193, 22);
            consultarToolStripMenuItem.Text = "Consultar informacion";
            consultarToolStripMenuItem.Click += consultarToolStripMenuItem_Click;
            // 
            // vueloToolStripMenuItem
            // 
            vueloToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ingresarToolStripMenuItem, modificarToolStripMenuItem1 });
            vueloToolStripMenuItem.Name = "vueloToolStripMenuItem";
            vueloToolStripMenuItem.Size = new Size(49, 20);
            vueloToolStripMenuItem.Text = "Vuelo";
            // 
            // ingresarToolStripMenuItem
            // 
            ingresarToolStripMenuItem.Name = "ingresarToolStripMenuItem";
            ingresarToolStripMenuItem.Size = new Size(125, 22);
            ingresarToolStripMenuItem.Text = "Ingresar";
            ingresarToolStripMenuItem.Click += ingresarToolStripMenuItem_Click;
            // 
            // modificarToolStripMenuItem1
            // 
            modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            modificarToolStripMenuItem1.Size = new Size(125, 22);
            modificarToolStripMenuItem1.Text = "Modificar";
            modificarToolStripMenuItem1.Click += modificarToolStripMenuItem1_Click;
            // 
            // reservaToolStripMenuItem
            // 
            reservaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ingresarToolStripMenuItem1, modificarToolStripMenuItem });
            reservaToolStripMenuItem.Name = "reservaToolStripMenuItem";
            reservaToolStripMenuItem.Size = new Size(59, 20);
            reservaToolStripMenuItem.Text = "Reserva";
            // 
            // ingresarToolStripMenuItem1
            // 
            ingresarToolStripMenuItem1.Name = "ingresarToolStripMenuItem1";
            ingresarToolStripMenuItem1.Size = new Size(125, 22);
            ingresarToolStripMenuItem1.Text = "Ingresar";
            ingresarToolStripMenuItem1.Click += ingresarToolStripMenuItem1_Click;
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new Size(125, 22);
            modificarToolStripMenuItem.Text = "Modificar";
            modificarToolStripMenuItem.Click += modificarToolStripMenuItem_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmMenu";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem pasajeroToolStripMenuItem;
        private ToolStripMenuItem crearPasajeroToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem vueloToolStripMenuItem;
        private ToolStripMenuItem reservaToolStripMenuItem;
        private ToolStripMenuItem ingresarToolStripMenuItem;
        private ToolStripMenuItem modificarToolStripMenuItem1;
        private ToolStripMenuItem ingresarToolStripMenuItem1;
        private ToolStripMenuItem modificarToolStripMenuItem;
    }
}