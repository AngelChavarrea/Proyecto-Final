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
    public partial class ucCampeonatoConsultar: UC_Pantalla {
        ClsCampeonato clsCampeonato = new ClsCampeonato();
        //se crea un objeto lista de campeonato
        List<Object> lst_campeonato;
        SqlDataAdapter registros;
        public ucCampeonatoConsultar() {
            InitializeComponent();
        }
        public ucCampeonatoConsultar(List<Object> lst_campeonato) {
            InitializeComponent();
            //los datos de la lista campeonato se pasan a esta lista
            this.lst_campeonato = lst_campeonato;
        }
        //se llena el datagridview para con los campeonatos registrados
        public void llenar_datagridview_Campeonato() {
            dgvCampeonato.Rows.Clear();
            dgvCampeonato.Refresh();

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var campeonato in lst_campeonato) {
                System.Type type = campeonato.GetType();

                int id_campeonato = (int)type.GetProperty("id_campeonato").GetValue(campeonato);
                string nombre_campeonado = (string)type.GetProperty("nombre_campeonado").GetValue(campeonato);
                int fechas = (int)type.GetProperty("fechas").GetValue(campeonato);

                
                dgvCampeonato.Rows.Add(id_campeonato, nombre_campeonado, fechas);
            }

        }
        //funcion buscar
        private void buscar() {
            dgvCampeonato.Rows.Clear();
            dgvCampeonato.Refresh();

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var campeonato in lst_campeonato) {
                System.Type type = campeonato.GetType();

                int Id_campeonato = (int)type.GetProperty("Id_campeonato").GetValue(campeonato);
                if (Id_campeonato.Equals(Convert.ToInt32(txtId_campeonato.Text))) {
                    
                    int id_campeonato = (int)type.GetProperty("id_campeonato").GetValue(campeonato);
                    string nombre_campeonado = (string)type.GetProperty("nombre_campeonado").GetValue(campeonato);
                    int fechas = (int)type.GetProperty("fechas").GetValue(campeonato);

                    dgvCampeonato.Rows.Add(id_campeonato, nombre_campeonado, fechas);
                    break;
                }
            }
        }
        //funcion de buscar por id y llenar el datagridview
        private void btnBuscar_Click(object sender, EventArgs e) {
            //buscar();
            if (txtId_campeonato.Text.Count() > 0) {
                var resultado = clsCampeonato.buscarid(Convert.ToInt32(txtId_campeonato.Text));
                lst_campeonato = resultado.Item1;
                registros = resultado.Item2;
                llenar_datagridview_Campeonato();
            } else {
                MessageBox.Show("No ha ingresado id");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e) {
            if (txtId_campeonato.Text.Count() > 0) {
                clsCampeonato.eliminar(Convert.ToInt32(txtId_campeonato.Text));
                var resultado = clsCampeonato.listar();
                lst_campeonato = resultado.Item1;
                registros = resultado.Item2;
                llenar_datagridview_Campeonato();
            } else {
                MessageBox.Show("No ha ingresado id");
            }
        }
        //funcion modificar, si el de id del campeonato esta, abre otra ventana para 
        private void btnModificar_Click(object sender, EventArgs e) {
            if (txtId_campeonato.Text.Count() > 0) {
                var resultado = clsCampeonato.buscarid(Convert.ToInt32(txtId_campeonato.Text));
                lst_campeonato = resultado.Item1;
                //registros = resultado.Item2;
                
                ucCampeonatoModificar ucCampeonatomodificar = new ucCampeonatoModificar(lst_campeonato);
                ucCampeonatomodificar.Show();
            } else {
                MessageBox.Show("No ha ingresado id");
            }
            
        }
        //funcion de todo, para consultar todos los campeonatos
        private void btnTodo_Click(object sender, EventArgs e) {
            var resultado = clsCampeonato.listar();
            lst_campeonato = resultado.Item1;
            registros = resultado.Item2;
            llenar_datagridview_Campeonato();
        }
        //cerrar ventana
        private void btnRegresar_Click(object sender, EventArgs e) {
            this.Close();
        }
        //agregar campeonato
        private void btnAgregar_Click(object sender, EventArgs e) {
            ucCampeonato uccampeonato = new ucCampeonato();
            this.Inicio.agregar(uccampeonato);
        }
        //funcion para crear el reporte del campeonato
        private void btnReporte_Click(object sender, EventArgs e) {
            /*
            DataSet ds = new DataSet();
            this.registros.Fill(ds);
            ucCampeonatoReporte uccampeonatoreporte = new ucCampeonatoReporte(ds);
            uccampeonatoreporte.Show();
            */
            MessageBox.Show("No soportado por cambios");
        }

        private void Close() {
            this.Inicio.eliminar(this);
        }
    }
}