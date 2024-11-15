
namespace Dades_Alumnes_Joc_Pintar
{
    partial class formJocPintar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelJSON = new DataGridView();
            lblDadesAlumnes = new Label();
            btnObrirArxiu = new Button();
            btnSortir = new Button();
            btnAfegirFila = new Button();
            btnEliminarFila = new Button();
            btnGuardar = new Button();
            pBoxDadesAlumnes = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)panelJSON).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxDadesAlumnes).BeginInit();
            SuspendLayout();
            // 
            // panelJSON
            // 
            panelJSON.AllowDrop = true;
            panelJSON.AllowUserToAddRows = false;
            panelJSON.AllowUserToDeleteRows = false;
            panelJSON.BackgroundColor = SystemColors.Info;
            panelJSON.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            panelJSON.Location = new Point(34, 124);
            panelJSON.Name = "panelJSON";
            panelJSON.Size = new Size(561, 461);
            panelJSON.TabIndex = 0;
            // 
            // lblDadesAlumnes
            // 
            lblDadesAlumnes.AutoSize = true;
            lblDadesAlumnes.Location = new Point(34, 96);
            lblDadesAlumnes.Name = "lblDadesAlumnes";
            lblDadesAlumnes.Size = new Size(0, 15);
            lblDadesAlumnes.TabIndex = 1;
            // 
            // btnObrirArxiu
            // 
            btnObrirArxiu.BackColor = SystemColors.ButtonHighlight;
            btnObrirArxiu.Location = new Point(619, 539);
            btnObrirArxiu.Name = "btnObrirArxiu";
            btnObrirArxiu.Size = new Size(146, 46);
            btnObrirArxiu.TabIndex = 2;
            btnObrirArxiu.Text = "Obrir arxiu";
            btnObrirArxiu.UseVisualStyleBackColor = false;
            btnObrirArxiu.Click += btnObrirArxiu_Click;
            // 
            // btnSortir
            // 
            btnSortir.BackColor = SystemColors.ButtonHighlight;
            btnSortir.Location = new Point(785, 539);
            btnSortir.Name = "btnSortir";
            btnSortir.Size = new Size(146, 46);
            btnSortir.TabIndex = 3;
            btnSortir.Text = "Sortir";
            btnSortir.UseVisualStyleBackColor = false;
            btnSortir.Click += btnSortir_Click;
            // 
            // btnAfegirFila
            // 
            btnAfegirFila.Location = new Point(619, 124);
            btnAfegirFila.Name = "btnAfegirFila";
            btnAfegirFila.Size = new Size(146, 46);
            btnAfegirFila.TabIndex = 4;
            btnAfegirFila.Text = "Afegir Fila";
            btnAfegirFila.UseVisualStyleBackColor = true;
            btnAfegirFila.Click += btnAfegirFila_Click;
            // 
            // btnEliminarFila
            // 
            btnEliminarFila.Location = new Point(785, 124);
            btnEliminarFila.Name = "btnEliminarFila";
            btnEliminarFila.Size = new Size(146, 46);
            btnEliminarFila.TabIndex = 5;
            btnEliminarFila.Text = "Eliminar Fila";
            btnEliminarFila.UseVisualStyleBackColor = true;
            btnEliminarFila.Click += btnEliminarFila_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(619, 191);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(146, 46);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // pBoxDadesAlumnes
            // 
            pBoxDadesAlumnes.BackColor = Color.Transparent;
            pBoxDadesAlumnes.Location = new Point(34, 75);
            pBoxDadesAlumnes.Name = "pBoxDadesAlumnes";
            pBoxDadesAlumnes.Size = new Size(286, 36);
            pBoxDadesAlumnes.TabIndex = 9;
            pBoxDadesAlumnes.TabStop = false;
            // 
            // formJocPintar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.imgAfegir;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(943, 638);
            Controls.Add(pBoxDadesAlumnes);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminarFila);
            Controls.Add(btnAfegirFila);
            Controls.Add(btnSortir);
            Controls.Add(btnObrirArxiu);
            Controls.Add(lblDadesAlumnes);
            Controls.Add(panelJSON);
            DoubleBuffered = true;
            Name = "formJocPintar";
            Text = "Form1";
            Click += formJocPintar_Click;
            ((System.ComponentModel.ISupportInitialize)panelJSON).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxDadesAlumnes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            

        }

        #endregion

        private DataGridView panelJSON;
        private Label lblDadesAlumnes;
        private Button btnObrirArxiu;
        private Button btnSortir;
        private Button btnAfegirFila;
        private Button btnEliminarFila;
        private Button btnGuardar;
        private PictureBox pBoxDadesAlumnes;
    }
}
