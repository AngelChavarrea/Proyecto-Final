namespace CapaPresentacion {
    partial class ucCampeonatoConsultar {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dgvCampeonato = new System.Windows.Forms.DataGridView();
            this.colcolCampeonato_Nombre_campeonado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcolCampeonato_Fechas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtId_campeonato = new System.Windows.Forms.TextBox();
            this.lbId_campeonato = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnTodo = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampeonato)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCampeonato
            // 
            this.dgvCampeonato.AllowUserToAddRows = false;
            this.dgvCampeonato.AllowUserToDeleteRows = false;
            this.dgvCampeonato.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCampeonato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCampeonato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colcolCampeonato_Nombre_campeonado,
            this.colcolCampeonato_Fechas});
            this.dgvCampeonato.Location = new System.Drawing.Point(11, 96);
            this.dgvCampeonato.Margin = new System.Windows.Forms.Padding(6);
            this.dgvCampeonato.Name = "dgvCampeonato";
            this.dgvCampeonato.ReadOnly = true;
            this.dgvCampeonato.RowHeadersWidth = 72;
            this.dgvCampeonato.Size = new System.Drawing.Size(619, 185);
            this.dgvCampeonato.TabIndex = 0;
            // 
            // colcolCampeonato_Nombre_campeonado
            // 
            this.colcolCampeonato_Nombre_campeonado.HeaderText = "Nombre";
            this.colcolCampeonato_Nombre_campeonado.MinimumWidth = 9;
            this.colcolCampeonato_Nombre_campeonado.Name = "colcolCampeonato_Nombre_campeonado";
            this.colcolCampeonato_Nombre_campeonado.ReadOnly = true;
            this.colcolCampeonato_Nombre_campeonado.Width = 175;
            // 
            // colcolCampeonato_Fechas
            // 
            this.colcolCampeonato_Fechas.HeaderText = "Fecha";
            this.colcolCampeonato_Fechas.MinimumWidth = 9;
            this.colcolCampeonato_Fechas.Name = "colcolCampeonato_Fechas";
            this.colcolCampeonato_Fechas.ReadOnly = true;
            this.colcolCampeonato_Fechas.Width = 175;
            // 
            // txtId_campeonato
            // 
            this.txtId_campeonato.Location = new System.Drawing.Point(99, 25);
            this.txtId_campeonato.Margin = new System.Windows.Forms.Padding(6);
            this.txtId_campeonato.Name = "txtId_campeonato";
            this.txtId_campeonato.Size = new System.Drawing.Size(180, 29);
            this.txtId_campeonato.TabIndex = 1;
            // 
            // lbId_campeonato
            // 
            this.lbId_campeonato.AutoSize = true;
            this.lbId_campeonato.Location = new System.Drawing.Point(6, 29);
            this.lbId_campeonato.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbId_campeonato.Name = "lbId_campeonato";
            this.lbId_campeonato.Size = new System.Drawing.Size(81, 25);
            this.lbId_campeonato.TabIndex = 2;
            this.lbId_campeonato.Text = "Nombre";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.BackgroundImage = global::CapaPresentacion.Properties.Resources.lupa;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(313, 20);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(65, 42);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminar.BackgroundImage = global::CapaPresentacion.Properties.Resources.close;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(565, 20);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(65, 42);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnTodo
            // 
            this.btnTodo.Location = new System.Drawing.Point(649, 20);
            this.btnTodo.Margin = new System.Windows.Forms.Padding(6);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(84, 42);
            this.btnTodo.TabIndex = 4;
            this.btnTodo.Text = "Todo";
            this.btnTodo.UseVisualStyleBackColor = true;
            this.btnTodo.Click += new System.EventHandler(this.btnTodo_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegresar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnRegresar.BackgroundImage = global::CapaPresentacion.Properties.Resources.regreso1;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar.Location = new System.Drawing.Point(829, 6);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(6);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(59, 39);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregar.BackgroundImage = global::CapaPresentacion.Properties.Resources.anadir;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Location = new System.Drawing.Point(397, 20);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(6);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(65, 42);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnModificar.BackgroundImage = global::CapaPresentacion.Properties.Resources.editar_texto;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Location = new System.Drawing.Point(481, 20);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(6);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(65, 42);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // ucCampeonatoConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.Fondo2;
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnTodo);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lbId_campeonato);
            this.Controls.Add(this.txtId_campeonato);
            this.Controls.Add(this.dgvCampeonato);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ucCampeonatoConsultar";
            this.Size = new System.Drawing.Size(888, 321);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampeonato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCampeonato;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCampeonato_Id_campeonato;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCampeonato_Nombre_campeonado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCampeonato_Fechas;
        private System.Windows.Forms.TextBox txtId_campeonato;
        private System.Windows.Forms.Label lbId_campeonato;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcolCampeonato_Nombre_campeonado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcolCampeonato_Fechas;
    }
}