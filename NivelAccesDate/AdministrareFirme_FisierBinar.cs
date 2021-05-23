using LibrarieModele;
using System;
using System.Collections;
using System.Collections.Generic;
namespace NivelAccesDate
{
   
    public class AdministrareFirme_FisierBinar : IStocareData
    {
        string NumeFisier { get; set; }
        public AdministrareFirme_FisierBinar(string numeFisiser)
        {
            this.NumeFisier = NumeFisier;
        }

        public void AddFirma(Firma s)
        {
            throw new Exception("Optiunea AddFirma nu este implementata");
        }
        
        public Firma GetFirmaByID(int _id)
        {
            throw new Exception("Optiunea GetFirmaById nu este implementata");
        }

        public List<Firma> GetFirme()
        {
            throw new Exception("Optiunea GetFirme nu este implementata");
        }
        public void UpdateFirma(Firma f)
        {
            throw new Exception("Optiunea UpdateFirma nu este implementata");
        }
    }
}