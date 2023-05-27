using Buscaminas.BL.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscaminas.BL.Manager
{
    internal class BuscaminaManager
    {
        /// <summary>
        /// Crea una nueva partida.
        /// </summary>
        /// <returns>Retorna una nueva partida</returns>
        internal Partida CrearNuevaPartida()
        {
            Partida partidaNueva = new Partida();
            partidaNueva.Jugador = new Jugador();
            partidaNueva.Campo = new Campo();
            partidaNueva.CantidadFilas = 10;
            partidaNueva.CantidadColumnas = 10;
            partidaNueva.NombreJugador = "Orlando el master.";

            return partidaNueva;
        }
    }
}
