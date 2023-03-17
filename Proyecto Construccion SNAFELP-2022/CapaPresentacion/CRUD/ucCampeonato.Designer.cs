namespace CapaPresentacion {
    partial class ucCampeonato {
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lbNombre_campeonado = new System.Windows.Forms.Label();
            this.txtNombre_campeonado = new System.Windows.Forms.TextBox();
            this.lbFechas = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistrar.BackgroundImage = global::CapaPresentacion.Properties.Resources.diskette__1_;
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrar.Location = new System.Drawing.Point(127, 212);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(105, 42);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnConsultar.BackgroundImage = global::CapaPresentacion.Properties.Resources.lupa;
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultar.Location = new System.Drawing.Point(243, 212);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(105, 42);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Visible = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lbNombre_campeonado
            // 
            this.lbNombre_campeonado.AutoSize = true;
            this.lbNombre_campeonado.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbNombre_campeonado.Location = new System.Drawing.Point(9, 55);
            this.lbNombre_campeonado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbNombre_campeonado.Name = "lbNombre_campeonado";
            this.lbNombre_campeonado.Size = new System.Drawing.Size(81, 25);
            this.lbNombre_campeonado.TabIndex = 2;
            this.lbNombre_campeonado.Text = "Nombre";
            // 
            // txtNombre_campeonado
            // 
            this.txtNombre_campeonado.Location = new System.Drawing.Point(116, 51);
            this.txtNombre_campeonado.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNombre_campeonado.Name = "txtNombre_campeonado";
            this.txtNombre_campeonado.Size = new System.Drawing.Size(253, 29);
            this.txtNombre_campeonado.TabIndex = 3;
            this.txtNombre_campeonado.TextChanged += new System.EventHandler(this.txtNombre_campeonado_TextChanged);
            // 
            // lbFechas
            // 
            this.lbFechas.AutoSize = true;
            this.lbFechas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbFechas.Location = new System.Drawing.Point(9, 111);
            this.lbFechas.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbFechas.Name = "lbFechas";
            this.lbFechas.Size = new System.Drawing.Size(67, 25);
            this.lbFechas.TabIndex = 4;
            this.lbFechas.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 111);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(161, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Campeonato";
            // 
            // ucCampeonato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.Fondo2;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbNombre_campeonado);
            this.Controls.Add(this.txtNombre_campeonado);
            this.Controls.Add(this.lbFechas);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnRegistrar);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ucCampeonato";
            this.Size = new System.Drawing.Size(480, 281);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha_Id_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha_Partidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha_Numero_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha_Fechainicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha_Fechafin;
        private System.Windows.Forms.Label lbNombre_campeonado;
        private System.Windows.Forms.TextBox txtNombre_campeonado;
        private System.Windows.Forms.Label lbFechas;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
    }
}