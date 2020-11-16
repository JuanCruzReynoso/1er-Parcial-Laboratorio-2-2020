using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Lapiz : Utiles, ISerializa, IDeserializa
    {
        #region Atributos
        public ConsoleColor color;
        public ETipoTrazo trazo;
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

        public Lapiz()
        { }

        public Lapiz(ConsoleColor _color, ETipoTrazo tTrazo, string marca_, double precio_)
            : base(marca_, precio_)
        {
            this.color = _color;
            this.trazo = tTrazo;
        }
        #endregion

        #region Metodos

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.UtilesToString());
            sb.AppendFormat("Color: {0}", this.color.ToString());
            sb.AppendLine();
            sb.AppendFormat("tipo de Trazo: {0}", this.trazo.ToString());
            sb.AppendLine();
            sb.AppendFormat("Precio cuidado? {0}", this.PreciosCuidados);
            sb.AppendLine();

            return sb.ToString();
        }

        #region Iplementacion ISerializa

        public string Path
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Arismendy.Herik.Lapiz.xml";
            }
        }

        public bool Xml()
        {
            bool rta = true;

            try
            {
                using (XmlTextWriter xmlTW = new XmlTextWriter(this.Path, Encoding.UTF8))
                {
                    XmlSerializer xmlS = new XmlSerializer(typeof(Lapiz));
                    xmlS.Serialize(xmlTW, this);
                }
            }
            catch (Exception)
            {

                rta = false;
            }

            return rta;
        }
        #endregion

        #region Implementacion IDeserializa

        bool IDeserializa.Xml(out Lapiz lapiz)
        {

            bool rta = true;

            try
            {
                using (XmlTextReader xmlTR = new XmlTextReader(this.Path))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Lapiz));
                    lapiz = (Lapiz)ser.Deserialize(xmlTR);
                }
            }
            catch (Exception)
            {
                lapiz = new Lapiz();
                rta = false;
            }


            return rta;
        }

        #endregion
        #endregion
    }
}
