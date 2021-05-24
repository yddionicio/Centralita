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
    public partial class FrmLlamador : Form
    {
        Centralita c;        
        public FrmLlamador(Centralita c)
        {
            this.c = c;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }
        public Centralita GetCentralita
        {
            get
            {
                return this.c;
            }
        }
        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            if (txtNroDestino.Text != string.Empty)
            {
                if (txtNroDestino.Text.Contains("Nro Destino") && txtNroDestino.Text != "Nro Destino")
                {
                    txtNroDestino.Text = txtNroDestino.Text.Replace("Nro Destino", "");
                }

                if (!txtNroDestino.Text.StartsWith("#"))
                {
                    cmbFranja.Enabled = false;
                }
                else
                {
                    cmbFranja.Enabled = true;
                }
            }
            else
            {
                txtNroDestino.Text = "Nro Destino";
            }
        }

        private void txtNroOrigen_KeyPress(object sender, EventArgs e)
        {
            txtNroOrigen.Select(txtNroOrigen.Text.Length, 0);
        }

        private void txtNroOrigen_TextChanged(object sender, EventArgs e)
        {
            if (txtNroOrigen.Text != string.Empty)
            {
                if (txtNroOrigen.Text.Contains("Nro Origen") && txtNroOrigen.Text != "Nro Origen")
                {
                    txtNroOrigen.Text = txtNroOrigen.Text.Replace("Nro Origen", "");
                }
            }
            else
            {
                txtNroOrigen.Text = "Nro Origen";
            }
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "1";
        }
        private void btnDos_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "3";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "6";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "7";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "8";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "9";
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "*";
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "0";
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "#";
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Provincial.Franja franja;
            Llamada llamada;

            if (cmbFranja.Enabled)
            {
                Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franja);
                llamada = new Provincial(txtNroOrigen.Text, franja, random.Next(1, 50), txtNroDestino.Text);
                //Provincial provincial = new Provincial(txtNroOrigen.Text, (Provincial.Franja)cmbFranja.SelectedIndex, random.Next(1, 50), txtNroDestino.Text);
            }
            else
            {
                llamada = new Local(txtNroOrigen.Text, random.Next(1, 50), txtNroDestino.Text, Convert.ToSingle(random.NextDouble() * (0.5 - 5.6) + 0.5));
            }
            this.c += llamada;
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            //Carga
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));       
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.Clear();
            txtNroOrigen.Clear();
            cmbFranja.Text = "";
           
        }


    }
}
