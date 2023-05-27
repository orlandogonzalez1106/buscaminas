using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscaminas.BL.BO
{
    internal class Partida
    {
        public Jugador Jugador { get; set; }
        public Campo Campo { get; set; }
        public int CantidadFilas { get; set; }
        public int CantidadColumnas { get; set; }


        public string NombreJugador
        {
            get
            {
                return this.Jugador.Nombre;
            }

            set
            {
                this.Jugador.Nombre = value;
            }
        }
    }
}
