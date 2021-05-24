using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace CentralTelefonica
{
    public partial class FrmMenu : Form
    {
        Centralita c;
        public FrmMenu()
        {
            c = new Centralita();
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador llamador = new FrmLlamador(this.c);
            llamador.ShowDialog();
            this.c = llamador.GetCentralita;
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(this.c);
            mostrar.TipoLlamada = Llamada.TipoLlamada.Todas;
            mostrar.ShowDialog();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(this.c);
            mostrar.TipoLlamada = Llamada.TipoLlamada.Local;
            mostrar.ShowDialog();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(this.c);
            mostrar.TipoLlamada = Llamada.TipoLlamada.Provincial;
            mostrar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
