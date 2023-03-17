using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoaDatos;

namespace CapaLogicadeNegocio{
    public class ClsEquipo{
        protected int id_equipo;
        protected ClsJugador jugadores;
        

        public ClsEquipo(int Id_equipo, ClsJugador Jugadores) {
            this.Id_equipo = Id_equipo;
            this.Jugadores = Jugadores;
            
        }
        
        public ClsEquipo() { }

        public int Id_equipo { get => id_equipo; set => id_equipo = value; }
        public ClsJugador Jugadores { get => jugadores; set => jugadores = value; }
        

        //Referencia al Manejador de la capa de acceso a datos
        ClsManejador M = new ClsManejador();

        //Registrar equipo
        public virtual String registrar() {
            string msj = "";

            //Lista genérica de parámetros
            List<ClsParametros> lst = new List<ClsParametros>();

            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                ClsParametros cp = new ClsParametros();
                //cp.setEquipo(Id_equipo, Jugadores.Id_persona, Jugadores.Nombre_persona, Jugadores.Apellido, Jugadores.Cedula, Jugadores.Numero);
                lst.Add(cp);
                M.db_insertar_sobre_equipo(lst);
                msj = "Insertado correctamente";
            } catch (Exception ex) {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }
        
        //Modificar equipo
        public virtual String modificar() {
            string msj = "";

            //Lista genérica de parámetros
            List<ClsParametros> lst = new List<ClsParametros>();

            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                ClsParametros cp = new ClsParametros();
                //cp.setEquipo(Id_equipo, Jugadores.Id_persona, Jugadores.Nombre_persona, Jugadores.Apellido, Jugadores.Cedula, Jugadores.Numero);
                lst.Add(cp);
                M.db_modificar_sobre_equipo(lst);
                msj = "Insertado correctamente";
            } catch (Exception ex) {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }
        
        //Lista equipo
        public virtual Tuple<List<Object>, SqlDataAdapter> listar() {
            return M.db_consultar_sobre_equipo("SELECT [id_equipo],[jugadores] FROM [dbo].[Equipo]");
        }

        public virtual Tuple<List<Object>, SqlDataAdapter> buscarid(int Id_equipo) {
            return M.db_consultar_sobre_equipo("SELECT [id_equipo],[jugadores] FROM [dbo].[Equipo] WHERE id_equipo = " + Id_equipo);
        }
        
        public virtual String eliminar(int Id_equipo)
        {
            return M.db_remover_sobre_equipo(Id_equipo);
        }
    }
}