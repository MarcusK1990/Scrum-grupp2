using System;
using System.Globalization;
using System.Net;

namespace vIT_System.XmlRelaterat {

    public static class TestaValutaOmvandlare {

        public static decimal HämtaValutaKurs(string från, string till) {
            decimal result;
            using (var wc = new WebClient()) {
                var data =
                    wc.DownloadString(string.Format("http://download.finance.yahoo.com/d/quotes.csv?s={0}{1}=X&f=sl1d1t1ba&e=.csv",
                    från, till));
                var rate = data.Split(',')[1];
                const NumberStyles style = NumberStyles.Number;
                var culture = CultureInfo.InvariantCulture;
                decimal.TryParse(rate, style, culture, out result);
                }
            return result;
            }

        public static double KonverteraTillFrån(string till, string från, string antal){
            
            decimal belopp;
            Decimal.TryParse(antal, out belopp);

            var kurs = HämtaValutaKurs(från, till);

            var beloppgångerkurs = belopp * kurs;
            double asd;
              Double.TryParse(beloppgångerkurs.ToString(), out asd)  ;

            return asd;
        }
        }
    }