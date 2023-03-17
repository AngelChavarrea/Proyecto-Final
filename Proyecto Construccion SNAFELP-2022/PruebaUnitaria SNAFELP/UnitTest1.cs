using CapaLogicadeNegocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PruebaUnitaria_SNAFELP
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Se registra un jugador con los datos correctos desde la capa Logica de negocio
        /// </summary>
        [TestMethod]
        public void CP_ClsJugador_Rec_000_Caso_000_Correcto()
        {
            ClsJugador clsJugador = new ClsJugador();
            clsJugador.Nombres = "adc";
            clsJugador.Apellidos = "adc";
            clsJugador.Cedula = "0912345678";
            clsJugador.Fechanacimiento = DateTime.Now;
            clsJugador.Telefono = "042123456";
            clsJugador.Nacionalidad = "Ecuatoriana";
            clsJugador.Numero = 10;
            string valor = clsJugador.registrar();
            Assert.AreEqual("Insertado correctamente", valor);
        }
    }
}
