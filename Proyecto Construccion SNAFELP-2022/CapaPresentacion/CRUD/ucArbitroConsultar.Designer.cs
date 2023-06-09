namespace CapaPresentacion {
    partial class ucArbitroConsultar {
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
            this.dgvArbitro = new System.Windows.Forms.DataGridView();
            this.colcolArbitro_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcolArbitro_Psw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcolArbitro_Nombre_persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcolArbitro_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcolArbitro_Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcolArbitro_Licencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtId_persona = new System.Windows.Forms.TextBox();
            this.lbId_persona = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnTodo = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbitro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArbitro
            // 
            this.dgvArbitro.AllowUserToAddRows = false;
            this.dgvArbitro.AllowUserToDeleteRows = false;
            this.dgvArbitro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArbitro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArbitro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colcolArbitro_Usuario,
            this.colcolArbitro_Psw,
            this.colcolArbitro_Nombre_persona,
            this.colcolArbitro_Apellido,
            this.colcolArbitro_Cedula,
            this.colcolArbitro_Licencia,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvArbitro.Location = new System.Drawing.Point(0, 90);
            this.dgvArbitro.Margin = new System.Windows.Forms.Padding(6);
            this.dgvArbitro.Name = "dgvArbitro";
            this.dgvArbitro.ReadOnly = true;
            this.dgvArbitro.RowHeadersWidth = 72;
            this.dgvArbitro.Size = new System.Drawing.Size(1401, 670);
            this.dgvArbitro.TabIndex = 0;
            // 
            // colcolArbitro_Usuario
            // 
            this.colcolArbitro_Usuario.HeaderText = "Usuario";
            this.colcolArbitro_Usuario.MinimumWidth = 9;
            this.colcolArbitro_Usuario.Name = "colcolArbitro_Usuario";
            this.colcolArbitro_Usuario.ReadOnly = true;
            this.colcolArbitro_Usuario.Width = 175;
            // 
            // colcolArbitro_Psw
            // 
            this.colcolArbitro_Psw.HeaderText = "Psw";
            this.colcolArbitro_Psw.MinimumWidth = 9;
            this.colcolArbitro_Psw.Name = "colcolArbitro_Psw";
            this.colcolArbitro_Psw.ReadOnly = true;
            this.colcolArbitro_Psw.Width = 175;
            // 
            // colcolArbitro_Nombre_persona
            // 
            this.colcolArbitro_Nombre_persona.HeaderText = "Nombre";
            this.colcolArbitro_Nombre_persona.MinimumWidth = 9;
            this.colcolArbitro_Nombre_persona.Name = "colcolArbitro_Nombre_persona";
            this.colcolArbitro_Nombre_persona.ReadOnly = true;
            this.colcolArbitro_Nombre_persona.Width = 175;
            // 
            // colcolArbitro_Apellido
            // 
            this.colcolArbitro_Apellido.HeaderText = "Apellido";
            this.colcolArbitro_Apellido.MinimumWidth = 9;
            this.colcolArbitro_Apellido.Name = "colcolArbitro_Apellido";
            this.colcolArbitro_Apellido.ReadOnly = true;
            this.colcolArbitro_Apellido.Width = 175;
            // 
            // colcolArbitro_Cedula
            // 
            this.colcolArbitro_Cedula.HeaderText = "Cedula";
            this.colcolArbitro_Cedula.MinimumWidth = 9;
            this.colcolArbitro_Cedula.Name = "colcolArbitro_Cedula";
            this.colcolArbitro_Cedula.ReadOnly = true;
            this.colcolArbitro_Cedula.Width = 175;
            // 
            // colcolArbitro_Licencia
            // 
            this.colcolArbitro_Licencia.HeaderText = "No. Licencia";
            this.colcolArbitro_Licencia.MinimumWidth = 9;
            this.colcolArbitro_Licencia.Name = "colcolArbitro_Licencia";
            this.colcolArbitro_Licencia.ReadOnly = true;
            this.colcolArbitro_Licencia.Width = 175;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha de Nacimiento";
            this.Column1.MinimumWidth = 9;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 175;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Telefono";
            this.Column2.MinimumWidth = 9;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 175;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nacionalidad";
            this.Column3.MinimumWidth = 9;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 175;
            // 
            // txtId_persona
            // 
            this.txtId_persona.Location = new System.Drawing.Point(123, 33);
            this.txtId_persona.Margin = new System.Windows.Forms.Padding(6);
            this.txtId_persona.Name = "txtId_persona";
            this.txtId_persona.Size = new System.Drawing.Size(180, 29);
            this.txtId_persona.TabIndex = 1;
            // 
            // lbId_persona
            // 
            this.lbId_persona.AutoSize = true;
            this.lbId_persona.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbId_persona.Location = new System.Drawing.Point(24, 33);
            this.lbId_persona.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbId_persona.Name = "lbId_persona";
            this.lbId_persona.Size = new System.Drawing.Size(75, 25);
            this.lbId_persona.TabIndex = 2;
            this.lbId_persona.Text = "Cedula";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.BackgroundImage = global::CapaPresentacion.Properties.Resources.lupa;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(335, 28);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(71, 44);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminar.BackgroundImage = global::CapaPresentacion.Properties.Resources.close;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(783, 28);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(71, 44);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnTodo
            // 
            this.btnTodo.Location = new System.Drawing.Point(447, 28);
            this.btnTodo.Margin = new System.Windows.Forms.Padding(6);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(71, 44);
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
            this.btnRegresar.Location = new System.Drawing.Point(1348, 6);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(6);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(59, 38);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::CapaPresentacion.Properties.Resources.anadir;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Location = new System.Drawing.Point(559, 28);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(6);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(71, 44);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnModificar.BackgroundImage = global::CapaPresentacion.Properties.Resources.editar_texto;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Location = new System.Drawing.Point(671, 28);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(6);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnModificar.Size = new System.Drawing.Size(71, 44);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // ucArbitroConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.Fondo2;
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnTodo);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lbId_persona);
            this.Controls.Add(this.txtId_persona);
            this.Controls.Add(this.dgvArbitro);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ucArbitroConsultar";
            this.Size = new System.Drawing.Size(1412, 766);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbitro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArbitro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArbitro_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArbitro_Psw;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArbitro_Id_persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArbitro_Nombre_persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArbitro_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArbitro_Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArbitro_Licencia;
        private System.Windows.Forms.TextBox txtId_persona;
        private System.Windows.Forms.Label lbId_persona;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcolArbitro_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcolArbitro_Psw;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcolArbitro_Nombre_persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcolArbitro_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcolArbitro_Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcolArbitro_Licencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}