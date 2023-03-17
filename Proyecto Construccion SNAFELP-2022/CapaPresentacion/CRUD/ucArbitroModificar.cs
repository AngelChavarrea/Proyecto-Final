using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicadeNegocio;

namespace CapaPresentacion {
    public partial class ucArbitroModificar: UC_Pantalla {
        ClsArbitro clsArbitro = new ClsArbitro();
        //se crea objeto lista arbitro
        List<Object> lst_arbitro;
        public ucArbitroModificar(List<Object> lst_arbitro) {
            InitializeComponent();
            //se pasan los datos de la lista arbitro a esta lista
            this.lst_arbitro = lst_arbitro;
            
            foreach (var arbitro in lst_arbitro) {
                System.Type type = arbitro.GetType();

                txtUsuario.Text = (string)type.GetProperty("usuario").GetValue(arbitro);
                txtPsw.Text = (string)type.GetProperty("psw").GetValue(arbitro);
                //txtId_persona.Text = ((int)type.GetProperty("id_persona").GetValue(arbitro)).ToString();
                txtNombre_persona.Text = (string)type.GetProperty("nombre_persona").GetValue(arbitro);
                txtApellido.Text = (string)type.GetProperty("apellido").GetValue(arbitro);
                txtCedula.Text = (string)type.GetProperty("cedula").GetValue(arbitro);
                txtLicencia.Text = (string)type.GetProperty("licencia").GetValue(arbitro);

            }
        }
        //funcion modificar con try catch para la tolerancia a fallos
        private void btnModificar_Click(object sender, EventArgs e) {
            String msj = "";
            try {
                clsArbitro.Usuario = txtUsuario.Text.ToString();
                clsArbitro.Psw = txtPsw.Text.ToString();
                //clsArbitro.Id_persona = Convert.ToInt32(txtId_persona.Text);
                clsArbitro.Nombres = txtNombre_persona.Text.ToString();
                clsArbitro.Apellidos = txtApellido.Text.ToString();
                clsArbitro.Cedula = txtCedula.Text.ToString();
                clsArbitro.Licencia = txtLicencia.Text.ToString();


                msj = clsArbitro.modificar();
                MessageBox.Show(msj);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        //cerrar ventana
        private void btnRegresar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Close() {
            this.Inicio.eliminar(this);
        }
    }
}