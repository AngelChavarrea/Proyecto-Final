using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoaDatos;

namespace CapaLogicadeNegocio{
    public class ClsMarcador{
        protected int id_marcador;
        protected int goleaequipoa;
        protected int golesequipob;

        public ClsMarcador(int Id_marcador, int Goleaequipoa, int Golesequipob) {
            this.Id_marcador = Id_marcador;
            this.Goleaequipoa = Goleaequipoa;
            this.Golesequipob = Golesequipob;
        }
        public ClsMarcador() { }

        public int Id_marcador { get => id_marcador; set => id_marcador = value; }
        public int Goleaequipoa { get => goleaequipoa; set => goleaequipoa = value; }
        public int Golesequipob { get => golesequipob; set => golesequipob = value; }



        //Referencia al Manejador de la capa de acceso a datos
        ClsManejador M = new ClsManejador();

        //Registrar marcador
        public virtual String registrar() {
            string msj = "";

            //Lista genérica de parámetros
            List<ClsParametros> lst = new List<ClsParametros>();

            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                ClsParametros cp = new ClsParametros();
                cp.setMarcador(Id_marcador, Goleaequipoa, Golesequipob);
                lst.Add(cp);
                M.db_insertar_sobre_marcador(lst);
                msj = "Insertado correctamente";
            } catch (Exception ex) {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }
        
        //Modificar marcador
        public virtual String modificar() {
            string msj = "";

            //Lista genérica de parámetros
            List<ClsParametros> lst = new List<ClsParametros>();

            try {
                //Pasar los parámetros hacia la capa de acceso a datos
                ClsParametros cp = new ClsParametros();
                cp.setMarcador(Id_marcador, Goleaequipoa, Golesequipob);
                lst.Add(cp);
                M.db_modificar_sobre_marcador(lst);
                msj = "Insertado correctamente";
            } catch (Exception ex) {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }

        public void EquipoGanador(){
            //string Ganador = "";
            
            if (Goleaequipoa >golesequipob)
            {
                Console.WriteLine("Equipo ganador es A");
            }else
            {
                Console.WriteLine("Equipo ganador es B");
            }

            //return Ganador;
        }

        //Lista marcador
        public virtual Tuple<List<Object>, SqlDataAdapter> listar() {
            return M.db_consultar_sobre_marcador("SELECT [id_marcador],[goleaequipoa],[golesequipob] FROM [dbo].[Marcador]");
        }

        public virtual Tuple<List<Object>, SqlDataAdapter> buscarid(int Id_marcador) {
            return M.db_consultar_sobre_marcador("SELECT [id_marcador],[goleaequipoa],[golesequipob] FROM [dbo].[Marcador] WHERE id_marcador = " + Id_marcador);
        }
        
        public virtual String eliminar(int Id_marcador)
        {
            return M.db_remover_sobre_marcador(Id_marcador);
        }
    }
}