using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoaDatos;

namespace CapaLogicadeNegocio{
    public class ClsJugador : ClsPersona {
        protected int numero;

        ///
        public ClsJugador(int Id_persona, string Nombres, string Apellidos, string Cedula,
            DateTime FechaNacimiento, string Telefono, string Nacionalidad, int Numero) : base(Id_persona, Nombres, Apellidos, Cedula,  FechaNacimiento, Telefono, Nacionalidad) {
            this.Numero = Numero;
        }
        /// <summary>
        /// Bob construye; ¿Podrán hacerlo?; Bob construye; ¡Sí podremos!
        /// </summary>
        public ClsJugador() { }

        /// <summary>
        /// Representa el numero que llevara el jugador durante el partido
        /// </summary>
        public int Numero { get => numero; set => numero = value; }
        /// <summary>
        /// Referencia al Manejador de la capa de acceso a datos
        ///  </summary>
        ClsManejador M = new ClsManejador();

        /// <summary>
        /// Estaba probando algo asi que siga leyendo lo de abajo
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Suma(int a, int b) {
            return M.DB_Suma(a, b);
        }
        /// <summary>
        /// Permite realizar el registro del jugador en la base de datos
        /// </summary>
        /// <returns>Retorna un mensaje indicando el estado de ejecucion de la funcion</returns>
        public override String registrar() {
            string msj = "";

            //Lista genérica de parámetros
            List<ClsParametros> lst = new List<ClsParametros>();

            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                ClsParametros cp = new ClsParametros();
                cp.setJugador(Id_persona,  Nombres, Apellidos, Cedula, Numero, Fechanacimiento, Telefono, Nacionalidad);
                lst.Add(cp);
                M.db_insertar_sobre_jugador(lst);
                msj = "Insertado correctamente";
            } catch (Exception ex) {
                msj = "Error al insertar los datos";
                return msj;
                //throw ex;
            }

            return msj;
        }
        
        /// <summary>
        /// Permite modificar los datos del jugador
        /// </summary>
        /// <returns></returns>
        public override String modificar() {
            string msj = "";

            //Lista genérica de parámetros
            List<ClsParametros> lst = new List<ClsParametros>();

            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                ClsParametros cp = new ClsParametros();
                cp.setJugador(Id_persona, Nombres, Apellidos, Cedula, Numero, Fechanacimiento, Telefono, Nacionalidad);
                lst.Add(cp);
                M.db_modificar_sobre_jugador(lst);
                msj = "Insertado correctamente";
            } catch (Exception ex) {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }
        
        /// <summary>
        /// Recupera la totalidad de jugadores registrados
        /// </summary>
        /// <returns></returns>
        public override Tuple<List<Object>, SqlDataAdapter> listar() {
            return M.ListarJugadores();
        }

        /// <summary>
        /// Regresa el jugador con el id que se especifique
        /// </summary>
        /// <param name="Id_persona"></param>
        /// <returns></returns>
        public override Tuple<List<Object>, SqlDataAdapter> buscarid(int Id_persona) {
            return null;// M.db_consultar_sobre_jugador("SELECT [id_persona],[nombres],[apellidos],[cedula],[numero] FROM [dbo].[Jugador] WHERE id_persona = " + Id_persona);
        }
        
        /// <summary>
        /// Elimina al jugador con el id que se especifique
        /// </summary>
        /// <param name="Id_persona">id de un apersona que es jugador</param>
        /// <returns></returns>
        public override String eliminar(int Id_persona)
        {
            return M.db_remover_sobre_jugador(Id_persona);
        }
    }
}