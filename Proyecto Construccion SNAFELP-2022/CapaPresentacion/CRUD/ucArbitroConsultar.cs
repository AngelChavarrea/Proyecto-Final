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
    public partial class ucArbitroConsultar: UC_Pantalla {
        ClsArbitro clsArbitro = new ClsArbitro();
        //se crea objeto de lista arbitro
        List<Object> lst_arbitro;
        SqlDataAdapter registros;
        public ucArbitroConsultar() {
            InitializeComponent();
        }
        public ucArbitroConsultar(List<Object> lst_arbitro) {
            InitializeComponent();
            //se pasan los datos de lista arbitro a esta lista
            this.lst_arbitro = lst_arbitro;
        }
        //funcion de llenar el datagridview para la consulta de los arbitros registrados
        public void llenar_datagridview_Arbitro() {
            dgvArbitro.Rows.Clear();
            dgvArbitro.Refresh();

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var arbitro in lst_arbitro) {
                System.Type type = arbitro.GetType();

                string usuario = (string)type.GetProperty("usuario").GetValue(arbitro);
                string psw = (string)type.GetProperty("psw").GetValue(arbitro);
                int id_persona = (int)type.GetProperty("id_persona").GetValue(arbitro);
                string nombres = (string)type.GetProperty("nombre_persona").GetValue(arbitro);
                string apellidos = (string)type.GetProperty("apellido").GetValue(arbitro);
                string cedula = (string)type.GetProperty("cedula").GetValue(arbitro);
                string licencia = (string)type.GetProperty("licencia").GetValue(arbitro);

                
                dgvArbitro.Rows.Add(usuario, psw, id_persona, nombres, apellidos, cedula, licencia);
            }

        }
        //Funcion buscar un arbitro
        private void buscar() {
            dgvArbitro.Rows.Clear();
            dgvArbitro.Refresh();

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var arbitro in lst_arbitro) {
                System.Type type = arbitro.GetType();

                int Id_persona = (int)type.GetProperty("Id_persona").GetValue(arbitro);
                if (Id_persona.Equals(Convert.ToInt32(txtId_persona.Text))) {
                    
                    string usuario = (string)type.GetProperty("usuario").GetValue(arbitro);
                    string psw = (string)type.GetProperty("psw").GetValue(arbitro);
                    int id_persona = (int)type.GetProperty("id_persona").GetValue(arbitro);
                    string nombres = (string)type.GetProperty("nombre_persona").GetValue(arbitro);
                    string apellidos = (string)type.GetProperty("apellido").GetValue(arbitro);
                    string cedula = (string)type.GetProperty("cedula").GetValue(arbitro);
                    string licencia = (string)type.GetProperty("licencia").GetValue(arbitro);

                    dgvArbitro.Rows.Add(usuario, psw, id_persona, nombres, apellidos, cedula, licencia);
                    break;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            //buscar();
            if (txtId_persona.Text.Count() > 0) {
                var resultado = clsArbitro.buscarid(Convert.ToInt32(txtId_persona.Text));
                lst_arbitro = resultado.Item1;
                registros = resultado.Item2;
                llenar_datagridview_Arbitro();
            } else {
                MessageBox.Show("No ha ingresado id");
            }
        }
        //funcion eliminar un arbitro registrado
        private void btnEliminar_Click(object sender, EventArgs e) {
            if (txtId_persona.Text.Count() > 0) {
                clsArbitro.eliminar(Convert.ToInt32(txtId_persona.Text));
                var resultado = clsArbitro.listar();
                lst_arbitro = resultado.Item1;
                registros = resultado.Item2;
                llenar_datagridview_Arbitro();
            } else {
                MessageBox.Show("No ha ingresado id");
            }
        }
        //funcion modificar un arbitro registrado y nos abre la ventana donde lo modificaremos
        private void btnModificar_Click(object sender, EventArgs e) {
            if (txtId_persona.Text.Count() > 0) {
                var resultado = clsArbitro.buscarid(Convert.ToInt32(txtId_persona.Text));
                lst_arbitro = resultado.Item1;
                //registros = resultado.Item2;
                
                ucArbitroModificar ucArbitromodificar = new ucArbitroModificar(lst_arbitro);
                ucArbitromodificar.Show();
            } else {
                MessageBox.Show("No ha ingresado id");
            }
            
        }
        //funcion todo, para consultar los arbitros registrados
        private void btnTodo_Click(object sender, EventArgs e) {
            var resultado = clsArbitro.listar();
            lst_arbitro = resultado.Item1;
            registros = resultado.Item2;
            llenar_datagridview_Arbitro();
        }
        //cerrar ventana
        private void btnRegresar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            ucArbitro ucarbitro = new ucArbitro();
            this.Inicio.agregar(ucarbitro);
        }

        private void btnReporte_Click(object sender, EventArgs e) {
            /*
            DataSet ds = new DataSet();
            this.registros.Fill(ds);
            ucArbitroReporte ucarbitroreporte = new ucArbitroReporte(ds);
            ucarbitroreporte.Show();
            */
            MessageBox.Show("No soportado por cambios");
        }

        private void Close() {
            this.Inicio.eliminar(this);
        }
    }
}