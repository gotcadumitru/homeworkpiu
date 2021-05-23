using LibrarieModele;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace NivelAccesDate
{
   
    public class AdministrareFirme_FisierBinar : IStocareData
    {
        private const int ID_PRIMUL_STUDENT = 1;
        private const int INCREMENT = 1;
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
        
        private int GetId()
        {
            int IdFirma = ID_PRIMUL_STUDENT;
            try
            {
                //instructiunea 'using' va apela sBinFile.Close();
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Open))
                {
                    BinaryFormatter b = new BinaryFormatter();

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while (sBinFile.Position < sBinFile.Length)
                    {
                        //Observati conversia!!!
                        Firma f = (Firma)b.Deserialize(sBinFile);
                        IdFirma = f.IdFirma + INCREMENT;
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