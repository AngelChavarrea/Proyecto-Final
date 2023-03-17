using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoaDatos;

namespace CapaLogicadeNegocio{
    public class ClsAlineacion{
        protected int id_alineacion;
        protected ClsTipoalineacion tipo_alineacion;
        protected ClsJugador jugador_alineacion;
        protected ClsEquipo equipo;

        public ClsAlineacion(int Id_alineacion, ClsTipoalineacion Tipo_alineacion, ClsJugador Jugador_alineacion, ClsEquipo Equipo) {
            this.Id_alineacion = Id_alineacion;
            this.Tipo_alineacion = Tipo_alineacion;
            this.Jugador_alineacion = Jugador_alineacion;
            this.Equipo = Equipo;
        }
        
        public ClsAlineacion() { }

        public int Id_alineacion { get => id_alineacion; set => id_alineacion = value; }
        public ClsTipoalineacion Tipo_alineacion { get => tipo_alineacion; set => tipo_alineacion = value; }
        public ClsJugador Jugador_alineacion { get => jugador_alineacion; set => jugador_alineacion = value; }
        public ClsEquipo Equipo { get => equipo; set => equipo = value; }



        //Referencia al Manejador de la capa de acceso a datos
        ClsManejador M = new ClsManejador();

        //Registrar alineacion
        public virtual String registrar() {
            string msj = "";

            //Lista genérica de parámetros
            List<ClsParametros> lst = new List<ClsParametros>();

            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                ClsParametros cp = new ClsParametros();
                //cp.setAlineacion(Id_alineacion, Tipo_alineacion.Id_tipoalineacion, Tipo_alineacion.Nombre_alineacion, Jugador_alineacion.Id_persona, Jugador_alineacion.Nombre_persona, Jugador_alineacion.Apellido, Jugador_alineacion.Cedula, Jugador_alineacion.Numero, Equipo.Id_equipo, Equipo.Jugadores.Id_persona, Equipo.Jugadores.Nombre_persona, Equipo.Jugadores.Apellido, Equipo.Jugadores.Cedula, Equipo.Jugadores.Numero);
                lst.Add(cp);
                M.db_insertar_sobre_alineacion(lst);
                msj = "Insertado correctamente";
            } catch (Exception ex) {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }
        
        //Modificar alineacion
        public virtual String modificar() {
            string msj = "";

            //Lista genérica de parámetros
            List<ClsParametros> lst = new List<ClsParametros>();

            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                ClsParametros cp = new ClsParametros();
                //cp.setAlineacion(Id_alineacion, Tipo_alineacion.Id_tipoalineacion, Tipo_alineacion.Nombre_alineacion, Jugador_alineacion.Id_persona, Jugador_alineacion.Nombre_persona, Jugador_alineacion.Apellido, Jugador_alineacion.Cedula, Jugador_alineacion.Numero, Equipo.Id_equipo, Equipo.Jugadores.Id_persona, Equipo.Jugadores.Nombre_persona, Equipo.Jugadores.Apellido, Equipo.Jugadores.Cedula, Equipo.Jugadores.Numero);
                lst.Add(cp);
                M.db_modificar_sobre_alineacion(lst);
                msj = "Insertado correctamente";
            } catch (Exception ex) {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }
        
        //Lista alineacion
        public virtual Tuple<List<Object>, SqlDataAdapter> listar() {
            return M.db_consultar_sobre_alineacion("SELECT [id_alineacion],[tipo_alineacion],[jugador_alineacion],[equipo] FROM [dbo].[Alineacion]");
        }

        public virtual Tuple<List<Object>, SqlDataAdapter> buscarid(int Id_alineacion) {
            return M.db_consultar_sobre_alineacion("SELECT [id_alineacion],[tipo_alineacion],[jugador_alineacion],[equipo] FROM [dbo].[Alineacion] WHERE id_alineacion = " + Id_alineacion);
        }
        
        public virtual String eliminar(int Id_alineacion)
        {
            return M.db_remover_sobre_alineacion(Id_alineacion);
        }
    }
}