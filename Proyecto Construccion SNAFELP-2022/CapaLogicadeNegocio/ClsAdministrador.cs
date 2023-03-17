using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoaDatos;

namespace CapaLogicadeNegocio{
    public class ClsAdministrador: ClsPersona{
        protected string usuario;
        protected string psw;
        protected string puesto;

        public ClsAdministrador(int Id_persona, string Nombres, string Apellidos, string Cedula, DateTime FechaNacimiento, string Telefono, string Nacionalidad, string Usuario, string Psw, string Puesto) : base(Id_persona, Nombres, Apellidos, Cedula, FechaNacimiento, Telefono, Nacionalidad) {
            this.Usuario = Usuario;
            this.Psw = Psw;
            this.Puesto = Puesto;
        }
        public ClsAdministrador() { }

        public string Usuario { get => usuario; set => usuario = value; }
        public string Psw { get => psw; set => psw = value; }
        public string Puesto { get => puesto; set => puesto = value; }



        //Referencia al Manejador de la capa de acceso a datos
        ClsManejador M = new ClsManejador();

        //Registrar administrador
        public override String registrar() {
            string msj = "";

            //Lista genérica de parámetros
            List<ClsParametros> lst = new List<ClsParametros>();

            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                ClsParametros cp = new ClsParametros();
                cp.setAdministrador(Id_persona, Nombres, Apellidos, Cedula, Usuario, Psw);
                lst.Add(cp);
                M.db_insertar_sobre_administrador(lst);
                msj = "Insertado correctamente";
            } catch (Exception ex) {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }
        
        //Modificar administrador
        public override String modificar() {
            string msj = "";

            //Lista genérica de parámetros
            List<ClsParametros> lst = new List<ClsParametros>();

            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                ClsParametros cp = new ClsParametros();
                cp.setAdministrador(Id_persona, Nombres, Apellidos, Cedula, Usuario, Psw);
                lst.Add(cp);
                M.db_modificar_sobre_administrador(lst);
                msj = "Insertado correctamente";
            } catch (Exception ex) {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }
        
        //Lista administrador
        public override Tuple<List<Object>, SqlDataAdapter> listar() {
            return M.db_consultar_sobre_administrador("SELECT [id_persona],[nombre_persona],[apellido],[cedula],[usuario],[psw] FROM [dbo].[Administrador]");
        }

        public override Tuple<List<Object>, SqlDataAdapter> buscarid(int Id_persona) {
            return M.db_consultar_sobre_administrador("SELECT [id_persona],[nombre_persona],[apellido],[cedula],[usuario],[psw] FROM [dbo].[Administrador] WHERE id_persona = " + Id_persona);
        }
        
        public override String eliminar(int Id_persona)
        {
            return M.db_remover_sobre_administrador(Id_persona);
        }
    }
}