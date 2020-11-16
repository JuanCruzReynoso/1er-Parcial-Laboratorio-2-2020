using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto : Vehiculo
    {
        #region Atributos
        public ETipo tipo;
        #endregion

        #region Constructores
        public Auto(string modelo, float precio, Fabricante fabri, ETipo tipo)
            : base(precio, modelo, fabri)
        {
            this.tipo = tipo;
        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(Auto a1, Auto a2)
        {
            return (Vehiculo)a1 == (Vehiculo)a2 && a1.tipo == a2.tipo;
        }

        public static bool operator !=(Auto a1, Auto a2)
        {
            return !(a1 == a2);
        }

        public static explicit operator Single(Auto a)
        {
            return a.precio;
        }
      
        public override bool Equals(object obj)
        {
            return ((Auto)obj) == this;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"{(string)(Vehiculo)this}");
            sb.AppendFormat($"TIPO: {this.tipo}\n");

            return sb.ToString();
        }
        #endregion
    }
}
