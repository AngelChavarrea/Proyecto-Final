using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;
//using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace CapaAccesoaDatos{
    /// <summary>
    /// Aqui esta la manipulacion de la base de datos pero aun esta mezclado
    /// </summary>
    public class ClsManejador{
        SqlServer db;

        public ClsManejador() {
            db = new SqlServer();
            db.Abrir_conexion();
        }
        
        //Abrir conexion a BD
        SqlConnection abrir_conexion() {
            db.Abrir_conexion();
            return db.Conexion;
        }

        //Cerrar conexion a BD
        void cerrar_conexion() {
            db.Cerrar_conexion(); 
        }
        public int DB_Suma(int a, int b) {
            int retorna= 0;
            try {
                SqlConnection conexion = abrir_conexion();

                String cadena = "EXECUTE probando @valorA, @valorB";   

                SqlCommand comando = new SqlCommand(cadena, conexion);

                comando.Parameters.AddWithValue("@valorA", 50);
                comando.Parameters.AddWithValue("@valorB", 20);
                retorna = (int)comando.ExecuteScalar();
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return retorna;
        }
        //Base de datos
        public Tuple<List<Object>, SqlDataAdapter> db_consultar_sobre_persona(string sentenciaSQL) {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = sentenciaSQL;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                //comando.CommandText = "";//Linea opcional para rellenar los datos
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        id_persona = Convert.ToInt32(dr["id_persona"]),
                        nombre_persona = dr["nombre_persona"].ToString(),
                        apellido = dr["apellido"].ToString(),
                        cedula = dr["cedula"].ToString()
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        public Tuple<List<Object>, SqlDataAdapter> db_consultar_sobre_administrador(string sentenciaSQL) {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = sentenciaSQL;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                //comando.CommandText = "";//Linea opcional para rellenar los datos
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        id_persona = Convert.ToInt32(dr["id_persona"]),
                        nombre_persona = dr["nombre_persona"].ToString(),
                        apellido = dr["apellido"].ToString(),
                        cedula = dr["cedula"].ToString(),
                        usuario = dr["usuario"].ToString(),
                        psw = dr["psw"].ToString()
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        /*public Tuple<List<Object>, SqlDataAdapter> JugadorPorNombre(string sentenciaSQL) {

        }*/
        /// <summary>
        /// Muestra todos los jugadores registrados en el sistema
        /// </summary>
        /// <returns></returns>
        public Tuple<List<Object>, SqlDataAdapter> ListarJugadores() {
            return db_consultar_sobre_jugador("SELECT [id_persona],[nombres],[apellidos],[cedula],[fechanacimiento],[telefono],[nacionalidad],[numero] FROM [dbo].[Jugador]");
        }

        public Tuple<List<Object>, SqlDataAdapter> buscarid(int Id_persona) {
            return db_consultar_sobre_jugador("SELECT [id_persona],[nombre_persona],[apellido],[cedula],[numero] FROM [dbo].[Jugador] WHERE id_persona = " + Id_persona);
        }
        private Tuple<List<Object>, SqlDataAdapter> db_consultar_sobre_jugador(string sentenciaSQL) {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = sentenciaSQL;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                //comando.CommandText = "";//Linea opcional para rellenar los datos
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        id_persona = Convert.ToInt32(dr["id_persona"]),
                        nombres = dr["nombres"].ToString(),
                        apellidos = dr["apellidos"].ToString(),
                        cedula = dr["cedula"].ToString(),
                        fechanacimiento = DateTime.Parse(dr["fechanacimiento"].ToString()),
                        telefono = dr["telefono"].ToString(),
                        nacionalidad = dr["nacionalidad"].ToString(),
                        numero = Convert.ToUInt16(dr["numero"])
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        public Tuple<List<Object>, SqlDataAdapter> db_consultar_sobre_arbitro(string sentenciaSQL) {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = sentenciaSQL;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                //comando.CommandText = "";//Linea opcional para rellenar los datos
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        usuario = dr["usuario"].ToString(),
                        psw = dr["psw"].ToString(),
                        id_persona = Convert.ToInt32(dr["id_persona"]),
                        nombre_persona = dr["nombre_persona"].ToString(),
                        apellido = dr["apellido"].ToString(),
                        cedula = dr["cedula"].ToString(),
                        licencia = dr["licencia"].ToString()
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        public Tuple<List<Object>, SqlDataAdapter> db_consultar_sobre_campeonato(string sentenciaSQL) {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = sentenciaSQL;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                //comando.CommandText = "";//Linea opcional para rellenar los datos
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        id_campeonato = Convert.ToInt32(dr["id_campeonato"]),
                        nombre_campeonado = dr["nombre_campeonado"].ToString(),
                        fechas = Convert.ToInt32(dr["fechas"])
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        public Tuple<List<Object>, SqlDataAdapter> db_consultar_sobre_acta(string sentenciaSQL) {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = sentenciaSQL;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                //comando.CommandText = "";//Linea opcional para rellenar los datos
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        id_acta = Convert.ToInt32(dr["id_acta"]),
                        fecha = Convert.ToInt32(dr["fecha"]),
                        partido = Convert.ToInt32(dr["partido"]),
                        marcador_acta = Convert.ToInt32(dr["marcador_acta"]),
                        equipoa_acta = Convert.ToInt32(dr["equipoa_acta"]),
                        equipob_acta = Convert.ToInt32(dr["equipob_acta"])
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        public Tuple<List<Object>, SqlDataAdapter> db_consultar_sobre_fecha(string sentenciaSQL) {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = sentenciaSQL;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                //comando.CommandText = "";//Linea opcional para rellenar los datos
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        id_fecha = Convert.ToInt32(dr["id_fecha"]),
                        partidos = Convert.ToInt32(dr["partidos"]),
                        numero_fecha = Convert.ToInt32(dr["numero_fecha"]),
                        fechainicio = DateTime.Parse(dr["fechainicio"].ToString()),
                        fechafin = DateTime.Parse(dr["fechafin"].ToString())
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        public Tuple<List<Object>, SqlDataAdapter> db_consultar_sobre_equipo(string sentenciaSQL) {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = sentenciaSQL;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                //comando.CommandText = "";//Linea opcional para rellenar los datos
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        id_equipo = Convert.ToInt32(dr["id_equipo"]),
                        jugadores = Convert.ToInt32(dr["jugadores"])
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        public Tuple<List<Object>, SqlDataAdapter> db_consultar_sobre_marcador(string sentenciaSQL) {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = sentenciaSQL;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                //comando.CommandText = "";//Linea opcional para rellenar los datos
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        id_marcador = Convert.ToInt32(dr["id_marcador"]),
                        goleaequipoa = Convert.ToUInt16(dr["goleaequipoa"]),
                        golesequipob = Convert.ToUInt16(dr["golesequipob"])
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        public Tuple<List<Object>, SqlDataAdapter> db_consultar_sobre_tipoalineacion(string sentenciaSQL) {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = sentenciaSQL;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                //comando.CommandText = "";//Linea opcional para rellenar los datos
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        id_tipoalineacion = Convert.ToInt32(dr["id_tipoalineacion"]),
                        nombre_alineacion = dr["nombre_alineacion"].ToString()
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        public Tuple<List<Object>, SqlDataAdapter> db_consultar_sobre_alineacion(string sentenciaSQL) {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = sentenciaSQL;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                //comando.CommandText = "";//Linea opcional para rellenar los datos
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        id_alineacion = Convert.ToInt32(dr["id_alineacion"]),
                        tipo_alineacion = Convert.ToInt32(dr["tipo_alineacion"]),
                        jugador_alineacion = Convert.ToInt32(dr["jugador_alineacion"]),
                        equipo = Convert.ToInt32(dr["equipo"])
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }
        public Tuple<List<Object>, SqlDataAdapter> db_consultar_sobre_partido(string sentenciaSQL) {
            //lreturn.Clear();
            SqlDataReader dr = null;
            List<Object> lreturn = new List<Object>();
            SqlDataAdapter adaptador;
            try {
                SqlConnection conexion = abrir_conexion();
                String cadena = sentenciaSQL;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                //comando.CommandText = "";//Linea opcional para rellenar los datos
                dr = comando.ExecuteReader();
                adaptador = new SqlDataAdapter(cadena, conexion);

                while (dr.Read()) {
                    var tmp = new {
                        id_partido = Convert.ToInt32(dr["id_partido"]),
                        equipoa_partido = Convert.ToInt32(dr["equipoa_partido"]),
                        equipob_partido = Convert.ToInt32(dr["equipob_partido"]),
                        marcador_partido = Convert.ToInt32(dr["marcador_partido"]),
                        arbitroprincipal = Convert.ToInt32(dr["arbitroprincipal"])
                    };
                    lreturn.Add(tmp);
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return Tuple.Create(lreturn, adaptador);
            //return lreturn;
        }

        public String db_modificar_sobre_persona(List<ClsParametros> lst) {
            String mensaje = "";
            try {
                if (mensaje == "" && lst != null) {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "UPDATE Persona SET nombre_persona = @Nombres, Apellidos = @apellido, cedula = @cedula WHERE id_persona = @id_persona";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@id_persona", lst[0].Id_persona);
                    comando.Parameters.AddWithValue("@nombre_persona", lst[0].Nombres);
                    comando.Parameters.AddWithValue("@apellido", lst[0].Apellidos);
                    comando.Parameters.AddWithValue("@cedula", lst[0].Cedula);
                    
                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String db_modificar_sobre_administrador(List<ClsParametros> lst) {
            String mensaje = "";
            try {
                if (mensaje == "" && lst != null) {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "UPDATE Administrador SET nombre_persona = @Nombres, Apellidos = @apellido, cedula = @cedula, usuario = @usuario, psw = @psw WHERE id_persona = @id_persona";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@id_persona", lst[0].Id_persona);
                    comando.Parameters.AddWithValue("@nombre_persona", lst[0].Nombres);
                    comando.Parameters.AddWithValue("@apellido", lst[0].Apellidos);
                    comando.Parameters.AddWithValue("@cedula", lst[0].Cedula);
                    comando.Parameters.AddWithValue("@usuario", lst[0].Usuario);
                    comando.Parameters.AddWithValue("@psw", lst[0].Psw);
                    
                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }

        /// <summary>
        /// Permite modificar un jugador en la base de datos segun el id de jugador qu ese le einvie junto con los tados a modificar
        /// </summary>
        /// <param name="lst"></param>
        /// <returns></returns>
        public String db_modificar_sobre_jugador(List<ClsParametros> lst) {
            String mensaje = "";
            try {
                if (mensaje == "" && lst != null) {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "UPDATE Jugador SET nombre_persona = @Nombres, Apellidos = @apellido, cedula = @cedula, numero = @numero WHERE id_persona = @id_persona";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@id_persona", lst[0].Id_persona);
                    comando.Parameters.AddWithValue("@nombre_persona", lst[0].Nombres);
                    comando.Parameters.AddWithValue("@apellido", lst[0].Apellidos);
                    comando.Parameters.AddWithValue("@cedula", lst[0].Cedula);
                    comando.Parameters.AddWithValue("@numero", lst[0].Numero);
                    
                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String db_modificar_sobre_arbitro(List<ClsParametros> lst) {
            String mensaje = "";
            try {
                if (mensaje == "" && lst != null) {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "UPDATE Arbitro SET usuario = @usuario, psw = @pswnombre_persona = @Nombres, Apellidos = @apellido, cedula = @cedula, licencia = @licencia WHERE id_persona = @id_persona";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@usuario", lst[0].Usuario);
                    comando.Parameters.AddWithValue("@psw", lst[0].Psw);
                    comando.Parameters.AddWithValue("@id_persona", lst[0].Id_persona);
                    comando.Parameters.AddWithValue("@nombre_persona", lst[0].Nombres);
                    comando.Parameters.AddWithValue("@apellido", lst[0].Apellidos);
                    comando.Parameters.AddWithValue("@cedula", lst[0].Cedula);
                    comando.Parameters.AddWithValue("@licencia", lst[0].Licencia);
                    
                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String db_modificar_sobre_campeonato(List<ClsParametros> lst) {
            String mensaje = "";
            try {
                if (mensaje == "" && lst != null) {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "UPDATE Campeonato SET nombre_campeonado = @nombre_campeonadofechas_partidos_equipoa_partido_jugadores_nombre_persona = @fechas_partidos_equipoa_partido_jugadores_nombre_persona, fechas_partidos_equipoa_partido_jugadores_apellido = @fechas_partidos_equipoa_partido_jugadores_apellido, fechas_partidos_equipoa_partido_jugadores_cedula = @fechas_partidos_equipoa_partido_jugadores_cedula, fechas_partidos_equipoa_partido_jugadores_numero = @fechas_partidos_equipoa_partido_jugadores_numerofechas_partidos_equipob_partido_jugadores_nombre_persona = @fechas_partidos_equipob_partido_jugadores_nombre_persona, fechas_partidos_equipob_partido_jugadores_apellido = @fechas_partidos_equipob_partido_jugadores_apellido, fechas_partidos_equipob_partido_jugadores_cedula = @fechas_partidos_equipob_partido_jugadores_cedula, fechas_partidos_equipob_partido_jugadores_numero = @fechas_partidos_equipob_partido_jugadores_numerofechas_partidos_marcador_partido_goleaequipoa = @fechas_partidos_marcador_partido_goleaequipoa, fechas_partidos_marcador_partido_golesequipob = @fechas_partidos_marcador_partido_golesequipob, fechas_partidos_arbitroprincipal_usuario = @fechas_partidos_arbitroprincipal_usuario, fechas_partidos_arbitroprincipal_psw = @fechas_partidos_arbitroprincipal_pswfechas_partidos_arbitroprincipal_nombre_persona = @fechas_partidos_arbitroprincipal_nombre_persona, fechas_partidos_arbitroprincipal_apellido = @fechas_partidos_arbitroprincipal_apellido, fechas_partidos_arbitroprincipal_cedula = @fechas_partidos_arbitroprincipal_cedula, fechas_partidos_arbitroprincipal_licencia = @fechas_partidos_arbitroprincipal_licencia, fechas_numero_fecha = @fechas_numero_fecha, fechas_fechainicio = @fechas_fechainicio, fechas_fechafin = @fechas_fechafin WHERE id_campeonato = @id_campeonato";

                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    
                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String db_modificar_sobre_acta(List<ClsParametros> lst) {
            String mensaje = "";
            try {
                if (mensaje == "" && lst != null) {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "UPDATE Acta SET fecha_partidos_equipoa_partido_jugadores_nombre_persona = @fecha_partidos_equipoa_partido_jugadores_nombre_persona, fecha_partidos_equipoa_partido_jugadores_apellido = @fecha_partidos_equipoa_partido_jugadores_apellido, fecha_partidos_equipoa_partido_jugadores_cedula = @fecha_partidos_equipoa_partido_jugadores_cedula, fecha_partidos_equipoa_partido_jugadores_numero = @fecha_partidos_equipoa_partido_jugadores_numerofecha_partidos_equipob_partido_jugadores_nombre_persona = @fecha_partidos_equipob_partido_jugadores_nombre_persona, fecha_partidos_equipob_partido_jugadores_apellido = @fecha_partidos_equipob_partido_jugadores_apellido, fecha_partidos_equipob_partido_jugadores_cedula = @fecha_partidos_equipob_partido_jugadores_cedula, fecha_partidos_equipob_partido_jugadores_numero = @fecha_partidos_equipob_partido_jugadores_numerofecha_partidos_marcador_partido_goleaequipoa = @fecha_partidos_marcador_partido_goleaequipoa, fecha_partidos_marcador_partido_golesequipob = @fecha_partidos_marcador_partido_golesequipob, fecha_partidos_arbitroprincipal_usuario = @fecha_partidos_arbitroprincipal_usuario, fecha_partidos_arbitroprincipal_psw = @fecha_partidos_arbitroprincipal_pswfecha_partidos_arbitroprincipal_nombre_persona = @fecha_partidos_arbitroprincipal_nombre_persona, fecha_partidos_arbitroprincipal_apellido = @fecha_partidos_arbitroprincipal_apellido, fecha_partidos_arbitroprincipal_cedula = @fecha_partidos_arbitroprincipal_cedula, fecha_partidos_arbitroprincipal_licencia = @fecha_partidos_arbitroprincipal_licencia, fecha_numero_fecha = @fecha_numero_fecha, fecha_fechainicio = @fecha_fechainicio, fecha_fechafin = @fecha_fechafinpartido_equipoa_partido_jugadores_nombre_persona = @partido_equipoa_partido_jugadores_nombre_persona, partido_equipoa_partido_jugadores_apellido = @partido_equipoa_partido_jugadores_apellido, partido_equipoa_partido_jugadores_cedula = @partido_equipoa_partido_jugadores_cedula, partido_equipoa_partido_jugadores_numero = @partido_equipoa_partido_jugadores_numeropartido_equipob_partido_jugadores_nombre_persona = @partido_equipob_partido_jugadores_nombre_persona, partido_equipob_partido_jugadores_apellido = @partido_equipob_partido_jugadores_apellido, partido_equipob_partido_jugadores_cedula = @partido_equipob_partido_jugadores_cedula, partido_equipob_partido_jugadores_numero = @partido_equipob_partido_jugadores_numeropartido_marcador_partido_goleaequipoa = @partido_marcador_partido_goleaequipoa, partido_marcador_partido_golesequipob = @partido_marcador_partido_golesequipob, partido_arbitroprincipal_usuario = @partido_arbitroprincipal_usuario, partido_arbitroprincipal_psw = @partido_arbitroprincipal_pswpartido_arbitroprincipal_nombre_persona = @partido_arbitroprincipal_nombre_persona, partido_arbitroprincipal_apellido = @partido_arbitroprincipal_apellido, partido_arbitroprincipal_cedula = @partido_arbitroprincipal_cedula, partido_arbitroprincipal_licencia = @partido_arbitroprincipal_licenciamarcador_acta_goleaequipoa = @marcador_acta_goleaequipoa, marcador_acta_golesequipob = @marcador_acta_golesequipobequipoa_acta_jugadores_nombre_persona = @equipoa_acta_jugadores_nombre_persona, equipoa_acta_jugadores_apellido = @equipoa_acta_jugadores_apellido, equipoa_acta_jugadores_cedula = @equipoa_acta_jugadores_cedula, equipoa_acta_jugadores_numero = @equipoa_acta_jugadores_numeroequipob_acta_jugadores_nombre_persona = @equipob_acta_jugadores_nombre_persona, equipob_acta_jugadores_apellido = @equipob_acta_jugadores_apellido, equipob_acta_jugadores_cedula = @equipob_acta_jugadores_cedula, equipob_acta_jugadores_numero = @equipob_acta_jugadores_numero WHERE id_acta = @id_acta";

                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    
                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String db_modificar_sobre_fecha(List<ClsParametros> lst) {
            String mensaje = "";
            try {
                if (mensaje == "" && lst != null) {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "UPDATE Fecha SET partidos_equipoa_partido_jugadores_nombre_persona = @partidos_equipoa_partido_jugadores_nombre_persona, partidos_equipoa_partido_jugadores_apellido = @partidos_equipoa_partido_jugadores_apellido, partidos_equipoa_partido_jugadores_cedula = @partidos_equipoa_partido_jugadores_cedula, partidos_equipoa_partido_jugadores_numero = @partidos_equipoa_partido_jugadores_numeropartidos_equipob_partido_jugadores_nombre_persona = @partidos_equipob_partido_jugadores_nombre_persona, partidos_equipob_partido_jugadores_apellido = @partidos_equipob_partido_jugadores_apellido, partidos_equipob_partido_jugadores_cedula = @partidos_equipob_partido_jugadores_cedula, partidos_equipob_partido_jugadores_numero = @partidos_equipob_partido_jugadores_numeropartidos_marcador_partido_goleaequipoa = @partidos_marcador_partido_goleaequipoa, partidos_marcador_partido_golesequipob = @partidos_marcador_partido_golesequipob, partidos_arbitroprincipal_usuario = @partidos_arbitroprincipal_usuario, partidos_arbitroprincipal_psw = @partidos_arbitroprincipal_pswpartidos_arbitroprincipal_nombre_persona = @partidos_arbitroprincipal_nombre_persona, partidos_arbitroprincipal_apellido = @partidos_arbitroprincipal_apellido, partidos_arbitroprincipal_cedula = @partidos_arbitroprincipal_cedula, partidos_arbitroprincipal_licencia = @partidos_arbitroprincipal_licencia, numero_fecha = @numero_fecha, fechainicio = @fechainicio, fechafin = @fechafin WHERE id_fecha = @id_fecha";

                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    
                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String db_modificar_sobre_equipo(List<ClsParametros> lst) {
            String mensaje = "";
            try {
                if (mensaje == "" && lst != null) {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "UPDATE Equipo SET jugadores_nombre_persona = @jugadores_nombre_persona, jugadores_apellido = @jugadores_apellido, jugadores_cedula = @jugadores_cedula, jugadores_numero = @jugadores_numero WHERE id_equipo = @id_equipo";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@id_equipo", lst[0].Id_equipo);
                    
                    
                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String db_modificar_sobre_marcador(List<ClsParametros> lst) {
            String mensaje = "";
            try {
                if (mensaje == "" && lst != null) {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "UPDATE Marcador SET goleaequipoa = @goleaequipoa, golesequipob = @golesequipob WHERE id_marcador = @id_marcador";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@id_marcador", lst[0].Id_marcador);
                    comando.Parameters.AddWithValue("@goleaequipoa", lst[0].Goleaequipoa);
                    comando.Parameters.AddWithValue("@golesequipob", lst[0].Golesequipob);
                    
                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String db_modificar_sobre_tipoalineacion(List<ClsParametros> lst) {
            String mensaje = "";
            try {
                if (mensaje == "" && lst != null) {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "UPDATE TipoAlineacion SET nombre_alineacion = @nombre_alineacion WHERE id_tipoalineacion = @id_tipoalineacion";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@id_tipoalineacion", lst[0].Id_tipoalineacion);
                    comando.Parameters.AddWithValue("@nombre_alineacion", lst[0].Nombre_alineacion);
                    
                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String db_modificar_sobre_alineacion(List<ClsParametros> lst) {
            String mensaje = "";
            try {
                if (mensaje == "" && lst != null) {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "UPDATE Alineacion SET tipo_alineacion_nombre_alineacion = @tipo_alineacion_nombre_alineacionjugador_alineacion_nombre_persona = @jugador_alineacion_nombre_persona, jugador_alineacion_apellido = @jugador_alineacion_apellido, jugador_alineacion_cedula = @jugador_alineacion_cedula, jugador_alineacion_numero = @jugador_alineacion_numeroequipo_jugadores_nombre_persona = @equipo_jugadores_nombre_persona, equipo_jugadores_apellido = @equipo_jugadores_apellido, equipo_jugadores_cedula = @equipo_jugadores_cedula, equipo_jugadores_numero = @equipo_jugadores_numero WHERE id_alineacion = @id_alineacion";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@id_alineacion", lst[0].Id_alineacion);
                    
                    
                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String db_modificar_sobre_partido(List<ClsParametros> lst) {
            String mensaje = "";
            try {
                if (mensaje == "" && lst != null) {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "UPDATE Partido SET equipoa_partido_jugadores_nombre_persona = @equipoa_partido_jugadores_nombre_persona, equipoa_partido_jugadores_apellido = @equipoa_partido_jugadores_apellido, equipoa_partido_jugadores_cedula = @equipoa_partido_jugadores_cedula, equipoa_partido_jugadores_numero = @equipoa_partido_jugadores_numeroequipob_partido_jugadores_nombre_persona = @equipob_partido_jugadores_nombre_persona, equipob_partido_jugadores_apellido = @equipob_partido_jugadores_apellido, equipob_partido_jugadores_cedula = @equipob_partido_jugadores_cedula, equipob_partido_jugadores_numero = @equipob_partido_jugadores_numeromarcador_partido_goleaequipoa = @marcador_partido_goleaequipoa, marcador_partido_golesequipob = @marcador_partido_golesequipob, arbitroprincipal_usuario = @arbitroprincipal_usuario, arbitroprincipal_psw = @arbitroprincipal_pswarbitroprincipal_nombre_persona = @arbitroprincipal_nombre_persona, arbitroprincipal_apellido = @arbitroprincipal_apellido, arbitroprincipal_cedula = @arbitroprincipal_cedula, arbitroprincipal_licencia = @arbitroprincipal_licencia WHERE id_partido = @id_partido";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@id_partido", lst[0].Id_partido);
                    
                    
                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }

        public String db_insertar_sobre_persona(List<ClsParametros> lst) {
            String mensaje = "";
            try {
                if (mensaje == "" && lst != null) {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "INSERT INTO Persona (nombre_persona,apellido,cedula) VALUES(@nombre_persona,@apellido,@cedula)";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@nombre_persona", lst[0].Nombres);
                    comando.Parameters.AddWithValue("@apellido", lst[0].Apellidos);
                    comando.Parameters.AddWithValue("@cedula", lst[0].Cedula);
                    
                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String db_insertar_sobre_administrador(List<ClsParametros> lst) {
            String mensaje = "";
            try {
                if (mensaje == "" && lst != null) {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "INSERT INTO Administrador (nombre_persona,apellido,cedula,usuario,psw) VALUES(@nombre_persona,@apellido,@cedula,@usuario,@psw)";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@nombre_persona", lst[0].Nombres);
                    comando.Parameters.AddWithValue("@apellido", lst[0].Apellidos);
                    comando.Parameters.AddWithValue("@cedula", lst[0].Cedula);
                    comando.Parameters.AddWithValue("@usuario", lst[0].Usuario);
                    comando.Parameters.AddWithValue("@psw", lst[0].Psw);
                    
                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        /// <summary>
        /// Permite llamar al Stored Procedure para almacenar los datos en la base de datos (pd la implementacion en codigo es la misma que si se envia uan sentencia ya qu ese esta usando SqlCommand y eso permite asignar los comandos desde el codigo c# i solo modificando el aspecto de la sentencia para que reciba el formato de un sturedprocedure
        /// </summary>
        /// <param name="lst"></param>
        /// <returns></returns>
        public String db_insertar_sobre_jugador(List<ClsParametros> lst) {
            String mensaje = "";
            try { // Aun no se como administrare el flujo de excepciones, con calma qu eel calmor nos llena de calma
                if (mensaje == "" && lst != null) {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "EXECUTE SP_Jugador_Insertar @nombres, @apellidos, @cedula, @fechanacimiento, @telefono, @nacionalidad, @numero";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@nombres", lst[0].Nombres);
                    comando.Parameters.AddWithValue("@apellidos", lst[0].Apellidos);
                    comando.Parameters.AddWithValue("@cedula", lst[0].Cedula);
                    comando.Parameters.AddWithValue("@fechanacimiento", lst[0].Fechanacimiento);
                    comando.Parameters.AddWithValue("@telefono", lst[0].Telefono);
                    comando.Parameters.AddWithValue("@nacionalidad", lst[0].Nacionalidad);
                    comando.Parameters.AddWithValue("@numero", lst[0].Numero);

                    comando.ExecuteNonQuery();
                    mensaje = "Ejecucion correcta";
                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String db_insertar_sobre_arbitro(List<ClsParametros> lst) {
            String mensaje = "";
            try {
                if (mensaje == "" && lst != null) {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "INSERT INTO Arbitro (usuario,psw,nombre_persona,apellido,cedula,licencia) VALUES(@usuario,@psw,@nombre_persona,@apellido,@cedula,@licencia)";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@usuario", lst[0].Usuario);
                    comando.Parameters.AddWithValue("@psw", lst[0].Psw);
                    comando.Parameters.AddWithValue("@nombre_persona", lst[0].Nombres);
                    comando.Parameters.AddWithValue("@apellido", lst[0].Apellidos);
                    comando.Parameters.AddWithValue("@cedula", lst[0].Cedula);
                    comando.Parameters.AddWithValue("@licencia", lst[0].Licencia);
                    
                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String db_insertar_sobre_campeonato(List<ClsParametros> lst) {
            String mensaje = "";
            try {
                if (mensaje == "" && lst != null) {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "INSERT INTO Campeonato (nombre_campeonado,fechas) VALUES(@nombre_campeonado,@fechas)";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@nombre_campeonado", lst[0].Nombre_campeonado);
                    
                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String db_insertar_sobre_acta(List<ClsParametros> lst) {
            String mensaje = "";
            try {
                if (mensaje == "" && lst != null) {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "INSERT INTO Acta (fecha,partido,marcador_acta,equipoa_acta,equipob_acta) VALUES(@fecha,@partido,@marcador_acta,@equipoa_acta,@equipob_acta)";

                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    
                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String db_insertar_sobre_fecha(List<ClsParametros> lst) {
            String mensaje = "";
            try {
                if (mensaje == "" && lst != null) {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "INSERT INTO Fecha (partidos,numero_fecha,fechainicio,fechafin) VALUES(@partidos,@numero_fecha,@fechainicio,@fechafin)";

                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    
                    comando.Parameters.AddWithValue("@numero_fecha", lst[0].Numero_fecha);
                    comando.Parameters.AddWithValue("@fechainicio", lst[0].Fechainicio);
                    comando.Parameters.AddWithValue("@fechafin", lst[0].Fechafin);
                    
                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String db_insertar_sobre_equipo(List<ClsParametros> lst) {
            String mensaje = "";
            try {
                if (mensaje == "" && lst != null) {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "INSERT INTO Equipo (jugadores) VALUES(@jugadores)";

                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    
                    
                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String db_insertar_sobre_marcador(List<ClsParametros> lst) {
            String mensaje = "";
            try {
                if (mensaje == "" && lst != null) {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "INSERT INTO Marcador (goleaequipoa,golesequipob) VALUES(@goleaequipoa,@golesequipob)";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@goleaequipoa", lst[0].Goleaequipoa);
                    comando.Parameters.AddWithValue("@golesequipob", lst[0].Golesequipob);
                    
                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String db_insertar_sobre_tipoalineacion(List<ClsParametros> lst) {
            String mensaje = "";
            try {
                if (mensaje == "" && lst != null) {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "INSERT INTO TipoAlineacion (nombre_alineacion) VALUES(@nombre_alineacion)";

                    SqlCommand comando = new SqlCommand(cadena, conexion);

                    comando.Parameters.AddWithValue("@nombre_alineacion", lst[0].Nombre_alineacion);
                    
                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String db_insertar_sobre_alineacion(List<ClsParametros> lst) {
            String mensaje = "";
            try {
                if (mensaje == "" && lst != null) {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "INSERT INTO Alineacion (tipo_alineacion,jugador_alineacion,equipo) VALUES(@tipo_alineacion,@jugador_alineacion,@equipo)";

                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    
                    
                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String db_insertar_sobre_partido(List<ClsParametros> lst) {
            String mensaje = "";
            try {
                if (mensaje == "" && lst != null) {
                    SqlConnection conexion = abrir_conexion();

                    String cadena = "INSERT INTO Partido (equipoa_partido,equipob_partido,marcador_partido,arbitroprincipal) VALUES(@equipoa_partido,@equipob_partido,@marcador_partido,@arbitroprincipal)";

                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    
                    
                    comando.ExecuteNonQuery();

                }
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }

        public String db_remover_sobre_persona(int Id_persona) {
            String mensaje = "";
            try {
                SqlConnection conexion = abrir_conexion();
                //Alerta cambiar el idCambiar por el de la base de datos
                String cadena = "delete from Persona where Id_persona = @Id_persona";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_persona", Id_persona);
                comando.ExecuteNonQuery();
                mensaje = "Se realizo la consulta exitosamente de eliminacion de registro";
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String db_remover_sobre_administrador(int Id_persona) {
            String mensaje = "";
            try {
                SqlConnection conexion = abrir_conexion();
                //Alerta cambiar el idCambiar por el de la base de datos
                String cadena = "delete from Administrador where Id_persona = @Id_persona";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_persona", Id_persona);
                comando.ExecuteNonQuery();
                mensaje = "Se realizo la consulta exitosamente de eliminacion de registro";
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }

        /// <summary>
        /// Permite eliminar un registro de la tabla jugador seleccioando eljugador mediante ID
        /// </summary>
        /// <param name="Id_persona"></param>
        /// <returns></returns>
        public String db_remover_sobre_jugador(int Id_persona) {
            String mensaje = "";
            try {
                SqlConnection conexion = abrir_conexion();
                //Alerta cambiar el idCambiar por el de la base de datos
                String cadena = "delete from Jugador where Id_persona = @Id_persona";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_persona", Id_persona);
                comando.ExecuteNonQuery();
                mensaje = "Se realizo la consulta exitosamente de eliminacion de registro";
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String db_remover_sobre_arbitro(int Id_persona) {
            String mensaje = "";
            try {
                SqlConnection conexion = abrir_conexion();
                //Alerta cambiar el idCambiar por el de la base de datos
                String cadena = "delete from Arbitro where Id_persona = @Id_persona";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_persona", Id_persona);
                comando.ExecuteNonQuery();
                mensaje = "Se realizo la consulta exitosamente de eliminacion de registro";
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String db_remover_sobre_campeonato(int Id_campeonato) {
            String mensaje = "";
            try {
                SqlConnection conexion = abrir_conexion();
                //Alerta cambiar el idCambiar por el de la base de datos
                String cadena = "delete from Campeonato where Id_campeonato = @Id_campeonato";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_campeonato", Id_campeonato);
                comando.ExecuteNonQuery();
                mensaje = "Se realizo la consulta exitosamente de eliminacion de registro";
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String db_remover_sobre_acta(int Id_acta) {
            String mensaje = "";
            try {
                SqlConnection conexion = abrir_conexion();
                //Alerta cambiar el idCambiar por el de la base de datos
                String cadena = "delete from Acta where Id_acta = @Id_acta";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_acta", Id_acta);
                comando.ExecuteNonQuery();
                mensaje = "Se realizo la consulta exitosamente de eliminacion de registro";
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String db_remover_sobre_fecha(int Id_fecha) {
            String mensaje = "";
            try {
                SqlConnection conexion = abrir_conexion();
                //Alerta cambiar el idCambiar por el de la base de datos
                String cadena = "delete from Fecha where Id_fecha = @Id_fecha";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_fecha", Id_fecha);
                comando.ExecuteNonQuery();
                mensaje = "Se realizo la consulta exitosamente de eliminacion de registro";
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String db_remover_sobre_equipo(int Id_equipo) {
            String mensaje = "";
            try {
                SqlConnection conexion = abrir_conexion();
                //Alerta cambiar el idCambiar por el de la base de datos
                String cadena = "delete from Equipo where Id_equipo = @Id_equipo";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_equipo", Id_equipo);
                comando.ExecuteNonQuery();
                mensaje = "Se realizo la consulta exitosamente de eliminacion de registro";
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String db_remover_sobre_marcador(int Id_marcador) {
            String mensaje = "";
            try {
                SqlConnection conexion = abrir_conexion();
                //Alerta cambiar el idCambiar por el de la base de datos
                String cadena = "delete from Marcador where Id_marcador = @Id_marcador";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_marcador", Id_marcador);
                comando.ExecuteNonQuery();
                mensaje = "Se realizo la consulta exitosamente de eliminacion de registro";
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }
        public String db_remover_sobre_tipoalineacion(int Id_tipoalineacion) {
            String mensaje = "";
            try {
                SqlConnection conexion = abrir_conexion();
                //Alerta cambiar el idCambiar por el de la base de datos
                String cadena = "delete from TipoAlineacion where Id_tipoalineacion = @Id_tipoalineacion";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_tipoalineacion", Id_tipoalineacion);
                comando.ExecuteNonQuery();
                mensaje = "Se realizo la consulta exitosamente de eliminacion de registro";
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }

        public String db_remover_sobre_alineacion(int Id_alineacion) {
            String mensaje = "";
            try {
                SqlConnection conexion = abrir_conexion();
                //Alerta cambiar el idCambiar por el de la base de datos
                String cadena = "delete from Alineacion where Id_alineacion = @Id_alineacion";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_alineacion", Id_alineacion);
                comando.ExecuteNonQuery();
                mensaje = "Se realizo la consulta exitosamente de eliminacion de registro";
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }

        public String db_remover_sobre_partido(int Id_partido) {
            String mensaje = "";
            try {
                SqlConnection conexion = abrir_conexion();
                //Alerta cambiar el idCambiar por el de la base de datos
                String cadena = "delete from Partido where Id_partido = @Id_partido";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.Parameters.AddWithValue("@Id_partido", Id_partido);
                comando.ExecuteNonQuery();
                mensaje = "Se realizo la consulta exitosamente de eliminacion de registro";
            } catch (Exception ex) {
                cerrar_conexion(); //Por si entra aqui con conexion abierta
                throw ex;
            }
            cerrar_conexion();
            return mensaje;
        }

    }
}