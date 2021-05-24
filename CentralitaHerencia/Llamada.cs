﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract class Llamada
    {
        public enum TipoLlamada { Local, Provincial, Todas }

        #region Atributos

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        #endregion

        #region Propiedades
        public abstract float CostoLlamada
        {
            get;
        }
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        #endregion

        #region Constructores
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        #endregion

        #region Metodos
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("\nDuracion: "+ this.duracion);
            sb.AppendLine("Numero destino: "+ this.nroDestino);
            sb.AppendLine("Numero origen: "+ this.nroOrigen);

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.duracion < llamada2.duracion)
            {
                return -1;
            }
            else if (llamada1.duracion > llamada2.duracion)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        #endregion

        #region Operadores
        public static bool operator != (Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }
        public static bool operator ==(Llamada l1, Llamada l2)
        {
            return l1.Equals(l2) && l1.nroDestino == l2.nroDestino && l1.nroOrigen == l2.nroOrigen;
        }
        #endregion

    }
}
