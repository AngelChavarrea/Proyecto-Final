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
    public partial class ucEquipoConsultar: UC_Pantalla {
        ClsEquipo clsEquipo = new ClsEquipo();
        //se crea un objeto lista equipo
        List<Object> lst_equipo;
        SqlDataAdapter registros;
        public ucEquipoConsultar() {
            InitializeComponent();
        }
        public ucEquipoConsultar(List<Object> lst_equipo) {
            InitializeComponent();
            //se pasan los datos de la lista equipo a esta lista
            this.lst_equipo = lst_equipo;
        }
        //funcion de llenar datagridview de equipo para consultar los equipos registrados
        public void llenar_datagridview_Equipo() {
            dgvEquipo.Rows.Clear();
            dgvEquipo.Refresh();

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var equipo in lst_equipo) {
                System.Type type = equipo.GetType();

                int id_equipo = (int)type.GetProperty("id_equipo").GetValue(equipo);
                int jugadores = (int)type.GetProperty("jugadores").GetValue(equipo);

                
                dgvEquipo.Rows.Add(id_equipo, jugadores);
            }

        }
        //
        private void buscar() {
            /*
            dgvEquipo.Rows.Clear();
            dgvEquipo.Refresh();

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var equipo in lst_equipo) {
                System.Type type = equipo.GetType();

                int Id_equipo = (int)type.GetProperty("Id_equipo").GetValue(equipo);
                if (Id_equipo.Equals(Convert.ToInt32(txtId_equipo.Text))) {
                    
                    int id_equipo = (int)type.GetProperty("id_equipo").GetValue(equipo);
                    int jugadores = (int)type.GetProperty("jugadores").GetValue(equipo);

                    dgvEquipo.Rows.Add(id_equipo, jugadores);
                    break;
                }
            }*/
            MessageBox.Show("No soportado por cambios");
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            /*
            //buscar();
            if (txtId_equipo.Text.Count() > 0) {
                var resultado = clsEquipo.buscarid(Convert.ToInt32(txtId_equipo.Text));
                lst_equipo = resultado.Item1;
                registros = resultado.Item2;
                llenar_datagridview_Equipo();
            } else {
                MessageBox.Show("No ha ingresado id");
            }*/
            MessageBox.Show("No soportado por cambios");
        }
        private void btnEliminar_Click(object sender, EventArgs e) {
            /*
            if (txtId_equipo.Text.Count() > 0) {
                clsEquipo.eliminar(Convert.ToInt32(txtId_equipo.Text));
                var resultado = clsEquipo.listar();
                lst_equipo = resultado.Item1;
                registros = resultado.Item2;
                llenar_datagridview_Equipo();
            } else {
                MessageBox.Show("No ha ingresado id");
            }*/
            MessageBox.Show("No soportado por cambios");
        }

        private void btnModificar_Click(object sender, EventArgs e) {
            /*
            if (txtId_equipo.Text.Count() > 0) {
                var resultado = clsEquipo.buscarid(Convert.ToInt32(txtId_equipo.Text));
                lst_equipo = resultado.Item1;
                //registros = resultado.Item2;
                
                ucEquipoModificar ucEquipomodificar = new ucEquipoModificar(lst_equipo);
                ucEquipomodificar.Show();
            } else {
                MessageBox.Show("No ha ingresado id");
            }*/
            MessageBox.Show("No soportado por cambios");

        }
        
        //Funcion todo, para consultar todo los equipos registrados
        private void btnTodo_Click(object sender, EventArgs e) {
            var resultado = clsEquipo.listar();
            lst_equipo = resultado.Item1;
            registros = resultado.Item2;
            llenar_datagridview_Equipo();
        }
        //cerrar ventana
        private void btnRegresar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            ucEquipo ucequipo = new ucEquipo();
            this.Inicio.agregar(ucequipo);
        }

        

        private void Close() {
            this.Inicio.eliminar(this);
        }
    }
}