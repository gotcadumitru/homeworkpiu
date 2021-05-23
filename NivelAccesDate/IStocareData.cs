using LibrarieModele;
using System.Collections;
using System.Collections.Generic;
namespace NivelAccesDate
{

    public interface IStocareData
    {
        void AddFirma(Firma f);
        List<Firma> GetFirme();
        Firma GetFirmaByID(int _id);
        
        void UpdateFirma(Firma f);
    }
}