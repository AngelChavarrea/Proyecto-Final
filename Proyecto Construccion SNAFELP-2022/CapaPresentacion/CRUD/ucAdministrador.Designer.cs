namespace CapaPresentacion {
    partial class ucAdministrador {
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lbNombre_persona = new System.Windows.Forms.Label();
            this.txtNombre_persona = new System.Windows.Forms.TextBox();
            this.lbApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lbCedula = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lbPsw = new System.Windows.Forms.Label();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistrar.BackgroundImage = global::CapaPresentacion.Properties.Resources.diskette__1_;
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrar.Location = new System.Drawing.Point(126, 462);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(6);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(72, 53);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnConsultar.BackgroundImage = global::CapaPresentacion.Properties.Resources.lupa;
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultar.Location = new System.Drawing.Point(269, 462);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(6);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(72, 53);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Visible = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnRegresar.BackgroundImage = global::CapaPresentacion.Properties.Resources.regreso1;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar.Location = new System.Drawing.Point(416, 0);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(6);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(50, 39);
            this.btnRegresar.TabIndex = 12;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lbNombre_persona
            // 
            this.lbNombre_persona.AutoSize = true;
            this.lbNombre_persona.BackColor = System.Drawing.Color.Transparent;
            this.lbNombre_persona.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNombre_persona.Location = new System.Drawing.Point(9, 55);
            this.lbNombre_persona.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbNombre_persona.Name = "lbNombre_persona";
            this.lbNombre_persona.Size = new System.Drawing.Size(81, 25);
            this.lbNombre_persona.TabIndex = 2;
            this.lbNombre_persona.Text = "Nombre";
            // 
            // txtNombre_persona
            // 
            this.txtNombre_persona.Location = new System.Drawing.Point(140, 55);
            this.txtNombre_persona.Margin = new System.Windows.Forms.Padding(6);
            this.txtNombre_persona.Name = "txtNombre_persona";
            this.txtNombre_persona.Size = new System.Drawing.Size(253, 29);
            this.txtNombre_persona.TabIndex = 3;
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.BackColor = System.Drawing.Color.Transparent;
            this.lbApellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbApellido.Location = new System.Drawing.Point(9, 111);
            this.lbApellido.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(82, 25);
            this.lbApellido.TabIndex = 4;
            this.lbApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(140, 110);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(6);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(253, 29);
            this.txtApellido.TabIndex = 5;
            // 
            // lbCedula
            // 
            this.lbCedula.AutoSize = true;
            this.lbCedula.BackColor = System.Drawing.Color.Transparent;
            this.lbCedula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCedula.Location = new System.Drawing.Point(9, 166);
            this.lbCedula.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCedula.Name = "lbCedula";
            this.lbCedula.Size = new System.Drawing.Size(75, 25);
            this.lbCedula.TabIndex = 6;
            this.lbCedula.Text = "Cedula";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(140, 165);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(6);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(253, 29);
            this.txtCedula.TabIndex = 7;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbUsuario.Location = new System.Drawing.Point(9, 222);
            this.lbUsuario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(79, 25);
            this.lbUsuario.TabIndex = 8;
            this.lbUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(140, 221);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(253, 29);
            this.txtUsuario.TabIndex = 9;
            // 
            // lbPsw
            // 
            this.lbPsw.AutoSize = true;
            this.lbPsw.BackColor = System.Drawing.Color.Transparent;
            this.lbPsw.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPsw.Location = new System.Drawing.Point(9, 277);
            this.lbPsw.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbPsw.Name = "lbPsw";
            this.lbPsw.Size = new System.Drawing.Size(49, 25);
            this.lbPsw.TabIndex = 10;
            this.lbPsw.Text = "Psw";
            // 
            // txtPsw
            // 
            this.txtPsw.Location = new System.Drawing.Point(140, 276);
            this.txtPsw.Margin = new System.Windows.Forms.Padding(6);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.Size = new System.Drawing.Size(253, 29);
            this.txtPsw.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(9, 339);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Puesto:";
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(140, 338);
            this.txtPuesto.Margin = new System.Windows.Forms.Padding(6);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(253, 29);
            this.txtPuesto.TabIndex = 17;
            // 
            // ucAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.Fondo2;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.lbNombre_persona);
            this.Controls.Add(this.txtNombre_persona);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lbCedula);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lbPsw);
            this.Controls.Add(this.txtPsw);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnRegistrar);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ucAdministrador";
            this.Size = new System.Drawing.Size(489, 532);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre_persona;
        private System.Windows.Forms.TextBox txtNombre_persona;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lbCedula;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lbPsw;
        private System.Windows.Forms.TextBox txtPsw;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPuesto;
    }
}