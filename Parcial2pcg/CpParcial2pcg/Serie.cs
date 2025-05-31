using ClnParcial2pcg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpParcial2pcg
{
    public partial class Serie: Form
    {
        private SerieService servicio = new SerieService();
        private int? idSeleccionado = null;
        public Serie()
        {
            InitializeComponent();
            CargarSeries();
        }

        private void CargarSeries()
        {
            dgvSeries.DataSource = servicio.ObtenerSeries();
            dgvSeries.Columns["Estado"].Visible = false;
        }

        private void lblCedulaIdentidad_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
