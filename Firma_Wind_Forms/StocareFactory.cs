using System;
using NivelAccesDate;
using System.Configuration;
namespace Firma_Wind_Forms
{
    public class StocareFactory
    {
        private const string FORMAT_SALVARE = "FormatSalvare";
        private const string NUME_FISIER = "NumeFisier";

        public static IStocareData GetAdministratorStocare()
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisier = ConfigurationManager.AppSettings[NUME_FISIER];
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "bin":
                        return new AdministrareFirme_FisierBinar(numeFisier + "." + formatSalvare);
                    case "txt":
                        return new AdministrareFirme_FisierText(numeFisier + "." + formatSalvare);
                }
            }

            return null;
        }
    }
}