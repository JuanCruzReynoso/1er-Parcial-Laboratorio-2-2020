using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Ticketeadora<T> where T : Utiles
    {
        public static bool ImprimirTicket(Cartuchera<T> c1)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\tickets.log";
            bool rta = true;

            try
            {
                if (File.Exists(ruta))
                {
                    using (StreamWriter sw = new StreamWriter(ruta, true))
                    {
                        sw.WriteLine("Fecha : {0}", DateTime.Now);
                        sw.WriteLine("Total Cartuchera: {0}", c1.PrecioTotal);
                    }
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(ruta, false))
                    {
                        sw.WriteLine("Fecha : {0}", DateTime.Now);
                        sw.WriteLine("Total Cartuchera: {0}", c1.PrecioTotal);
                    }
                }
            }
            catch (Exception e)
            {

                return false;
            }

            return rta;
        }
    }
}