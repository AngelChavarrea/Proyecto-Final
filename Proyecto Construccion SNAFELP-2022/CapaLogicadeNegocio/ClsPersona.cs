using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoaDatos;

namespace CapaLogicadeNegocio{
    public class ClsPersona{
        protected int id_persona;
        protected string nombres;
        protected string apellidos;
        protected string cedula;
        protected DateTime fechaNacimiento;
        protected string telefono;
        protected string nacionalidad;

        public ClsPersona(int Id_persona, string Nombres, string Apellidos, string Cedula, DateTime Fechanacimiento, string Telefono, string Nacionalidad) {
            this.Id_persona = Id_persona;
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.Cedula = Cedula;
            this.Fechanacimiento = Fechanacimiento;
            this.Telefono = Telefono;
            this.Nacionalidad = Nacionalidad;
        }
        public ClsPersona() { }

        public int Id_persona { get => id_persona; set => id_persona = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Cedula { get => cedula; set => cedula = value; }

        public DateTime Fechanacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }

        //Referencia al Manejador de la capa de acceso a datos
        ClsManejador M = new ClsManejador();

        //Registrar persona
        public virtual String registrar() {
            string msj = "";

            //Lista genérica de parámetros
            List<ClsParametros> lst = new List<ClsParametros>();

            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                ClsParametros cp = new ClsParametros();
                cp.setPersona(Id_persona, Nombres, Apellidos, Cedula, Fechanacimiento, Telefono, Nacionalidad);
                lst.Add(cp);
                M.db_insertar_sobre_persona(lst);
                msj = "Insertado correctamente";
            } catch (Exception ex) {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }
        
        //Modificar persona
        public virtual String modificar() {
            string msj = "";

            //Lista genérica de parámetros
            List<ClsParametros> lst = new List<ClsParametros>();

            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                ClsParametros cp = new ClsParametros();
                cp.setPersona(Id_persona, Nombres, Apellidos, Cedula, Fechanacimiento, Telefono, Nacionalidad);
                lst.Add(cp);
                M.db_modificar_sobre_persona(lst);
                msj = "Insertado correctamente";
            } catch (Exception ex) {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }
        
        //Lista persona
        public virtual Tuple<List<Object>, SqlDataAdapter> listar() {
            return M.db_consultar_sobre_persona("SELECT [id_persona],[nombres],[apellidos],[cedula] FROM [dbo].[Persona]");
        }

        public virtual Tuple<List<Object>, SqlDataAdapter> buscarid(int Id_persona) {
            return M.db_consultar_sobre_persona("SELECT [id_persona],[nombres],[apellidos],[cedula] FROM [dbo].[Persona] WHERE id_persona = " + Id_persona);
        }
        
        public virtual String eliminar(int Id_persona)
        {
            return M.db_remover_sobre_persona(Id_persona);
        }
    }
}