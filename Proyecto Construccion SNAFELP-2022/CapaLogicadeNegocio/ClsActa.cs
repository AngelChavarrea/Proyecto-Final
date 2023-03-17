using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoaDatos;

namespace CapaLogicadeNegocio{
    public class ClsActa{
        protected int id_acta;
        protected ClsFecha fecha;
        protected ClsPartido partido;
        protected ClsMarcador marcador_acta;
        protected ClsEquipo equipoa_acta;
        protected ClsEquipo equipob_acta;

        public ClsActa(int Id_acta, ClsFecha Fecha, ClsPartido Partido, ClsMarcador Marcador_acta, ClsEquipo Equipoa_acta, ClsEquipo Equipob_acta) {
            this.Id_acta = Id_acta;
            this.Fecha = Fecha;
            this.Partido = Partido;
            this.Marcador_acta = Marcador_acta;
            this.Equipoa_acta = Equipoa_acta;
            this.Equipob_acta = Equipob_acta;
        }
        
        public ClsActa() { }

        public int Id_acta { get => id_acta; set => id_acta = value; }
        public ClsFecha Fecha { get => fecha; set => fecha = value; }
        public ClsPartido Partido { get => partido; set => partido = value; }
        public ClsMarcador Marcador_acta { get => marcador_acta; set => marcador_acta = value; }
        public ClsEquipo Equipoa_acta { get => equipoa_acta; set => equipoa_acta = value; }
        public ClsEquipo Equipob_acta { get => equipob_acta; set => equipob_acta = value; }
        
        //Referencia al Manejador de la capa de acceso a datos
        ClsManejador M = new ClsManejador();

        //Registrar acta
        public virtual String registrar() {
            string msj = "";
            //Lista genérica de parámetros
            List<ClsParametros> lst = new List<ClsParametros>();

            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                ClsParametros cp = new ClsParametros();
                //cp.setActa(Id_acta, Fecha.Id_fecha, Fecha.Partidos[Fecha.Partidos.Count - 1].Id_partido, Fecha.Partidos[Fecha.Partidos.Count - 1].Equipoa_partido.Id_equipo, Fecha.Partidos[Fecha.Partidos.Count - 1].Equipoa_partido.Jugadores.Id_persona, Fecha.Partidos[Fecha.Partidos.Count - 1].Equipoa_partido.Jugadores.Nombre_persona, Fecha.Partidos[Fecha.Partidos.Count - 1].Equipoa_partido.Jugadores.Apellido, Fecha.Partidos[Fecha.Partidos.Count - 1].Equipoa_partido.Jugadores.Cedula, Fecha.Partidos[Fecha.Partidos.Count - 1].Equipoa_partido.Jugadores.Numero, Fecha.Partidos[Fecha.Partidos.Count - 1].Equipob_partido.Id_equipo, Fecha.Partidos[Fecha.Partidos.Count - 1].Equipob_partido.Jugadores.Id_persona, Fecha.Partidos[Fecha.Partidos.Count - 1].Equipob_partido.Jugadores.Nombre_persona, Fecha.Partidos[Fecha.Partidos.Count - 1].Equipob_partido.Jugadores.Apellido, Fecha.Partidos[Fecha.Partidos.Count - 1].Equipob_partido.Jugadores.Cedula, Fecha.Partidos[Fecha.Partidos.Count - 1].Equipob_partido.Jugadores.Numero, Fecha.Partidos[Fecha.Partidos.Count - 1].Marcador_partido.Id_marcador, Fecha.Partidos[Fecha.Partidos.Count - 1].Marcador_partido.Goleaequipoa, Fecha.Partidos[Fecha.Partidos.Count - 1].Marcador_partido.Golesequipob, Fecha.Partidos[Fecha.Partidos.Count - 1].Arbitroprincipal.Usuario, Fecha.Partidos[Fecha.Partidos.Count - 1].Arbitroprincipal.Psw, Fecha.Partidos[Fecha.Partidos.Count - 1].Arbitroprincipal.Id_persona, Fecha.Partidos[Fecha.Partidos.Count - 1].Arbitroprincipal.Nombre_persona, Fecha.Partidos[Fecha.Partidos.Count - 1].Arbitroprincipal.Apellido, Fecha.Partidos[Fecha.Partidos.Count - 1].Arbitroprincipal.Cedula, Fecha.Partidos[Fecha.Partidos.Count - 1].Arbitroprincipal.Licencia, Fecha.Numero_fecha, Fecha.Fechainicio, Fecha.Fechafin, Partido.Id_partido, Partido.Equipoa_partido.Id_equipo, Partido.Equipoa_partido.Jugadores.Id_persona, Partido.Equipoa_partido.Jugadores.Nombre_persona, Partido.Equipoa_partido.Jugadores.Apellido, Partido.Equipoa_partido.Jugadores.Cedula, Partido.Equipoa_partido.Jugadores.Numero, Partido.Equipob_partido.Id_equipo, Partido.Equipob_partido.Jugadores.Id_persona, Partido.Equipob_partido.Jugadores.Nombre_persona, Partido.Equipob_partido.Jugadores.Apellido, Partido.Equipob_partido.Jugadores.Cedula, Partido.Equipob_partido.Jugadores.Numero, Partido.Marcador_partido.Id_marcador, Partido.Marcador_partido.Goleaequipoa, Partido.Marcador_partido.Golesequipob, Partido.Arbitroprincipal.Usuario, Partido.Arbitroprincipal.Psw, Partido.Arbitroprincipal.Id_persona, Partido.Arbitroprincipal.Nombre_persona, Partido.Arbitroprincipal.Apellido, Partido.Arbitroprincipal.Cedula, Partido.Arbitroprincipal.Licencia, Marcador_acta.Id_marcador, Marcador_acta.Goleaequipoa, Marcador_acta.Golesequipob, Equipoa_acta.Id_equipo, Equipoa_acta.Jugadores.Id_persona, Equipoa_acta.Jugadores.Nombre_persona, Equipoa_acta.Jugadores.Apellido, Equipoa_acta.Jugadores.Cedula, Equipoa_acta.Jugadores.Numero, Equipob_acta.Id_equipo, Equipob_acta.Jugadores.Id_persona, Equipob_acta.Jugadores.Nombre_persona, Equipob_acta.Jugadores.Apellido, Equipob_acta.Jugadores.Cedula, Equipob_acta.Jugadores.Numero);
                lst.Add(cp);
                M.db_insertar_sobre_acta(lst);
                msj = "Insertado correctamente";
            } catch (Exception ex) {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }
        
        //Modificar acta
        public virtual String modificar() {
            string msj = "";

            //Lista genérica de parámetros
            List<ClsParametros> lst = new List<ClsParametros>();

            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                ClsParametros cp = new ClsParametros();
                //cp.setActa(Id_acta, Fecha.Id_fecha, Fecha.Partidos[Fecha.Partidos.Count - 1].Id_partido, Fecha.Partidos[Fecha.Partidos.Count - 1].Equipoa_partido.Id_equipo, Fecha.Partidos[Fecha.Partidos.Count - 1].Equipoa_partido.Jugadores.Id_persona, Fecha.Partidos[Fecha.Partidos.Count - 1].Equipoa_partido.Jugadores.Nombre_persona, Fecha.Partidos[Fecha.Partidos.Count - 1].Equipoa_partido.Jugadores.Apellido, Fecha.Partidos[Fecha.Partidos.Count - 1].Equipoa_partido.Jugadores.Cedula, Fecha.Partidos[Fecha.Partidos.Count - 1].Equipoa_partido.Jugadores.Numero, Fecha.Partidos[Fecha.Partidos.Count - 1].Equipob_partido.Id_equipo, Fecha.Partidos[Fecha.Partidos.Count - 1].Equipob_partido.Jugadores.Id_persona, Fecha.Partidos[Fecha.Partidos.Count - 1].Equipob_partido.Jugadores.Nombre_persona, Fecha.Partidos[Fecha.Partidos.Count - 1].Equipob_partido.Jugadores.Apellido, Fecha.Partidos[Fecha.Partidos.Count - 1].Equipob_partido.Jugadores.Cedula, Fecha.Partidos[Fecha.Partidos.Count - 1].Equipob_partido.Jugadores.Numero, Fecha.Partidos[Fecha.Partidos.Count - 1].Marcador_partido.Id_marcador, Fecha.Partidos[Fecha.Partidos.Count - 1].Marcador_partido.Goleaequipoa, Fecha.Partidos[Fecha.Partidos.Count - 1].Marcador_partido.Golesequipob, Fecha.Partidos[Fecha.Partidos.Count - 1].Arbitroprincipal.Usuario, Fecha.Partidos[Fecha.Partidos.Count - 1].Arbitroprincipal.Psw, Fecha.Partidos[Fecha.Partidos.Count - 1].Arbitroprincipal.Id_persona, Fecha.Partidos[Fecha.Partidos.Count - 1].Arbitroprincipal.Nombre_persona, Fecha.Partidos[Fecha.Partidos.Count - 1].Arbitroprincipal.Apellido, Fecha.Partidos[Fecha.Partidos.Count - 1].Arbitroprincipal.Cedula, Fecha.Partidos[Fecha.Partidos.Count - 1].Arbitroprincipal.Licencia, Fecha.Numero_fecha, Fecha.Fechainicio, Fecha.Fechafin, Partido.Id_partido, Partido.Equipoa_partido.Id_equipo, Partido.Equipoa_partido.Jugadores.Id_persona, Partido.Equipoa_partido.Jugadores.Nombre_persona, Partido.Equipoa_partido.Jugadores.Apellido, Partido.Equipoa_partido.Jugadores.Cedula, Partido.Equipoa_partido.Jugadores.Numero, Partido.Equipob_partido.Id_equipo, Partido.Equipob_partido.Jugadores.Id_persona, Partido.Equipob_partido.Jugadores.Nombre_persona, Partido.Equipob_partido.Jugadores.Apellido, Partido.Equipob_partido.Jugadores.Cedula, Partido.Equipob_partido.Jugadores.Numero, Partido.Marcador_partido.Id_marcador, Partido.Marcador_partido.Goleaequipoa, Partido.Marcador_partido.Golesequipob, Partido.Arbitroprincipal.Usuario, Partido.Arbitroprincipal.Psw, Partido.Arbitroprincipal.Id_persona, Partido.Arbitroprincipal.Nombre_persona, Partido.Arbitroprincipal.Apellido, Partido.Arbitroprincipal.Cedula, Partido.Arbitroprincipal.Licencia, Marcador_acta.Id_marcador, Marcador_acta.Goleaequipoa, Marcador_acta.Golesequipob, Equipoa_acta.Id_equipo, Equipoa_acta.Jugadores.Id_persona, Equipoa_acta.Jugadores.Nombre_persona, Equipoa_acta.Jugadores.Apellido, Equipoa_acta.Jugadores.Cedula, Equipoa_acta.Jugadores.Numero, Equipob_acta.Id_equipo, Equipob_acta.Jugadores.Id_persona, Equipob_acta.Jugadores.Nombre_persona, Equipob_acta.Jugadores.Apellido, Equipob_acta.Jugadores.Cedula, Equipob_acta.Jugadores.Numero);
                lst.Add(cp);
                M.db_modificar_sobre_acta(lst);
                msj = "Insertado correctamente";
            } catch (Exception ex) {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }
        
        //Lista acta
        public virtual Tuple<List<Object>, SqlDataAdapter> listar() {
            return M.db_consultar_sobre_acta("SELECT [id_acta],[fecha],[partido],[marcador_acta],[equipoa_acta],[equipob_acta] FROM [dbo].[Acta]");
        }

        public virtual Tuple<List<Object>, SqlDataAdapter> buscarid(int Id_acta) {
            return M.db_consultar_sobre_acta("SELECT [id_acta],[fecha],[partido],[marcador_acta],[equipoa_acta],[equipob_acta] FROM [dbo].[Acta] WHERE id_acta = " + Id_acta);
        }
        
        public virtual String eliminar(int Id_acta)
        {
            return M.db_remover_sobre_acta(Id_acta);
        }
    }
}