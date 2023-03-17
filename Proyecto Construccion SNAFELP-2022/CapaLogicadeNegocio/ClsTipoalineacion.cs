using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoaDatos;

namespace CapaLogicadeNegocio{
    public class ClsTipoalineacion{
        protected int id_tipoalineacion;
        protected string nombre_alineacion;

        public ClsTipoalineacion(int Id_tipoalineacion, string Nombre_alineacion) {
            this.Id_tipoalineacion = Id_tipoalineacion;
            this.Nombre_alineacion = Nombre_alineacion;
        }
        public ClsTipoalineacion() { }

        public int Id_tipoalineacion { get => id_tipoalineacion; set => id_tipoalineacion = value; }
        public string Nombre_alineacion { get => nombre_alineacion; set => nombre_alineacion = value; }



        //Referencia al Manejador de la capa de acceso a datos
        ClsManejador M = new ClsManejador();

        //Registrar tipoalineacion
        public virtual String registrar() {
            string msj = "";

            //Lista genérica de parámetros
            List<ClsParametros> lst = new List<ClsParametros>();

            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                ClsParametros cp = new ClsParametros();
                cp.setTipoalineacion(Id_tipoalineacion, Nombre_alineacion);
                lst.Add(cp);
                M.db_insertar_sobre_tipoalineacion(lst);
                msj = "Insertado correctamente";
            } catch (Exception ex) {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }
        
        //Modificar tipoalineacion
        public virtual String modificar() {
            string msj = "";

            //Lista genérica de parámetros
            List<ClsParametros> lst = new List<ClsParametros>();

            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                ClsParametros cp = new ClsParametros();
                cp.setTipoalineacion(Id_tipoalineacion, Nombre_alineacion);
                lst.Add(cp);
                M.db_modificar_sobre_tipoalineacion(lst);
                msj = "Insertado correctamente";
            } catch (Exception ex) {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }
        
        //Lista tipoalineacion
        public virtual Tuple<List<Object>, SqlDataAdapter> listar() {
            return M.db_consultar_sobre_tipoalineacion("SELECT [id_tipoalineacion],[nombre_alineacion] FROM [dbo].[Tipoalineacion]");
        }

        public virtual Tuple<List<Object>, SqlDataAdapter> buscarid(int Id_tipoalineacion) {
            return M.db_consultar_sobre_tipoalineacion("SELECT [id_tipoalineacion],[nombre_alineacion] FROM [dbo].[Tipoalineacion] WHERE id_tipoalineacion = " + Id_tipoalineacion);
        }
        
        public virtual String eliminar(int Id_tipoalineacion)
        {
            return M.db_remover_sobre_tipoalineacion(Id_tipoalineacion);
        }
    }
}