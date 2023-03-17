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
    public partial class ucAdministrador: UC_Pantalla {

        ClsAdministrador clsAdministrador = new ClsAdministrador();
        //se crea un objeto lista administrador 
        List<Object> lst_administrador;
        public ucAdministrador() {
            InitializeComponent();

        }
        //funcion registrar administrador con try catch para tolerancia a fallos
        private void btnRegistrar_Click(object sender, EventArgs e) {
            String msj = "";
            try {
                clsAdministrador.Nombres = txtNombre_persona.Text.ToString();
                clsAdministrador.Apellidos = txtApellido.Text.ToString();
                clsAdministrador.Cedula = txtCedula.Text.ToString();
                clsAdministrador.Usuario = txtUsuario.Text.ToString();
                clsAdministrador.Psw = txtPsw.Text.ToString();
                clsAdministrador.Puesto = txtPuesto.Text.ToString();

                msj = clsAdministrador.registrar();
                MessageBox.Show(msj);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        //funcion ir a la ventana consultar administradores registrados
        private void btnConsultar_Click(object sender, EventArgs e) {
            var resultado = clsAdministrador.listar();
            lst_administrador = resultado.Item1;
            //registros = resultado.Item2;
            
            //Se pasa por parámetros los datos de administrador registrados para que sean
            //tratados en el otro formulario.
            ucAdministradorConsultar ucAdministradorCons = new ucAdministradorConsultar(lst_administrador);
            ucAdministradorCons.Show();
        }


        
        private void btnRegresar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Close() {
            this.Inicio.eliminar(this);
        }
    }
}