namespace CapaPresentacion {
    partial class ucCampeonatoModificar {
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbNombre_campeonado = new System.Windows.Forms.Label();
            this.txtNombre_campeonado = new System.Windows.Forms.TextBox();
            this.lbFechas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnModificar.BackgroundImage = global::CapaPresentacion.Properties.Resources.diskette__1_;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Location = new System.Drawing.Point(195, 194);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(89, 41);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnRegresar.BackgroundImage = global::CapaPresentacion.Properties.Resources.regreso1;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar.Location = new System.Drawing.Point(409, 6);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(57, 35);
            this.btnRegresar.TabIndex = 12;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(175, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Campeonato";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 127);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // lbNombre_campeonado
            // 
            this.lbNombre_campeonado.AutoSize = true;
            this.lbNombre_campeonado.BackColor = System.Drawing.Color.Transparent;
            this.lbNombre_campeonado.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbNombre_campeonado.Location = new System.Drawing.Point(23, 71);
            this.lbNombre_campeonado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbNombre_campeonado.Name = "lbNombre_campeonado";
            this.lbNombre_campeonado.Size = new System.Drawing.Size(81, 25);
            this.lbNombre_campeonado.TabIndex = 15;
            this.lbNombre_campeonado.Text = "Nombre";
            // 
            // txtNombre_campeonado
            // 
            this.txtNombre_campeonado.Location = new System.Drawing.Point(130, 67);
            this.txtNombre_campeonado.Margin = new System.Windows.Forms.Padding(6);
            this.txtNombre_campeonado.Name = "txtNombre_campeonado";
            this.txtNombre_campeonado.Size = new System.Drawing.Size(253, 29);
            this.txtNombre_campeonado.TabIndex = 16;
            // 
            // lbFechas
            // 
            this.lbFechas.AutoSize = true;
            this.lbFechas.BackColor = System.Drawing.Color.Transparent;
            this.lbFechas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbFechas.Location = new System.Drawing.Point(23, 127);
            this.lbFechas.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbFechas.Name = "lbFechas";
            this.lbFechas.Size = new System.Drawing.Size(67, 25);
            this.lbFechas.TabIndex = 17;
            this.lbFechas.Text = "Fecha";
            // 
            // ucCampeonatoModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.Fondo2;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbNombre_campeonado);
            this.Controls.Add(this.txtNombre_campeonado);
            this.Controls.Add(this.lbFechas);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnModificar);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ucCampeonatoModificar";
            this.Size = new System.Drawing.Size(491, 269);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha_Id_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha_Partidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha_Numero_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha_Fechainicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha_Fechafin;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbNombre_campeonado;
        private System.Windows.Forms.TextBox txtNombre_campeonado;
        private System.Windows.Forms.Label lbFechas;
    }
}