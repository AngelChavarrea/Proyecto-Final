using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoaDatos;

namespace CapaLogicadeNegocio{
    public class ClsCampeonato{
        protected int id_campeonato;
        protected string nombre_campeonado;
        protected List<ClsFecha> fechas;

        public ClsCampeonato(int Id_campeonato, string Nombre_campeonado, List<ClsFecha> Fechas) {
            this.Id_campeonato = Id_campeonato;
            this.Nombre_campeonado = Nombre_campeonado;
            this.Fechas = Fechas;
        }
        
        public ClsCampeonato() { }

        public int Id_campeonato { get => id_campeonato; set => id_campeonato = value; }
        public string Nombre_campeonado { get => nombre_campeonado; set => nombre_campeonado = value; }
        public List<ClsFecha> Fechas { get => fechas; set => fechas = value; }



        //Referencia al Manejador de la capa de acceso a datos
        ClsManejador M = new ClsManejador();

        //Registrar campeonato
        public virtual String registrar() {
            string msj = "";

            //Lista genérica de parámetros
            List<ClsParametros> lst = new List<ClsParametros>();

            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                ClsParametros cp = new ClsParametros();
                //cp.setCampeonato(Id_campeonato, Nombre_campeonado, Fechas[Fechas.Count - 1].Id_fecha, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Id_partido, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Equipoa_partido.Id_equipo, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Equipoa_partido.Jugadores.Id_persona, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Equipoa_partido.Jugadores.Nombre_persona, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Equipoa_partido.Jugadores.Apellido, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Equipoa_partido.Jugadores.Cedula, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Equipoa_partido.Jugadores.Numero, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Equipob_partido.Id_equipo, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Equipob_partido.Jugadores.Id_persona, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Equipob_partido.Jugadores.Nombre_persona, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Equipob_partido.Jugadores.Apellido, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Equipob_partido.Jugadores.Cedula, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Equipob_partido.Jugadores.Numero, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Marcador_partido.Id_marcador, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Marcador_partido.Goleaequipoa, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Marcador_partido.Golesequipob, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Arbitroprincipal.Usuario, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Arbitroprincipal.Psw, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Arbitroprincipal.Id_persona, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Arbitroprincipal.Nombre_persona, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Arbitroprincipal.Apellido, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Arbitroprincipal.Cedula, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Arbitroprincipal.Licencia, Fechas[Fechas.Count - 1].Numero_fecha, Fechas[Fechas.Count - 1].Fechainicio, Fechas[Fechas.Count - 1].Fechafin);
                lst.Add(cp);
                M.db_insertar_sobre_campeonato(lst);
                msj = "Insertado correctamente";
            } catch (Exception ex) {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }
        
        //Modificar campeonato
        public virtual String modificar() {
            string msj = "";

            //Lista genérica de parámetros
            List<ClsParametros> lst = new List<ClsParametros>();

            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                ClsParametros cp = new ClsParametros();
                //cp.setCampeonato(Id_campeonato, Nombre_campeonado, Fechas[Fechas.Count - 1].Id_fecha, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Id_partido, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Equipoa_partido.Id_equipo, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Equipoa_partido.Jugadores.Id_persona, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Equipoa_partido.Jugadores.Nombre_persona, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Equipoa_partido.Jugadores.Apellido, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Equipoa_partido.Jugadores.Cedula, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Equipoa_partido.Jugadores.Numero, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Equipob_partido.Id_equipo, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Equipob_partido.Jugadores.Id_persona, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Equipob_partido.Jugadores.Nombre_persona, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Equipob_partido.Jugadores.Apellido, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Equipob_partido.Jugadores.Cedula, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Equipob_partido.Jugadores.Numero, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Marcador_partido.Id_marcador, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Marcador_partido.Goleaequipoa, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Marcador_partido.Golesequipob, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Arbitroprincipal.Usuario, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Arbitroprincipal.Psw, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Arbitroprincipal.Id_persona, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Arbitroprincipal.Nombre_persona, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Arbitroprincipal.Apellido, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Arbitroprincipal.Cedula, Fechas[Fechas.Count - 1].Partidos[Fechas[Fechas.Count - 1].Partidos.Count - 1].Arbitroprincipal.Licencia, Fechas[Fechas.Count - 1].Numero_fecha, Fechas[Fechas.Count - 1].Fechainicio, Fechas[Fechas.Count - 1].Fechafin);
                lst.Add(cp);
                M.db_modificar_sobre_campeonato(lst);
                msj = "Insertado correctamente";
            } catch (Exception ex) {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }
        
        //Lista campeonato
        public virtual Tuple<List<Object>, SqlDataAdapter> listar() {
            return M.db_consultar_sobre_campeonato("SELECT [id_campeonato],[nombre_campeonado],[fechas] FROM [dbo].[Campeonato]");
        }

        public virtual Tuple<List<Object>, SqlDataAdapter> buscarid(int Id_campeonato) {
            return M.db_consultar_sobre_campeonato("SELECT [id_campeonato],[nombre_campeonado],[fechas] FROM [dbo].[Campeonato] WHERE id_campeonato = " + Id_campeonato);
        }
        
        public virtual String eliminar(int Id_campeonato)
        {
            return M.db_remover_sobre_campeonato(Id_campeonato);
        }
    }
}