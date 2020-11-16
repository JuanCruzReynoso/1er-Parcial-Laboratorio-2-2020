using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
        public class CartucheraLlenaException : Exception
        {
            #region Constructores
            public CartucheraLlenaException() : base("La cartuchera  esta llena ")
            { }

            #endregion
        }

}