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
    public partial class FrmMostrar : Form
    {
        Centralita c;
        Llamada.TipoLlamada llamada;
        public FrmMostrar(Centralita c)
        {
            this.c = c;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }
        public Llamada.TipoLlamada TipoLlamada
        {
            set
            {
                this.llamada = value;
            }
        }
        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            if (llamada == Llamada.TipoLlamada.Local)
            {
                richTextBox1.Text = c.ToString();
            }
            else if (llamada == Llamada.TipoLlamada.Provincial)
            {
                richTextBox1.Text = c.ToString();
            }
            else
            {
                richTextBox1.Text = c.ToString();
            }
        }
    }
}
