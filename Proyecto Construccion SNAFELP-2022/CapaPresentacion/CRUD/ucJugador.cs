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
    /// <summary>
    /// Jugador, jugador que juega en un equipo de futboll
    /// </summary>
    public partial class ucJugador: UC_Pantalla {
        /// <summary>
        /// Clase en la capa Logica de negocio par ainteractuar cin jugador
        /// </summary>
        ClsJugador clsJugador = new ClsJugador();

        /// <summary>
        /// Lista para enviar multiples registros de jugador a la capa logica de negocio
        /// </summary>
        List<Object> lst_jugador;

        /// <summary>
        /// Bob construye; ¿Podrán hacerlo?; Bob construye; ¡Sí podremos!
        /// </summary>
        public ucJugador() {
            InitializeComponent();
        }
        /// <summary>
        /// Metodo controlador de evento del boton Registrar que llama a un metodo Registrar
        /// </summary>
        /// <param name="sender">objeto en el que ocurre el evento</param>
        /// <param name="e">argumento de evento que indica las sircunstancias del eevento (EFE porque justamente este evento no trae nada adicional en esta variable)</param>
        private void btnRegistrar_Click(object sender, EventArgs e) {
            Registrar();
        }

        /// <summary>
        ///  Metodo Registrar en el cual se lee los valores de los campos y se los envia almacenados en la lista a travez de clsJugador
        /// </summary>
        /// <returns></returns>
        public bool Registrar() {
            String msj = "";
            try {
                //clsJugador.Id_persona;
                clsJugador.Nombres = txtNombres.Text.ToString();
                clsJugador.Apellidos = txtApellidos.Text.ToString();
                clsJugador.Cedula = txtCedula.Text.ToString();
                clsJugador.Fechanacimiento = dtpFechanacimiento.Value;
                clsJugador.Telefono = txtTelefono.Text.ToString();
                clsJugador.Nacionalidad = txtNacionalidad.Text;
                clsJugador.Numero = Convert.ToUInt16(txtNumero.Text);

                msj = clsJugador.registrar();
                MessageBox.Show(msj);
                return true;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// Funcion para consultar los jugadores registrados
        /// </summary>
        private void btnConsultar_Click(object sender, EventArgs e) {
            var resultado = clsJugador.listar();
            lst_jugador = resultado.Item1;
            //registros = resultado.Item2;
            
            //Se pasa por parámetros los datos de jugador registrados para que sean
            //tratados en el otro formulario.
            ucJugadorConsultar ucJugadorCons = new ucJugadorConsultar(lst_jugador);
            ucJugadorCons.Show();
        }

        /// <summary>
        /// evento para cerrar ventana a travez del boton Regresar
        /// </summary>
        private void btnRegresar_Click(object sender, EventArgs e) {
            this.Close();
        }
        /// <summary>
        /// cerrar ventana y regresar
        /// </summary>
        private void Close() {
            this.Inicio.eliminar(this);
        }
    }
}