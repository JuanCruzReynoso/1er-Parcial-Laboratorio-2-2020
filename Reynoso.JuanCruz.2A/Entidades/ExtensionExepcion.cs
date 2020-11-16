using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ExtensionExepcion
    {
        public static string InformarNovedad(this CartucheraLlenaException cLE)
        {
            return "La cartuchera esta llena y no admite mas elementos.";
        }
    }
}
