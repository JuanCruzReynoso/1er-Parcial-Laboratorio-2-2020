using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sacapunta : Utiles
    {
        #region Atributos
        public bool deMetal;
        #endregion

        #region Propiedades
        public override bool PreciosCuidados
        {
            get
            {
                return false;
            }
        }
        #endregion

        #region Constructores
        public Sacapunta()
        { }

        public Sacapunta(bool isMetal_, double precio_, string marca_)
            : base(marca_, precio_)
        {
            this.deMetal = isMetal_;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.UtilesToString());
            sb.AppendFormat("es de Metal?: {0}", this.deMetal);
            sb.AppendLine();
            sb.AppendFormat("Precio cuidado? {0}", this.PreciosCuidados);

            return sb.ToString();
        }
        #endregion
    }
}
