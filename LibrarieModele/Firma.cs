using System;
using System.Collections;
using System.Collections.Generic;


namespace LibrarieModele
{
    public class Firma
    {
        private const bool SUCCES = true;
        private const string SEPARATOR_AFISARE = " ";
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';
        public string NumeFirma { get; set; }
        public int IdFirma { get; set; }
        public List<Livrator> Livratori = new List<Livrator>();
        public float RaitingFirma { get; set; }
        
        public string LogoUrl { get; set; }
        public Firma()
        {
            NumeFirma = "UNDEFINED";
        }
        public Firma(string _numeFirma,string _logo)
        {
            NumeFirma = _numeFirma;

            LogoUrl = _logo;
            RaitingFirma = 0;
        }
        
        public Firma(string _numeFirma,string _logo, float _raiting)
        {
            NumeFirma = _numeFirma;
            LogoUrl = _logo;
            RaitingFirma = _raiting;
        }
        
        public Firma(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            IdFirma = Int32.Parse(dateFisier[(int)CampuriFirma.ID]);
            NumeFirma = dateFisier[(int)CampuriFirma.NUME_FIRMA];
            RaitingFirma = float.Parse(dateFisier[(int)CampuriFirma.RAITING_FIRMA]);
            LogoUrl = dateFisier[(int)CampuriFirma.LOGO];
            
            if (dateFisier[(int) CampuriFirma.LIVRATORI_FILE].Length != 0)
            {
                
                var livratoriArrStr_From_Fisier = dateFisier[(int) CampuriFirma.LIVRATORI_FILE].Split('$');
                for(int i=0; i<livratoriArrStr_From_Fisier.Length-1;i++)
                {
                    Livratori.Add(new Livrator(livratoriArrStr_From_Fisier[i]));
                }
                
            }
        }
        
        
        public void AddLivrator(Livrator _livrator)
        {
            Livratori.Add(_livrator);
        }

        public string ConversieLaSir()
        {
            return $"Firma cu id: {IdFirma}, nume: {NumeFirma} are {Livratori.Count} livratori si scorul: {RaitingFirma}";
        }
        public string ConversieLaSirPentruScriereInFisier()
        {
            string sNote = string.Empty;
            string livratoriStr = "";
            if (Livratori.Count != 0)
            {
                
                foreach (Livrator l in Livratori)
                {
                    livratoriStr += l.ToStringPentruScriereInFisier() + "$";
                }
            }
            string s = string.Format("{5}{0}{1}{0}{2}{0}{3}{0}{4}",
                SEPARATOR_PRINCIPAL_FISIER, NumeFirma, RaitingFirma.ToString(), LogoUrl,  livratoriStr,IdFirma);
            
            return s;
            
        }

        public List<string> GetLivratoriListString()
        {
            List<string> livratoriToString = new List<string>();
            foreach (Livrator liv in Livratori)
            {
                livratoriToString.Add(liv.ToStringPentruAfisare());
            }

            return livratoriToString;
        }
    }
}