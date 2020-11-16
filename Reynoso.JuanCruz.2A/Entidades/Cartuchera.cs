using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera <T> where T : Utiles
    {
        #region Atributos
        protected int capacidad;
        protected List<T> elementos;
        public delegate void DelegadoLimitePrecio(Object sender, EventArgs e);
        public event DelegadoLimitePrecio EventoPrecio;
        #endregion

        #region Propiedades
        public List<T> Elementos { get { return this.elementos; } }

        public double PrecioTotal
        {
            get 
            {
                double retorno = 0;
                foreach (T item in this.elementos)
                {
                    retorno += item.precio;
                }
                return retorno;
            
            }
        }
        #endregion

        #region Constructores
        public Cartuchera()
        {
            this.elementos = new List<T>();
        }

        public Cartuchera(int capacidad_) : this()
        {
            this.capacidad = capacidad_;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine();
            sb.AppendFormat("Tipo de Cartuchera: {0}", typeof(T).Name);
            sb.AppendLine();
            sb.AppendFormat("Cantidad de Elementos: {0}", this.elementos.Count());
            sb.AppendLine();
            sb.AppendFormat("Precio Total: {0}", this.PrecioTotal);
            sb.AppendLine("Lista de elementos.");

            foreach (T item in this.elementos)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
        #endregion

        #region Sobrecargas
        public static Cartuchera<T> operator +(Cartuchera<T> c1, T elemento)
        {
            if (c1.capacidad > c1.elementos.Count && c1 != null)
            {
                c1.elementos.Add(elemento);
            }
            else
            {
                throw new CartucheraLlenaException();
            }
            if (c1.PrecioTotal > 85 && c1.EventoPrecio != null) //si el preco total es mayor a 85 lanzo el evento 
            {
                c1.EventoPrecio.Invoke(c1, EventArgs.Empty);
            }
            return c1;
        }
        #endregion
    }
}
