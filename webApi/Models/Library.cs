using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webApi.Models
{
    public class Library
    {
        public static bool validKey(string autenticacion)
        {
            /*Agregamos nuestra logica de validacion*/
            return true;
        }

        public static bool invalidKey(string autenticacion)
        {
            return false;
        }
    }
}