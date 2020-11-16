using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Utiles
    {
        #region Atributos
        public string marca;
        public double precio;
        #endregion

        #region Propiedades
        public abstract bool PreciosCuidados { get; }
        #endregion

        #region Constructores
        public Utiles()
        { }
     
        public Utiles(string marca_, double precio_)
        {
            this.marca = marca_;
            this.precio = precio_;
        }
        #endregion

        #region Metodos
        protected virtual string UtilesToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine();
            sb.AppendFormat("Marca: {0}", this.marca);
            sb.AppendLine();
            sb.AppendFormat("Precio: {0}", this.precio);
            sb.AppendLine();

            return sb.ToString();
        }
       
        public override string ToString()
        {
            return this.UtilesToString();
        }
        #endregion

    }

}