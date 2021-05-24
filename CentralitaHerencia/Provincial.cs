using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial: Llamada
    {
        #region Atributos
        public enum Franja {Franja_1, Franja_2, Franja_3}
        protected Franja franjaHoraria;
        #endregion

        #region Propiedades
        public override float CostoLlamada 
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        #endregion

        #region Constructores
        public Provincial(Franja miFranja, Llamada llamada):this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino):base(duracion, destino, origen)
        {
             this.franjaHoraria = miFranja;
        }
        #endregion

        #region Metodos
        private float CalcularCosto()
        {
            if (franjaHoraria == Franja.Franja_1)
            {
                return base.duracion * 0.99f;
            }
            else if (franjaHoraria == Franja.Franja_2)
            {
                return base.duracion * 1.25f;
            }
            else
            {
                return base.duracion * 0.66f;
            }
        }
        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine("Franja horaria: " + this.franjaHoraria);
            sb.AppendLine("Costo Llamada: " + this.CostoLlamada);

            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion

    }
}
