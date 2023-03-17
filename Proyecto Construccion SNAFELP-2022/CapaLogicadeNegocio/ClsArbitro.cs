using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoaDatos;

namespace CapaLogicadeNegocio{
    public class ClsArbitro: ClsAdministrador{
        protected string licencia;

        public ClsArbitro(int Id_persona, string Nombres, string Apellidos, string Cedula, DateTime FechaNacimiento, string Telefono, string Usuario, string Psw, string Puesto, string Licencia, string Nacionalidad) : base(Id_persona, Nombres, Apellidos, Cedula, FechaNacimiento, Telefono, Nacionalidad, Usuario, Psw, Puesto) {
            this.Licencia = Licencia;
            this.Nacionalidad = Nacionalidad;
        }
        public ClsArbitro() { }

        public string Licencia { get => licencia; set => licencia = value; }
        
        //Referencia al Manejador de la capa de acceso a datos
        ClsManejador M = new ClsManejador();

        //Registrar arbitro
        public override String registrar() {
            string msj = "";

            //Lista genérica de parámetros
            List<ClsParametros> lst = new List<ClsParametros>();

            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                ClsParametros cp = new ClsParametros();
                cp.setArbitro(Usuario, Psw, Id_persona, Nombres, Apellidos, Cedula, Licencia);
                lst.Add(cp);
                M.db_insertar_sobre_arbitro(lst);
                msj = "Insertado correctamente";
            } catch (Exception ex) {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }
        
        //Modificar arbitro
        public override String modificar() {
            string msj = "";

            //Lista genérica de parámetros
            List<ClsParametros> lst = new List<ClsParametros>();

            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                ClsParametros cp = new ClsParametros();
                cp.setArbitro(Usuario, Psw, Id_persona, Nombres, Apellidos, Cedula, Licencia);
                lst.Add(cp);
                M.db_modificar_sobre_arbitro(lst);
                msj = "Insertado correctamente";
            } catch (Exception ex) {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }
        
        //Lista arbitro
        public override Tuple<List<Object>, SqlDataAdapter> listar() {
            return M.db_consultar_sobre_arbitro("SELECT [usuario],[psw],[id_persona],[nombre_persona],[apellido],[cedula],[licencia] FROM [dbo].[Arbitro]");
        }

        public override Tuple<List<Object>, SqlDataAdapter> buscarid(int Id_persona) {
            return M.db_consultar_sobre_arbitro("SELECT [usuario],[psw],[id_persona],[nombre_persona],[apellido],[cedula],[licencia] FROM [dbo].[Arbitro] WHERE id_persona = " + Id_persona);
        }
        
        public override String eliminar(int Id_persona)
        {
            return M.db_remover_sobre_arbitro(Id_persona);
        }
    }
}