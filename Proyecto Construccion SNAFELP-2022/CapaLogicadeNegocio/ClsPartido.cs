using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoaDatos;

namespace CapaLogicadeNegocio{
    public class ClsPartido{
        protected int id_partido;
        protected ClsEquipo equipoa_partido;
        protected ClsEquipo equipob_partido;
        protected ClsMarcador marcador_partido;
        protected ClsArbitro arbitroprincipal;

        public ClsPartido(int Id_partido, ClsEquipo Equipoa_partido, ClsEquipo Equipob_partido, ClsMarcador Marcador_partido, ClsArbitro Arbitroprincipal) {
            this.Id_partido = Id_partido;
            this.Equipoa_partido = Equipoa_partido;
            this.Equipob_partido = Equipob_partido;
            this.Marcador_partido = Marcador_partido;
            this.Arbitroprincipal = Arbitroprincipal;
        }
        
        public ClsPartido() { }

        public int Id_partido { get => id_partido; set => id_partido = value; }
        public ClsEquipo Equipoa_partido { get => equipoa_partido; set => equipoa_partido = value; }
        public ClsEquipo Equipob_partido { get => equipob_partido; set => equipob_partido = value; }
        public ClsMarcador Marcador_partido { get => marcador_partido; set => marcador_partido = value; }
        public ClsArbitro Arbitroprincipal { get => arbitroprincipal; set => arbitroprincipal = value; }



        //Referencia al Manejador de la capa de acceso a datos
        ClsManejador M = new ClsManejador();

        //Registrar partido
        public virtual String registrar() {
            string msj = "";

            //Lista genérica de parámetros
            List<ClsParametros> lst = new List<ClsParametros>();

            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                ClsParametros cp = new ClsParametros();
                //cp.setPartido(Id_partido, Equipoa_partido.Id_equipo, Equipoa_partido.Jugadores.Id_persona, Equipoa_partido.Jugadores.Nombre_persona, Equipoa_partido.Jugadores.Apellido, Equipoa_partido.Jugadores.Cedula, Equipoa_partido.Jugadores.Numero, Equipob_partido.Id_equipo, Equipob_partido.Jugadores.Id_persona, Equipob_partido.Jugadores.Nombre_persona, Equipob_partido.Jugadores.Apellido, Equipob_partido.Jugadores.Cedula, Equipob_partido.Jugadores.Numero, Marcador_partido.Id_marcador, Marcador_partido.Goleaequipoa, Marcador_partido.Golesequipob, Arbitroprincipal.Usuario, Arbitroprincipal.Psw, Arbitroprincipal.Id_persona, Arbitroprincipal.Nombre_persona, Arbitroprincipal.Apellido, Arbitroprincipal.Cedula, Arbitroprincipal.Licencia);
                lst.Add(cp);
                M.db_insertar_sobre_partido(lst);
                msj = "Insertado correctamente";
            } catch (Exception ex) {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }
        
        //Modificar partido
        public virtual String modificar() {
            string msj = "";

            //Lista genérica de parámetros
            List<ClsParametros> lst = new List<ClsParametros>();

            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                ClsParametros cp = new ClsParametros();
                //cp.setPartido(Id_partido, Equipoa_partido.Id_equipo, Equipoa_partido.Jugadores.Id_persona, Equipoa_partido.Jugadores.Nombre_persona, Equipoa_partido.Jugadores.Apellido, Equipoa_partido.Jugadores.Cedula, Equipoa_partido.Jugadores.Numero, Equipob_partido.Id_equipo, Equipob_partido.Jugadores.Id_persona, Equipob_partido.Jugadores.Nombre_persona, Equipob_partido.Jugadores.Apellido, Equipob_partido.Jugadores.Cedula, Equipob_partido.Jugadores.Numero, Marcador_partido.Id_marcador, Marcador_partido.Goleaequipoa, Marcador_partido.Golesequipob, Arbitroprincipal.Usuario, Arbitroprincipal.Psw, Arbitroprincipal.Id_persona, Arbitroprincipal.Nombre_persona, Arbitroprincipal.Apellido, Arbitroprincipal.Cedula, Arbitroprincipal.Licencia);
                lst.Add(cp);
                M.db_modificar_sobre_partido(lst);
                msj = "Insertado correctamente";
            } catch (Exception ex) {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }
        
        //Lista partido
        public virtual Tuple<List<Object>, SqlDataAdapter> listar() {
            return M.db_consultar_sobre_partido("SELECT [id_partido],[equipoa_partido],[equipob_partido],[marcador_partido],[arbitroprincipal] FROM [dbo].[Partido]");
        }

        public virtual Tuple<List<Object>, SqlDataAdapter> buscarid(int Id_partido) {
            return M.db_consultar_sobre_partido("SELECT [id_partido],[equipoa_partido],[equipob_partido],[marcador_partido],[arbitroprincipal] FROM [dbo].[Partido] WHERE id_partido = " + Id_partido);
        }
        
        public virtual String eliminar(int Id_partido)
        {
            return M.db_remover_sobre_partido(Id_partido);
        }
    }
}