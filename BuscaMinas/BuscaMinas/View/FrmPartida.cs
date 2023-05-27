using Buscaminas.BL;
using Buscaminas.BL.BO;
using Buscaminas.BL.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buscaminas.View
{
    public partial class FrmPartida : Form
    {
        public FrmPartida()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            BuscaminaManager manager = ServiceLocator.Instancia.ObtenerBuscaminaManager();
            Partida partida = manager.CrearNuevaPartida();

            bsPartida.DataSource = partida;
            bsPartida.ResetBindings(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmJuego frmjuego = new FrmJuego();
            frmjuego.Show();
        }
    }
}
