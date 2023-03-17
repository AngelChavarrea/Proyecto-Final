using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaLogicadeNegocio;

namespace CapaPresentacion {
    public partial class ucJugadorConsultar: UC_Pantalla {
        ClsJugador clsJugador = new ClsJugador();
        //Se crea un objeto lista jugador
        List<Object> lst_jugador;
        SqlDataAdapter registros;
        public void Probando() {
            int val = clsJugador.Suma(40, 60);
            System.Diagnostics.Debug.Print("La suma es: " + val);
        }
        public ucJugadorConsultar() {
            InitializeComponent();
            Probando();
        }
        public ucJugadorConsultar(List<Object> lst_jugador) {
            InitializeComponent();
            Probando();
            //Se pasa los datos de la lista jugador a esta lista jugador
            this.lst_jugador = lst_jugador;
        }
        //Funcion de llenar datagridview jugador y se muestren los jugadores registrados
        public void llenar_datagridview_Jugador() {
            dgvJugador.Rows.Clear();
            dgvJugador.Refresh();

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var jugador in lst_jugador) {
                System.Type type = jugador.GetType();

                int id_persona = (int)type.GetProperty("id_persona").GetValue(jugador);
                string nombres = (string)type.GetProperty("nombres").GetValue(jugador);
                string apellidos = (string)type.GetProperty("apellidos").GetValue(jugador);
                string cedula = (string)type.GetProperty("cedula").GetValue(jugador);
                DateTime fechanacimiento = (DateTime)type.GetProperty("fechanacimiento").GetValue(jugador);
                string telefono = (string)type.GetProperty("telefono").GetValue(jugador);
                string nacionalidad = (string)type.GetProperty("nacionalidad").GetValue(jugador);
                int numero = (UInt16)type.GetProperty("numero").GetValue(jugador);


                dgvJugador.Rows.Add(id_persona, nombres, apellidos, cedula, fechanacimiento, telefono, nacionalidad, numero);
            }

        }
        //Funcion buscar jugadores registrados
        private void buscar() {

            dgvJugador.Rows.Clear();
            dgvJugador.Refresh();

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var jugador in lst_jugador) {
                System.Type type = jugador.GetType();

                int Id_persona = (int)type.GetProperty("Id_persona").GetValue(jugador);
                /*if (Id_persona.Equals(Convert.ToInt32(txtId_persona.Text))) {
                    
                        int id_persona = (int)type.GetProperty("id_persona").GetValue(jugador);
                        string nombre_persona = (string)type.GetProperty("nombre_persona").GetValue(jugador);
                        string apellido = (string)type.GetProperty("apellido").GetValue(jugador);
                        string cedula = (string)type.GetProperty("cedula").GetValue(jugador);
                        int numero = (int)type.GetProperty("numero").GetValue(jugador);

                        dgvJugador.Rows.Add(id_persona, Nombres, Apellidos, cedula, numero);
                        break;
                    }
                }
            
                MessageBox.Show("No soportado por cambios");*/
            }

            //private void btnBuscar_Click(object sender, EventArgs e) {
            /*
            //buscar();
            if (txtId_persona.Text.Count() > 0) {
                var resultado = clsJugador.buscarid(Convert.ToInt32(txtId_persona.Text));
                lst_jugador = resultado.Item1;
                registros = resultado.Item2;
                llenar_datagridview_Jugador();
            } else {
                MessageBox.Show("No ha ingresado id");
            }
            MessageBox.Show("No soportado por cambios");*/
        }

        //Funcion para eliminar
        private void btnEliminar_Click(object sender, EventArgs e) {
            /*
            if (txtId_persona.Text.Count() > 0) {
                clsJugador.eliminar(Convert.ToInt32(txtId_persona.Text));
                var resultado = clsJugador.listar();
                lst_jugador = resultado.Item1;
                registros = resultado.Item2;
                llenar_datagridview_Jugador();
            } else {
                MessageBox.Show("No ha ingresado id");
            }
            MessageBox.Show("No soportado por cambios");*/
        }

        private void btnModificar_Click(object sender, EventArgs e) {
            /*
            if (txtId_persona.Text.Count() > 0) {
                var resultado = clsJugador.buscarid(Convert.ToInt32(txtId_persona.Text));
                lst_jugador = resultado.Item1;
                //registros = resultado.Item2;

                ucJugadorModificar ucJugadormodificar = new ucJugadorModificar(lst_jugador);
                ucJugadormodificar.Show();
            } else {
                MessageBox.Show("No ha ingresado id");
            }
            MessageBox.Show("No soportado por cambios"); */
        }


        private void btnTodo_Click(object sender, EventArgs e) {
            var resultado = clsJugador.listar();
            lst_jugador = resultado.Item1;
            registros = resultado.Item2;
            llenar_datagridview_Jugador();
        }

        private void btnRegresar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            ucJugador ucjugador = new ucJugador();
            this.Inicio.agregar(ucjugador);
        }

        private void btnReporte_Click(object sender, EventArgs e) {
            /*
            DataSet ds = new DataSet();
            this.registros.Fill(ds);
            ucJugadorReporte ucjugadorreporte = new ucJugadorReporte(ds);
            ucjugadorreporte.Show();

            MessageBox.Show("No soportado por cambios");*/
        }

        private void Close() {
            this.Inicio.eliminar(this);
        }
    }
}