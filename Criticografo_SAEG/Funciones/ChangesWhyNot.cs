using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Criticografo_SAEG.Funciones
{
    public class ChangesWhyNot
    {
        public string CambiosPorGenero(char lastCharacter, string wordForChange)
        {
            if (lastCharacter == 'a')
            {
                return "s";
            }
            else
            {
                return "d";
            }
        }
    }
}
