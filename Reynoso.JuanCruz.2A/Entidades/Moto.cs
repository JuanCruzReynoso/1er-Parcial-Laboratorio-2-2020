using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        #region Atributos
        public ECilindrada cilindrada;
        #endregion

        #region Constructores
        public Moto(string marca, EPais pais, string modelo, float precio, ECilindrada cilindrada)
            : base(marca, pais, modelo, precio)
        {
            this.cilindrada = cilindrada;
        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(Moto m1, Moto m2)
        {
            return (Vehiculo)m1 == (Vehiculo)m2 && m1.cilindrada == m2.cilindrada;
        }

        public static bool operator !=(Moto m1, Moto m2)
        {
            return !(m1 == m2);
        }

        public static implicit operator Single(Moto m)
        {
            return m.precio;
        }
      
        public override bool Equals(object obj)
        {
            return (Moto)obj == this;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"{(string)(Vehiculo)this}");
            sb.AppendFormat($"CILINDRADA: {this.cilindrada}\n");

            return sb.ToString();
        }
        #endregion
    }
}
