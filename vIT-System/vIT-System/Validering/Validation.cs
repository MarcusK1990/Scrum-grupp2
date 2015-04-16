using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


//IsAlphabetic och IsNumeric kanske ska tas bort
namespace vIT_System
{
    static class Validation
    {
        /// <summary>
        /// Kontrollerar om en sträng är kortare än en viss längd
        /// </summary>
        /// <param name="str">Strängen som du vill kontrollera</param>
        /// <param name="maxlength">Maxlängden på strängen som du vill kontrollera</param>
        /// <returns>Boolean</returns>
        public static bool IsShorterThan(string str, int maxlength)
        {
            return (str.Length < maxlength) ? true : false;
        }
        /// <summary>
        /// Kontrollerar om en sträng är längre än en viss längd
        /// </summary>
        /// <param name="str">Strängen som du vill kontrollera</param>
        /// <param name="minlength">Minimilängden på strängen som du vill kontrollera</param>
        /// <returns>Boolean</returns>
        public static bool IsLongerThan(string str, int minlength)
        {
            return (str.Length > minlength) ? true : false;
        }
        /// <summary>
        /// Kontrollera om en sträng är tom
        /// </summary>
        /// <param name="str">Strängen som du vill kontrollera</param>
        /// <returns>Boolean</returns>
        public static bool IsEmpty(string str)
        {
            return String.IsNullOrWhiteSpace(str);
        }
        /// <summary>
        /// Testa om en sträng följer formatet, är strängen tom så körs inte valideringen [text]@[text].[text]
        /// </summary>
        /// <param name="str">Strängen som du vill kontrollera</param>
        /// <returns>Boolean</returns>
        public static bool IsEmailAddress(string str)
        {
            if (String.IsNullOrWhiteSpace(str))
            {
                return true;
            }
            Regex regex = new Regex("[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z0-9]+");
            return regex.IsMatch(str);
            
        }
        /// <summary>
        /// Testa om en sträng enbart innehåller bokstäver, är strängen tom så körs inte valideringen
        /// </summary>
        /// <param name="str">Strängen som du vill kontrollera</param>
        /// <returns>Boolean</returns>
        public static bool IsAlphabetic(string str)
        {
            if (!String.IsNullOrWhiteSpace(str))
            {
                Regex regex = new Regex("[0-9]");
                return !regex.IsMatch(str);
            }
            return false;
        }
        /// <summary>
        /// Testa om en sträng enbart innehåller siffror, är strängen tom så körs inte valideringen
        /// </summary>
        /// <param name="str">Strängen som du vill kontrollera</param>
        /// <returns>Boolean</returns>
        public static bool IsNumeric(string str)
        {
            if (!String.IsNullOrWhiteSpace(str))
            {
                Regex regex = new Regex("[A-Za-z]");
                return !regex.IsMatch(str);
            }
            return false;
        }
        //Testa om en sträng innehåller en int
        public static bool IsIntContainer(string str)
        {
            if (str.Any(char.IsDigit))
            {
                return true;
            }
            return false;
        }
        //Testa om en sträng innehåller bokstäver
        public static bool IsLetterContainer(string str)
        {
            if (str.Any(char.IsLetter))
            {
                return true;
            }
            return false;
        }

    }
}
