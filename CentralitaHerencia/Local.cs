using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local: Llamada 
    {
        #region Atributos
        protected float costo;
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
        public Local(Llamada llamada, float costo):this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
        }
        public Local(string origen, float duracion, string destino, float costo):base(duracion, destino, origen)
        {
            this.costo = costo;
        }
        #endregion

        #region Metodos
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine("Costo llamada: " + this.CostoLlamada);

            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            return obj is Local;
        }
        private float CalcularCosto()
        {
            return this.costo * base.duracion;
        }
        #endregion
    }
}
