using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoaDatos{
    /// <summary>
    /// Monton de parametros de todas las clases, por cierto esto creo que desaparecera pero eso dependera de algunas cosas
    /// </summary>
    public class ClsParametros{

        public ClsParametros(){}

        protected int id_persona;
        protected string nombres;
        protected string apellidos;
        protected string cedula;
        protected string usuario;
        protected string psw;
        protected int numero;
        protected string licencia;
        protected int id_campeonato;
        protected string nombre_campeonado;
        protected int id_acta;
        protected int id_fecha;
        protected int numero_fecha;
        protected DateTime fechainicio;
        protected DateTime fechafin;
        protected int id_equipo;
        protected int id_marcador;
        protected int goleaequipoa;
        protected int golesequipob;
        protected int id_tipoalineacion;
        protected string nombre_alineacion;
        protected int id_alineacion;
        protected int id_partido;
        protected DateTime fechanacimiento;
        protected string telefono;
        protected string nacionalidad;

        public void setPersona(int Id_persona, string Nombres, string Apellidos, string Cedula, DateTime Fechanacimiento, string Telefono, string Nacionalidad) {
            this.Id_persona = Id_persona;
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.Cedula = Cedula;
            this.Fechanacimiento = Fechanacimiento;
            this.Telefono = Telefono;
            this.Nacionalidad = Nacionalidad;
        }
        public void setAdministrador(int Id_persona, string Nombres, string Apellidos, string Cedula, string Usuario, string Psw) {
            this.Id_persona = Id_persona;
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.Cedula = Cedula;
            this.Usuario = Usuario;
            this.Psw = Psw;
        }
        public void setJugador(int Id_persona, string Nombres, string Apellidos, string Cedula, int Numero,
            DateTime FechaNacimiento, string Telefono, string Nacionalidad) {
            this.Id_persona = Id_persona;
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.Cedula = Cedula;
            this.Fechanacimiento = FechaNacimiento;
            this.Telefono = Telefono;
            this.Numero = Numero;
            this.Nacionalidad = Nacionalidad;

        }
        public void setArbitro(string Usuario, string Psw, int Id_persona, string Nombres, string Apellidos, string Cedula, string Licencia) {
            this.Usuario = Usuario;
            this.Psw = Psw;
            this.Id_persona = Id_persona;
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.Cedula = Cedula;
            this.Licencia = Licencia;
        }

        public void setMarcador(int Id_marcador, int Goleaequipoa, int Golesequipob) {
            this.Id_marcador = Id_marcador;
            this.Goleaequipoa = Goleaequipoa;
            this.Golesequipob = Golesequipob;
        }

        public void setTipoalineacion(int Id_tipoalineacion, string Nombre_alineacion) {
            this.Id_tipoalineacion = Id_tipoalineacion;
            this.Nombre_alineacion = Nombre_alineacion;
        }

        public ClsParametros(int Id_persona, string Nombres, string Apellidos, string Cedula, string Usuario, string Psw, int Numero, string Licencia, int Id_campeonato, string Nombre_campeonado, int Numero_fecha, DateTime Fechainicio, DateTime Fechafin, int Id_equipo,  int Id_marcador, int Goleaequipoa, int Golesequipob, int Id_tipoalineacion, string Nombre_alineacion, int Id_alineacion,  int Id_partido){
            this.Id_persona = Id_persona;
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.Cedula = Cedula;
            this.Usuario = Usuario;
            this.Psw = Psw;
            this.Numero = Numero;
            this.Licencia = Licencia;
            this.Id_campeonato = Id_campeonato;
            this.Nombre_campeonado = Nombre_campeonado;
            this.Id_acta = Id_acta;
            this.Id_fecha = Id_fecha;
            this.Numero_fecha = Numero_fecha;
            this.Fechainicio = Fechainicio;
            this.Fechafin = Fechafin;
            this.Id_equipo = Id_equipo;
            this.Id_marcador = Id_marcador;
            this.Goleaequipoa = Goleaequipoa;
            this.Golesequipob = Golesequipob;
            this.Id_tipoalineacion = Id_tipoalineacion;
            this.Nombre_alineacion = Nombre_alineacion;
            this.Id_alineacion = Id_alineacion;
            this.Id_partido = Id_partido;
        }

        public int Id_persona { get => id_persona; set => id_persona = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Psw { get => psw; set => psw = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Licencia { get => licencia; set => licencia = value; }
        public int Id_campeonato { get => id_campeonato; set => id_campeonato = value; }
        public string Nombre_campeonado { get => nombre_campeonado; set => nombre_campeonado = value; }
        public int Id_acta { get => id_acta; set => id_acta = value; }
        public int Id_fecha { get => id_fecha; set => id_fecha = value; }
        public int Numero_fecha { get => numero_fecha; set => numero_fecha = value; }
        public DateTime Fechainicio { get => fechainicio; set => fechainicio = value; }
        public DateTime Fechafin { get => fechafin; set => fechafin = value; }
        public int Id_equipo { get => id_equipo; set => id_equipo = value; }
        public int Id_marcador { get => id_marcador; set => id_marcador = value; }
        public int Goleaequipoa { get => goleaequipoa; set => goleaequipoa = value; }
        public int Golesequipob { get => golesequipob; set => golesequipob = value; }
        public int Id_tipoalineacion { get => id_tipoalineacion; set => id_tipoalineacion = value; }
        public string Nombre_alineacion { get => nombre_alineacion; set => nombre_alineacion = value; }
        public int Id_alineacion { get => id_alineacion; set => id_alineacion = value; }
        public int Id_partido { get => id_partido; set => id_partido = value; }
        public DateTime Fechanacimiento { get => fechanacimiento; set => fechanacimiento = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
    }
}