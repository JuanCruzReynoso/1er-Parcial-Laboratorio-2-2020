using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Goma : Utiles
    {
        #region Atributos
        public bool soloLapiz;
        #endregion

        #region Propiedades
        public override bool PreciosCuidados
        {
            get
            {
                return true;
            }
        }
        #endregion

        #region Constructores
        public Goma()
        { }

        public Goma(bool soloLapiz_, string marca_, double precio_)
             : base(marca_, precio_)
        {
            this.soloLapiz = soloLapiz_;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.UtilesToString());
            sb.AppendFormat("Solo lapiz?: {0}", this.soloLapiz);
            sb.AppendLine();
            sb.AppendFormat("Precio cuidado? {0}", this.PreciosCuidados);
            sb.AppendLine(); 

            return sb.ToString();
        }
        #endregion

    }
}
