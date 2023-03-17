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
    public partial class ucCampeonato: UC_Pantalla {
        ClsCampeonato clsCampeonato = new ClsCampeonato();
        //se crea un objeto lista campeonato
        List<Object> lst_campeonato;
        public ucCampeonato() {
            InitializeComponent();

        }
        //se registra nombre y fecha del campeonato
        private void btnRegistrar_Click(object sender, EventArgs e) {
            String msj = "";
            try {
                clsCampeonato.Nombre_campeonado = txtNombre_campeonado.Text.ToString();
                clsCampeonato.Fechas = new List<ClsFecha>();
                //clsCampeonato.Fechas[clsCampeonato.Fechas.Count - 1].Id_fecha = Convert.ToInt32(txtFechas.Text);

                msj = clsCampeonato.registrar();
                MessageBox.Show(msj);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        //funcion consultar para llamar una venta donde consulten los campeonatos
        private void btnConsultar_Click(object sender, EventArgs e) {
            var resultado = clsCampeonato.listar();
            lst_campeonato = resultado.Item1;
            //registros = resultado.Item2;
            
            //Se pasa por parámetros los datos de campeonato registrados para que sean
            //tratados en el otro formulario.
            ucCampeonatoConsultar ucCampeonatoCons = new ucCampeonatoConsultar(lst_campeonato);
            ucCampeonatoCons.Show();
        }

        private void btnFechas_Click(object sender, EventArgs e) {
            /*
            //lst_campeonato = clsCampeonato.listar();
            //this.Hide();
            ucFecha uc = new ucFecha();
            var resultado = clsCampeonato.listar();
            lst_campeonato = resultado.Item1;
            //registros = resultado.Item2;
            uc.Show();//Dialog();
            //this.Show();*/
            MessageBox.Show("No soportado por cambios");
        }

        private void btnFechasAgrega_Click(object sender, EventArgs e) {
            
        }
        //cerrar ventana
        private void btnRegresar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Close() {
            this.Inicio.eliminar(this);
        }

        private void txtNombre_campeonado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}