﻿namespace vIT_System.Validering
{
    public static class ValidationCheck
    {
        public static string felString { get; set; }
        /// <summary>
        /// Kontrollerar texten i textboxen baserat på styrparametern. Jag fyller i resten senare.
        /// </summary>
        /// <param name="boxAttKolla">Textboxen som ska kontrolleras</param>
        /// <param name="parameter">Styrparametern</param>
        /// <param name="fältNamn">namnet i felmeddelandet. Fältnamn + "är tom" etc.</param>
        public static void checkValidering(System.Windows.Forms.TextBox boxAttKolla, string parameter, string fältNamn)
        {
            string felMedelande = "";

            if (Validation.IsEmpty(boxAttKolla.Text) && parameter.Equals("tom"))
            {
                felMedelande += "\n• Fältet för " + fältNamn + " är tomt.";
            }

            if (!Validation.IsEmailAddress(boxAttKolla.Text) && parameter.Equals("email"))
            {
                felMedelande += "\n• Fältet för " + fältNamn + " är inte i rätt format.";
            }

            if (Validation.IsLongerThan(boxAttKolla.Text, 255) && parameter.Equals("längre255"))
            {
                felMedelande += "\n• Fältet för " + fältNamn + " innehåller för många tecken.";
            }
            
            if (Validation.IsNumeric(boxAttKolla.Text) && parameter.Equals("siffor"))
            {
                felMedelande += "\n• Fältet för " + fältNamn + " består av siffror.";
            }

            if (Validation.IsAlphabetic(boxAttKolla.Text) && parameter.Equals("bokstäver"))
            {
                felMedelande += "\n• Fältet för " + fältNamn + " består av bokstäver.";
            }  
            if (Validation.IsIntContainer(boxAttKolla.Text) && parameter.Equals("innehållerInt"))
            {
                felMedelande += "\n• Fältet för " + fältNamn + " innehåller siffror.";
            }
            if (Validation.IsLetterContainer(boxAttKolla.Text) && parameter.Equals("InnehållerBokstav"))
            {
                felMedelande += "\n• Fältet för " + fältNamn + " innehåller bokstäver.";
            }
            if (Validation.IsNegativeNumber(boxAttKolla.Text) && parameter.Equals("NegativaTal"))
            {
                felMedelande += "\n• Fältet för " + fältNamn + " innehåller negativa tal.";
            }
           

            felString += felMedelande;
    }
        public static void CheckDates(System.DateTime ut, System.DateTime hem)
        {
            if (Validation.IsLaterDate(ut, hem))
            {
                felString += "\n• Hemresedatum måste vara efter utresedatum.";
            }
        }

        public static void CheckCombox(System.Windows.Forms.ComboBox cb, string fältNamn)
        {
            //string valt = cb.SelectedItem.ToString();
            if (cb.SelectedItem == null)
            {
                felString += "\n• Inget objekt i comboboxen för " + fältNamn + " är valt.";
            }
        }
        public static void CheckSemesterDagar(double resa, double semesterdag)
        {
            if (resa < semesterdag)
            {
                felString += "\n• Semesterdagar måste vara mindre än totalt bortresta dagar.";
            }
        }
    }
}
