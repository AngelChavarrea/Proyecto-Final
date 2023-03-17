using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoaDatos;

namespace CapaLogicadeNegocio{
    public class ClsFecha{
        protected int id_fecha;
        protected List<ClsPartido> partidos;
        protected int numero_fecha;
        protected DateTime fechainicio;
        protected DateTime fechafin;

        public ClsFecha(int Id_fecha, List<ClsPartido> Partidos, int Numero_fecha, DateTime Fechainicio, DateTime Fechafin) {
            this.Id_fecha = Id_fecha;
            this.Partidos = Partidos;
            this.Numero_fecha = Numero_fecha;
            this.Fechainicio = Fechainicio;
            this.Fechafin = Fechafin;
        }
        
        public ClsFecha() { }

        public int Id_fecha { get => id_fecha; set => id_fecha = value; }
        public List<ClsPartido> Partidos { get => partidos; set => partidos = value; }
        public int Numero_fecha { get => numero_fecha; set => numero_fecha = value; }
        public DateTime Fechainicio { get => fechainicio; set => fechainicio = value; }
        public DateTime Fechafin { get => fechafin; set => fechafin = value; }



        //Referencia al Manejador de la capa de acceso a datos
        ClsManejador M = new ClsManejador();

        //Registrar fecha
        public virtual String registrar() {
            string msj = "";

            //Lista genérica de parámetros
            List<ClsParametros> lst = new List<ClsParametros>();

            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                ClsParametros cp = new ClsParametros();
                //cp.setFecha(Id_fecha, Partidos[Partidos.Count - 1].Id_partido, Partidos[Partidos.Count - 1].Equipoa_partido.Id_equipo, Partidos[Partidos.Count - 1].Equipoa_partido.Jugadores.Id_persona, Partidos[Partidos.Count - 1].Equipoa_partido.Jugadores.Nombre_persona, Partidos[Partidos.Count - 1].Equipoa_partido.Jugadores.Apellido, Partidos[Partidos.Count - 1].Equipoa_partido.Jugadores.Cedula, Partidos[Partidos.Count - 1].Equipoa_partido.Jugadores.Numero, Partidos[Partidos.Count - 1].Equipob_partido.Id_equipo, Partidos[Partidos.Count - 1].Equipob_partido.Jugadores.Id_persona, Partidos[Partidos.Count - 1].Equipob_partido.Jugadores.Nombre_persona, Partidos[Partidos.Count - 1].Equipob_partido.Jugadores.Apellido, Partidos[Partidos.Count - 1].Equipob_partido.Jugadores.Cedula, Partidos[Partidos.Count - 1].Equipob_partido.Jugadores.Numero, Partidos[Partidos.Count - 1].Marcador_partido.Id_marcador, Partidos[Partidos.Count - 1].Marcador_partido.Goleaequipoa, Partidos[Partidos.Count - 1].Marcador_partido.Golesequipob, Partidos[Partidos.Count - 1].Arbitroprincipal.Usuario, Partidos[Partidos.Count - 1].Arbitroprincipal.Psw, Partidos[Partidos.Count - 1].Arbitroprincipal.Id_persona, Partidos[Partidos.Count - 1].Arbitroprincipal.Nombre_persona, Partidos[Partidos.Count - 1].Arbitroprincipal.Apellido, Partidos[Partidos.Count - 1].Arbitroprincipal.Cedula, Partidos[Partidos.Count - 1].Arbitroprincipal.Licencia, Numero_fecha, Fechainicio, Fechafin);
                lst.Add(cp);
                M.db_insertar_sobre_fecha(lst);
                msj = "Insertado correctamente";
            } catch (Exception ex) {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }
        
        //Modificar fecha
        public virtual String modificar() {
            string msj = "";

            //Lista genérica de parámetros
            List<ClsParametros> lst = new List<ClsParametros>();

            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                ClsParametros cp = new ClsParametros();
                //cp.setFecha(Id_fecha, Partidos[Partidos.Count - 1].Id_partido, Partidos[Partidos.Count - 1].Equipoa_partido.Id_equipo, Partidos[Partidos.Count - 1].Equipoa_partido.Jugadores.Id_persona, Partidos[Partidos.Count - 1].Equipoa_partido.Jugadores.Nombre_persona, Partidos[Partidos.Count - 1].Equipoa_partido.Jugadores.Apellido, Partidos[Partidos.Count - 1].Equipoa_partido.Jugadores.Cedula, Partidos[Partidos.Count - 1].Equipoa_partido.Jugadores.Numero, Partidos[Partidos.Count - 1].Equipob_partido.Id_equipo, Partidos[Partidos.Count - 1].Equipob_partido.Jugadores.Id_persona, Partidos[Partidos.Count - 1].Equipob_partido.Jugadores.Nombre_persona, Partidos[Partidos.Count - 1].Equipob_partido.Jugadores.Apellido, Partidos[Partidos.Count - 1].Equipob_partido.Jugadores.Cedula, Partidos[Partidos.Count - 1].Equipob_partido.Jugadores.Numero, Partidos[Partidos.Count - 1].Marcador_partido.Id_marcador, Partidos[Partidos.Count - 1].Marcador_partido.Goleaequipoa, Partidos[Partidos.Count - 1].Marcador_partido.Golesequipob, Partidos[Partidos.Count - 1].Arbitroprincipal.Usuario, Partidos[Partidos.Count - 1].Arbitroprincipal.Psw, Partidos[Partidos.Count - 1].Arbitroprincipal.Id_persona, Partidos[Partidos.Count - 1].Arbitroprincipal.Nombre_persona, Partidos[Partidos.Count - 1].Arbitroprincipal.Apellido, Partidos[Partidos.Count - 1].Arbitroprincipal.Cedula, Partidos[Partidos.Count - 1].Arbitroprincipal.Licencia, Numero_fecha, Fechainicio, Fechafin);
                lst.Add(cp);
                M.db_modificar_sobre_fecha(lst);
                msj = "Insertado correctamente";
            } catch (Exception ex) {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }
        
        //Lista fecha
        public virtual Tuple<List<Object>, SqlDataAdapter> listar() {
            return M.db_consultar_sobre_fecha("SELECT [id_fecha],[partidos],[numero_fecha],[fechainicio],[fechafin] FROM [dbo].[Fecha]");
        }

        public virtual Tuple<List<Object>, SqlDataAdapter> buscarid(int Id_fecha) {
            return M.db_consultar_sobre_fecha("SELECT [id_fecha],[partidos],[numero_fecha],[fechainicio],[fechafin] FROM [dbo].[Fecha] WHERE id_fecha = " + Id_fecha);
        }
        
        public virtual String eliminar(int Id_fecha)
        {
            return M.db_remover_sobre_fecha(Id_fecha);
        }
    }
}