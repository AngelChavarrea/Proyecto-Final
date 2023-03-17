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
    public partial class ucJugadorModificar: UC_Pantalla {

        ClsJugador clsJugador = new ClsJugador();

        List<Object> lst_jugador;
        public ucJugadorModificar(List<Object> lst_jugador) {
            InitializeComponent();
            
            this.lst_jugador = lst_jugador;
            //foreach para buscar al jugador en la lista de jugadores
            foreach (var jugador in lst_jugador) {
                System.Type type = jugador.GetType();

                //txtId_persona.Text = ((int)type.GetProperty("id_persona").GetValue(jugador)).ToString();
                txtNombre_persona.Text = (string)type.GetProperty("nombre_persona").GetValue(jugador);
                txtApellido.Text = (string)type.GetProperty("apellido").GetValue(jugador);
                //txtCedula.Text = (string)type.GetProperty("cedula").GetValue(jugador);
                txtNumero.Text = ((int)type.GetProperty("numero").GetValue(jugador)).ToString();

            }
            MessageBox.Show("No soportado por cambios");
        }
        //Funcion modificar, utilizando try catch para la tolerancia a fallos
        private void btnModificar_Click(object sender, EventArgs e) {
            
            String msj = "";
            try {
                //clsJugador.Id_persona = Convert.ToInt32(txtId_persona.Text);
                clsJugador.Nombres = txtNombre_persona.Text.ToString();
                clsJugador.Apellidos = txtApellido.Text.ToString();
                //clsJugador.Cedula = txtCedula.Text.ToString();
                clsJugador.Numero = Convert.ToUInt16(txtNumero.Text);


                msj = clsJugador.modificar();
                MessageBox.Show(msj);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("No soportado por cambios");
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