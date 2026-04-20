namespace AppDiscograficaUI
{
    partial class FrmPrincipal
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
            lblTitulo = new Label();
            dgvEventos = new DataGridView();
            txtNombre = new TextBox();
            txtArtista = new TextBox();
            dtpFecha = new DateTimePicker();
            numPrecio = new NumericUpDown();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnActualizar = new Button();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEventos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(128, 54);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(524, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Eventos Discográfica";
            // 
            // dgvEventos
            // 
            dgvEventos.AllowUserToAddRows = false;
            dgvEventos.AllowUserToDeleteRows = false;
            dgvEventos.BackgroundColor = SystemColors.AppWorkspace;
            dgvEventos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEventos.Location = new Point(128, 129);
            dgvEventos.MultiSelect = false;
            dgvEventos.Name = "dgvEventos";
            dgvEventos.ReadOnly = true;
            dgvEventos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEventos.Size = new Size(524, 150);
            dgvEventos.TabIndex = 1;
            dgvEventos.CellContentClick += dgvEventos_CellContentClick;
            // 
            // txtNombre
            // 
            txtNombre.AccessibleName = "";
            txtNombre.Location = new Point(128, 304);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(216, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtArtista
            // 
            txtArtista.Location = new Point(128, 352);
            txtArtista.Name = "txtArtista";
            txtArtista.PlaceholderText = "Artista";
            txtArtista.Size = new Size(216, 23);
            txtArtista.TabIndex = 3;
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(376, 304);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(232, 23);
            dtpFecha.TabIndex = 4;
            dtpFecha.Value = new DateTime(2026, 4, 19, 23, 54, 36, 0);
            // 
            // numPrecio
            // 
            numPrecio.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numPrecio.Location = new Point(376, 352);
            numPrecio.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(96, 23);
            numPrecio.TabIndex = 5;
            numPrecio.ThousandsSeparator = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(128, 400);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(96, 23);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.WhiteSmoke;
            btnEliminar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.ControlText;
            btnEliminar.Location = new Point(512, 400);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(96, 23);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(512, 352);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(96, 23);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(248, 400);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(96, 23);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(376, 400);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(96, 23);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += button1_Click;
            // 
            // FrmPrincipal
            // 
            AccessibleName = "Nombre";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscar);
            Controls.Add(btnActualizar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(numPrecio);
            Controls.Add(dtpFecha);
            Controls.Add(txtArtista);
            Controls.Add(txtNombre);
            Controls.Add(dgvEventos);
            Controls.Add(lblTitulo);
            Name = "FrmPrincipal";
            Text = "Gestión de Eventos";
            Load += FrmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEventos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private DataGridView dgvEventos;
        private TextBox txtNombre;
        private TextBox txtArtista;
        private DateTimePicker dtpFecha;
        private NumericUpDown numPrecio;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnActualizar;
        private Button btnBuscar;
    }
}
