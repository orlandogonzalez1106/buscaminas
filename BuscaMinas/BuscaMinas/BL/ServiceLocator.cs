using Buscaminas.BL.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscaminas.BL
{
    internal class ServiceLocator
    {
        private static ServiceLocator instancia;
        private BuscaminaManager buscaManager;

        internal ServiceLocator()
        {
            buscaManager = new BuscaminaManager();
        }

        internal static ServiceLocator Instancia
        {
            get
            {
                instancia = instancia ?? new ServiceLocator();
                return instancia;
            }
        }

        internal BuscaminaManager ObtenerBuscaminaManager()
        {
            return this.buscaManager;
        }
    }
}
