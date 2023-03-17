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
    public partial class ucEquipo: UC_Pantalla {
        ClsEquipo clsEquipo = new ClsEquipo();
        //se crea un objeto de lista equipo
        List<Object> lst_equipo;
        public ucEquipo() {
            InitializeComponent();

        }
        //funcion registrar equipo con try cacth para la tolerancia a fallos
        private void btnRegistrar_Click(object sender, EventArgs e) {
            String msj = "";
            try {
                clsEquipo.Jugadores = new ClsJugador();
                clsEquipo.Jugadores.Id_persona = Convert.ToInt32(txtJugadores.Text);

                msj = clsEquipo.registrar();
                MessageBox.Show(msj);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        //funcion de consultar para ingresar a otra ventana donde consultaremos los equipos registrados
        private void btnConsultar_Click(object sender, EventArgs e) {
            var resultado = clsEquipo.listar();
            lst_equipo = resultado.Item1;
            //registros = resultado.Item2;
            
            //Se pasa por parámetros los datos de equipo registrados para que sean
            //tratados en el otro formulario.
            ucEquipoConsultar ucEquipoCons = new ucEquipoConsultar(lst_equipo);
            ucEquipoCons.Show();
        }
        //funcion para la lista de los jugadores del equipo
        private void btnJugadores_Click(object sender, EventArgs e) {
            //lst_equipo = clsEquipo.listar();
            //this.Hide();
            ucJugador uc = new ucJugador();
            var resultado = clsEquipo.listar();
            lst_equipo = resultado.Item1;
            //registros = resultado.Item2;
            uc.Show();//Dialog();
            //this.Show();
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