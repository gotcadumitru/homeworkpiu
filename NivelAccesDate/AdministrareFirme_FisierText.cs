using LibrarieModele;
using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
namespace NivelAccesDate
{
    public class AdministrareFirme_FisierText : IStocareData
    {
        string NumeFisier { get; set; }

        public AdministrareFirme_FisierText(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            sFisierText.Close();

        }
        public void AddFirma(Firma f)
        {
            try
            {

                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
                {
                    swFisierText.WriteLine(f.ConversieLaSirPentruScriereInFisier());
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }

        public List<Firma> GetFirme()
        {
            List < Firma > firme = new List<Firma>();
            
            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;
                        
                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Firma firmaDinFisier = new Firma(line);
                        firme.Add(firmaDinFisier);
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return firme;
        } 
        public Firma GetFirmaByID(int _id)
        {
            List<Firma> firme = GetFirme();

            Firma findFirma = new Firma();
            
            foreach (Firma f in firme)
            {
                if (f.IdFirma == _id)
                {
                    return f;
                }
            }

            return findFirma;
        }

        public void UpdateFirma(Firma f)
        {
            List<Firma> firme = GetFirme();
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier,false))
                {
                    foreach (Firma firma in firme)
                    {
                        if (f.IdFirma == firma.IdFirma)
                        {
                            swFisierText.WriteLine(f.ConversieLaSirPentruScriereInFisier()); 
                        }
                        else
                        {
                            swFisierText.WriteLine(firma.ConversieLaSirPentruScriereInFisier());
                        }
                    }
                    
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            
        }
    }
}
