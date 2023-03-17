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
    public partial class ucArbitro: UC_Pantalla {
        ClsArbitro clsArbitro = new ClsArbitro();
        //se crea objeto lista arbitro
        List<Object> lst_arbitro;
        public ucArbitro() {
            InitializeComponent();

        }
        //funcion registrar arbitro con try cacth para tolerancia a fallos
        private void btnRegistrar_Click(object sender, EventArgs e) {
            String msj = "";
            try {
                clsArbitro.Usuario = txtUsuario.Text.ToString();
                clsArbitro.Psw = txtPsw.Text.ToString();
                clsArbitro.Nombres = txtNombre_persona.Text.ToString();
                clsArbitro.Apellidos = txtApellido.Text.ToString();
                clsArbitro.Cedula = txtCedula.Text.ToString();
                clsArbitro.Licencia = txtLicencia.Text.ToString();

                msj = clsArbitro.registrar();
                MessageBox.Show(msj);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        //funcion de llamar ventana consultar artibros registrados
        private void btnConsultar_Click(object sender, EventArgs e) {
            var resultado = clsArbitro.listar();
            lst_arbitro = resultado.Item1;
            //registros = resultado.Item2;
            
            //Se pasa por parámetros los datos de arbitro registrados para que sean
            //tratados en el otro formulario.
            ucArbitroConsultar ucArbitroCons = new ucArbitroConsultar(lst_arbitro);
            ucArbitroCons.Show();
        }
        //cerrrar ventana
        private void btnRegresar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Close() {
            this.Inicio.eliminar(this);
        }
    }
}