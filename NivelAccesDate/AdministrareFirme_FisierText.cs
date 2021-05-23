using LibrarieModele;
using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
namespace NivelAccesDate
{
    public class AdministrareFirme_FisierText : IStocareData
    {
        private const int ID_PRIMUL_STUDENT = 1;
        private const int INCREMENT = 1;
        string NumeFisier { get; set; }

        public AdministrareFirme_FisierText(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            sFisierText.Close();

        }
        public void AddFirma(Firma f)
        {
            f.IdFirma = GetId();
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
            var firme = new List<Firma>();
            
            try
            {
                using (var sr = new StreamReader(NumeFisier))
                {
                    string line;
                        
                    while ((line = sr.ReadLine()) != null)
                    {
                        var firmaDinFisier = new Firma(line);
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
            var firme = GetFirme();

            var findFirma = new Firma();
            
            foreach (var f in firme)
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
            var firme = GetFirme();
            try
            {
                using (var swFisierText = new StreamWriter(NumeFisier, false))
                {
                    foreach (var firma in firme)
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

        private int GetId()
            {
                int IdFirma = ID_PRIMUL_STUDENT;
                try
                {
                    // instructiunea 'using' va apela sr.Close()
                    using (StreamReader sr = new StreamReader(NumeFisier))
                    {
                        string LinieDinFisier;
                        Firma ultimaFirmaDinFisier = null;

                        //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                        while ((LinieDinFisier = sr.ReadLine()) != null)
                        {
                            ultimaFirmaDinFisier = new Firma(LinieDinFisier);
                        }

                        if (ultimaFirmaDinFisier != null)
                        {
                            IdFirma = ultimaFirmaDinFisier.IdFirma + INCREMENT;
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
                return IdFirma;
            }
        }
}
