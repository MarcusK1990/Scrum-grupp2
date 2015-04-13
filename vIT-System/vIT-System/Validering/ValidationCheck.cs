using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vIT_System.Validering
{
    public static class ValidationCheck
    {
        public static string rickardsträng { get; set; }
        /// <summary>
        /// Kontrollerar texten i textboxen baserat på styrparametern. Jag fyller i resten senare.
        /// </summary>
        /// <param name="boxAttKolla">Textboxen som ska kontrolleras</param>
        /// <param name="parameter">Styrparametern</param>
        /// <param name="fältNamn">namnet i felmeddelandet. Fältnamn + "är tom" etc.</param>
        public static void checkValidering(System.Windows.Forms.TextBox boxAttKolla, string parameter, string fältNamn)
        {
            Boolean fel = false;
            string felMedelande = "";

            if (Validation.IsEmpty(boxAttKolla.Text) && parameter.Equals("tom"))
            {
                fel = true;
                felMedelande += "\n• Fältet för " + fältNamn + " är tomt.";
            }
            if (Validation.IsEmailAddress(boxAttKolla.Text) && parameter.Equals("email"))
            {
                fel = true;
                felMedelande += "\n• Fältet för " + fältNamn + " är inte i rätt format.";
            }
            if (Validation.IsLongerThan(boxAttKolla.Text, 255) && parameter.Equals("längre än 255"))
            {
                fel = true;
                felMedelande += "\n• Fältet för " + fältNamn + " innehåller för många tecken.";
            }
            
            if (Validation.IsNumeric(boxAttKolla.Text) && parameter.Equals("siffor"))
            {
                fel = true;
                felMedelande += "\n• Fältet för " + fältNamn + " innehåller siffror.";
            }
            if (Validation.IsAlphabetic(boxAttKolla.Text) && parameter.Equals("bokstäver"))
            {
                fel = true;
                felMedelande += "\n• Fältet för " + fältNamn + " innehåller bokstäver.";
            }   
            if (fel)
            {
                Console.WriteLine("nånting är fel");
            }

            rickardsträng += felMedelande;
    }
    }
}
