using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaAccesoaDatos;


namespace CapaPresentacion {
    public partial class Inicio: Form {

        public Inicio() {
            InitializeComponent();
        }

        private void presentacionToolStripMenuItem_Click(object sender, EventArgs e) {
            limpiar();
        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e) {
            
            
        }
        public void limpiar() {
            /*
            List<Control> ctrl_s = new List<Control>();
            foreach (Control c in this.Controls) {
                if (this.menuStrip1.Equals(c) == false) {
                    ctrl_s.Add(c);
                }
            }
            foreach (Control c in ctrl_s) {
                this.Controls.Remove(c);
                c.Dispose();
            }
            */
            pantalla.Controls.Clear();
        }

        private void consolaToolStripMenuItem_Click(object sender, EventArgs e) {
            PanelDeControl.UC_PanelDeControlGeneral uc = new PanelDeControl.UC_PanelDeControlGeneral();
            agregar(uc);
        }

        public void agregar(UC_Pantalla value) {
            pantalla.Controls.Add(value);
            value.Inicio = this;
            value.Dock = DockStyle.Fill;
            value.BringToFront();
        }

        public void eliminar(UC_Pantalla value) {
            pantalla.Controls.Remove(value);
            value.Dispose();
        }

        private void pantalla_Paint(object sender, PaintEventArgs e)
        {

        }
        //Para el ingreso del sistema esta creado dos usuarios;
        //"MarcosBayas" con contraseña "1234"
        //"MayuFalcone" con contraseña "4321"
        private void bnt_Entrar_Click(object sender, EventArgs e)
        {
            int intento = 0;
            do
            {
                intento+=1;
                if ((txtUsua.Text != "") && (txtContra.Text != ""))
                {

                    if ((txtUsua.Text == "MarcosBayas") && (txtContra.Text == "1234"))
                    {
                        PanelDeControl.UC_PanelDeControlGeneral a = new PanelDeControl.UC_PanelDeControlGeneral();
                        agregar(a);

                    }
                    else if ((txtUsua.Text == "MayuFalcone") && (txtContra.Text == "4321"))
                    {

                        PanelDeControl.UC_PanelDeControlGeneral a = new PanelDeControl.UC_PanelDeControlGeneral();
                        agregar(a);

                    }
                    else
                    {
                        //Si no ingresan los usuarios correctamente, se mostrara este mensaje
                        MessageBox.Show("usuario o contraseña incorrecta");
                    }
                }
                else
                {
                    //Debe loguear con usuario, caso contrario se mostrara este mensaje
                    MessageBox.Show("Ingrese un usuario y contarseña");
                }
            }
            while (intento <= 3);
            {
                MessageBox.Show("Alcanzado el limite de intento");
            }

            
        }
    }
}
